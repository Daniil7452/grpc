using Grpc.Net.Client;
using RepositoryService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testClient.Model.Repository.gRPC
{
    internal class GrpcRepositoryClient
    {
        GrpcChannel _channel;
        WorkerService.WorkerServiceClient _client;
        public GrpcRepositoryClient(string adres)
        {
            _channel = GrpcChannel.ForAddress(adres);
            _client = new WorkerService.WorkerServiceClient(_channel);
        }

        public async Task<IEnumerable<Worker>?> GetWorkersAsync()
        {
            try
            {
                var workers = await _client.ListWorkerAsync(new Google.Protobuf.WellKnownTypes.Empty());
                return workers.Workers.Select(item => testClient.Utils.Converter.WorkerGrpcObjToWorker(item));
            }
            catch
            {
                return null;
            }
        }


        public async Task<Worker> ReadWorkerAsync(int id)
        {
            return testClient.Utils.Converter.WorkerGrpcObjToWorker(await _client.GetWorkerAsync(new GetWorkerRequest() { Id = id }));
        }

        public async Task<bool> CreateWorkerAsync(Worker value)
        {
            try
            {
                var newWorker = await _client.CreateWorkerAsync(testClient.Utils.Converter.WorkerToWorkerGrpcObj(value));
                return value.Equals(testClient.Utils.Converter.WorkerGrpcObjToWorker(newWorker));
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> UpdateWorkerAsync(Worker value)
        {
            var worker = await _client.UpdateWorkerAsync(testClient.Utils.Converter.WorkerToWorkerGrpcObj(value));
            return worker.Equals(testClient.Utils.Converter.WorkerToWorkerGrpcObj(value));
        }

        public async Task<bool> DeleteWorkerAsync(Worker value)
        {
            var worker = await _client.DeleteWorkerAsync(new DeleteWorkerRequest() { Id = value.Id });
            return worker.Equals(testClient.Utils.Converter.WorkerToWorkerGrpcObj(value));
        }
    }
}
