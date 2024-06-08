// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/uploader.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Shared.Protos {
  public static partial class UploaderService
  {
    static readonly string __ServiceName = "UploaderPackage.UploaderService";

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
    static readonly grpc::Marshaller<global::Shared.Protos.FileChunk> __Marshaller_UploaderPackage_FileChunk = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Shared.Protos.FileChunk.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Shared.Protos.UploadProgress> __Marshaller_UploaderPackage_UploadProgress = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Shared.Protos.UploadProgress.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Shared.Protos.FileChunk, global::Shared.Protos.UploadProgress> __Method_UploadFile = new grpc::Method<global::Shared.Protos.FileChunk, global::Shared.Protos.UploadProgress>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "UploadFile",
        __Marshaller_UploaderPackage_FileChunk,
        __Marshaller_UploaderPackage_UploadProgress);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Shared.Protos.UploaderReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of UploaderService</summary>
    [grpc::BindServiceMethod(typeof(UploaderService), "BindService")]
    public abstract partial class UploaderServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task UploadFile(grpc::IAsyncStreamReader<global::Shared.Protos.FileChunk> requestStream, grpc::IServerStreamWriter<global::Shared.Protos.UploadProgress> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for UploaderService</summary>
    public partial class UploaderServiceClient : grpc::ClientBase<UploaderServiceClient>
    {
      /// <summary>Creates a new client for UploaderService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public UploaderServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for UploaderService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public UploaderServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected UploaderServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected UploaderServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::Shared.Protos.FileChunk, global::Shared.Protos.UploadProgress> UploadFile(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UploadFile(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::Shared.Protos.FileChunk, global::Shared.Protos.UploadProgress> UploadFile(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_UploadFile, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override UploaderServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new UploaderServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(UploaderServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_UploadFile, serviceImpl.UploadFile).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, UploaderServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_UploadFile, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::Shared.Protos.FileChunk, global::Shared.Protos.UploadProgress>(serviceImpl.UploadFile));
    }

  }
}
#endregion
