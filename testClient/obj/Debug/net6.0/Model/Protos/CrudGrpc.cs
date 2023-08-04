// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Model/Protos/crud.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
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
      get { return global::RepositoryService.CrudReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for WorkerService</summary>
    public partial class WorkerServiceClient : grpc::ClientBase<WorkerServiceClient>
    {
      /// <summary>Creates a new client for WorkerService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public WorkerServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for WorkerService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public WorkerServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected WorkerServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected WorkerServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RepositoryService.ListReply ListWorker(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListWorker(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RepositoryService.ListReply ListWorker(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListWorker, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RepositoryService.ListReply> ListWorkerAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListWorkerAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RepositoryService.ListReply> ListWorkerAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListWorker, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RepositoryService.WorkerGrpcObj GetWorker(global::RepositoryService.GetWorkerRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetWorker(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RepositoryService.WorkerGrpcObj GetWorker(global::RepositoryService.GetWorkerRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetWorker, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RepositoryService.WorkerGrpcObj> GetWorkerAsync(global::RepositoryService.GetWorkerRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetWorkerAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RepositoryService.WorkerGrpcObj> GetWorkerAsync(global::RepositoryService.GetWorkerRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetWorker, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RepositoryService.WorkerGrpcObj CreateWorker(global::RepositoryService.WorkerGrpcObj request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateWorker(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RepositoryService.WorkerGrpcObj CreateWorker(global::RepositoryService.WorkerGrpcObj request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateWorker, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RepositoryService.WorkerGrpcObj> CreateWorkerAsync(global::RepositoryService.WorkerGrpcObj request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateWorkerAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RepositoryService.WorkerGrpcObj> CreateWorkerAsync(global::RepositoryService.WorkerGrpcObj request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateWorker, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RepositoryService.WorkerGrpcObj UpdateWorker(global::RepositoryService.WorkerGrpcObj request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateWorker(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RepositoryService.WorkerGrpcObj UpdateWorker(global::RepositoryService.WorkerGrpcObj request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateWorker, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RepositoryService.WorkerGrpcObj> UpdateWorkerAsync(global::RepositoryService.WorkerGrpcObj request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateWorkerAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RepositoryService.WorkerGrpcObj> UpdateWorkerAsync(global::RepositoryService.WorkerGrpcObj request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateWorker, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RepositoryService.WorkerGrpcObj DeleteWorker(global::RepositoryService.DeleteWorkerRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteWorker(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::RepositoryService.WorkerGrpcObj DeleteWorker(global::RepositoryService.DeleteWorkerRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteWorker, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RepositoryService.WorkerGrpcObj> DeleteWorkerAsync(global::RepositoryService.DeleteWorkerRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteWorkerAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::RepositoryService.WorkerGrpcObj> DeleteWorkerAsync(global::RepositoryService.DeleteWorkerRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteWorker, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override WorkerServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new WorkerServiceClient(configuration);
      }
    }

  }
}
#endregion