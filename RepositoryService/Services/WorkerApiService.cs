using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using RepositoryService;
using RepositoryService.Repository.Implementatin;
using RepositoryService.Repository.common;
using RepositoryService.Repository.Interfaces;
using RepositoryService.Repository.Models;

namespace RepositoryService.Services;

public class WorkerApiService : WorkerService.WorkerServiceBase
{
    IRepository _Repository;
    
    public WorkerApiService(IRepository repository)
    {
        _Repository = repository;
    }
    
    /*
    public WorkerApiService()
    {
        _Repository = new Repository.Implementatin.Repository();
    }
    */

    public override Task<ListReply> ListWorker(Empty request, ServerCallContext context)
    {
        var listReply = new ListReply();
        var workerList = _Repository.Workers.Select(item => Utils.Converter.WorkerToWorkerGrpcObj(item)).ToList();
        listReply.Workers.AddRange(workerList);

        return Task.FromResult(listReply);
    }


    public override async Task<WorkerGrpcObj> GetWorker(GetWorkerRequest request, ServerCallContext context)
    {
        var worker = await _Repository.ReadWorkerAsync(request.Id);
        if (worker == null)
        {
            throw new RpcException(new Status(StatusCode.NotFound, "worker not found"));
        }

        WorkerGrpcObj userReply = Utils.Converter.WorkerToWorkerGrpcObj(worker);
       
        return await Task.FromResult(userReply);
    }


    public override async Task<WorkerGrpcObj> CreateWorker(WorkerGrpcObj request, ServerCallContext context)
    {
        var worker = Utils.Converter.WorkerGrpcObjToWorker(request);

        await _Repository.CreateWorkerAsync(worker);

        WorkerGrpcObj reply = Utils.Converter.WorkerToWorkerGrpcObj(worker);
        return await Task.FromResult(reply);
    }


    public override async Task<WorkerGrpcObj> UpdateWorker(WorkerGrpcObj request, ServerCallContext context)
    {
        var worker = Utils.Converter.WorkerGrpcObjToWorker(request);

        if (!await _Repository.UpdateWorkerAsync(worker))
        {
            throw new RpcException(new Status(StatusCode.NotFound, "worker not found"));
        }

        return await Task.FromResult(request);
    }



    public override async Task<WorkerGrpcObj> DeleteWorker(DeleteWorkerRequest request, ServerCallContext context)
    {
        var worker = await _Repository.ReadWorkerAsync(request.Id);

        if (worker != null && !await _Repository.DeleteWorkerAsync(request.Id))
        {
            throw new RpcException(new Status(StatusCode.NotFound, "worker not found"));
        }

        WorkerGrpcObj reply = Utils.Converter.WorkerToWorkerGrpcObj(worker);
        return await Task.FromResult(reply);
    }
}