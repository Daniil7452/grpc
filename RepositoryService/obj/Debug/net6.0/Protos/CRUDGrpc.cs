// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/CRUD.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981
#region Designer generated code

using grpc = global::Grpc.Core;

namespace RepositoryService {
  public static partial class WorkerService
  {
    static readonly string __ServiceName = "RepositoryService.WorkerService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::RepositoryService.ListReply> __Marshaller_RepositoryService_ListReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::RepositoryService.ListReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::RepositoryService.GetWorkerRequest> __Marshaller_RepositoryService_GetWorkerRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::RepositoryService.GetWorkerRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::RepositoryService.WorkerGrpcObj> __Marshaller_RepositoryService_WorkerGrpcObj = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::RepositoryService.WorkerGrpcObj.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::RepositoryService.DeleteWorkerRequest> __Marshaller_RepositoryService_DeleteWorkerRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::RepositoryService.DeleteWorkerRequest.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::RepositoryService.ListReply> __Method_ListWorker = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::RepositoryService.ListReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListWorker",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_RepositoryService_ListReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::RepositoryService.GetWorkerRequest, global::RepositoryService.WorkerGrpcObj> __Method_GetWorker = new grpc::Method<global::RepositoryService.GetWorkerRequest, global::RepositoryService.WorkerGrpcObj>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetWorker",
        __Marshaller_RepositoryService_GetWorkerRequest,
        __Marshaller_RepositoryService_WorkerGrpcObj);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::RepositoryService.WorkerGrpcObj, global::RepositoryService.WorkerGrpcObj> __Method_CreateWorker = new grpc::Method<global::RepositoryService.WorkerGrpcObj, global::RepositoryService.WorkerGrpcObj>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateWorker",
        __Marshaller_RepositoryService_WorkerGrpcObj,
        __Marshaller_RepositoryService_WorkerGrpcObj);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::RepositoryService.WorkerGrpcObj, global::RepositoryService.WorkerGrpcObj> __Method_UpdateWorker = new grpc::Method<global::RepositoryService.WorkerGrpcObj, global::RepositoryService.WorkerGrpcObj>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateWorker",
        __Marshaller_RepositoryService_WorkerGrpcObj,
        __Marshaller_RepositoryService_WorkerGrpcObj);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::RepositoryService.DeleteWorkerRequest, global::RepositoryService.WorkerGrpcObj> __Method_DeleteWorker = new grpc::Method<global::RepositoryService.DeleteWorkerRequest, global::RepositoryService.WorkerGrpcObj>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteWorker",
        __Marshaller_RepositoryService_DeleteWorkerRequest,
        __Marshaller_RepositoryService_WorkerGrpcObj);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::RepositoryService.CRUDReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of WorkerService</summary>
    [grpc::BindServiceMethod(typeof(WorkerService), "BindService")]
    public abstract partial class WorkerServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::RepositoryService.ListReply> ListWorker(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::RepositoryService.WorkerGrpcObj> GetWorker(global::RepositoryService.GetWorkerRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::RepositoryService.WorkerGrpcObj> CreateWorker(global::RepositoryService.WorkerGrpcObj request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::RepositoryService.WorkerGrpcObj> UpdateWorker(global::RepositoryService.WorkerGrpcObj request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::RepositoryService.WorkerGrpcObj> DeleteWorker(global::RepositoryService.DeleteWorkerRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(WorkerServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ListWorker, serviceImpl.ListWorker)
          .AddMethod(__Method_GetWorker, serviceImpl.GetWorker)
          .AddMethod(__Method_CreateWorker, serviceImpl.CreateWorker)
          .AddMethod(__Method_UpdateWorker, serviceImpl.UpdateWorker)
          .AddMethod(__Method_DeleteWorker, serviceImpl.DeleteWorker).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, WorkerServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ListWorker, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::RepositoryService.ListReply>(serviceImpl.ListWorker));
      serviceBinder.AddMethod(__Method_GetWorker, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::RepositoryService.GetWorkerRequest, global::RepositoryService.WorkerGrpcObj>(serviceImpl.GetWorker));
      serviceBinder.AddMethod(__Method_CreateWorker, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::RepositoryService.WorkerGrpcObj, global::RepositoryService.WorkerGrpcObj>(serviceImpl.CreateWorker));
      serviceBinder.AddMethod(__Method_UpdateWorker, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::RepositoryService.WorkerGrpcObj, global::RepositoryService.WorkerGrpcObj>(serviceImpl.UpdateWorker));
      serviceBinder.AddMethod(__Method_DeleteWorker, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::RepositoryService.DeleteWorkerRequest, global::RepositoryService.WorkerGrpcObj>(serviceImpl.DeleteWorker));
    }

  }
}
#endregion