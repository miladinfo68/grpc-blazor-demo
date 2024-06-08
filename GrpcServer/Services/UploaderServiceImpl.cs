using Grpc.Core;
using Shared.Protos;

namespace GrpcServer.Services;

public class UploaderServiceImpl : UploaderService.UploaderServiceBase
{
    public async Task UploadFile(
        IAsyncStreamReader<FileChunk> requestStream, 
        IServerStreamWriter<UploadProgress> responseStream, 
        ServerCallContext context)
    {
        using (var fileStream = new MemoryStream())
        {
            FileChunk chunk;
            long totalBytes = 0;
            int totalChunks = 0;
            int completedChunks = 0;

            while (await requestStream.MoveNext(context.CancellationToken))
            {
                chunk = requestStream.Current;
                await fileStream.WriteAsync(chunk.Data.ToByteArray(), (int)chunk.Offset, chunk.Data.Length, context.CancellationToken);
                totalBytes += chunk.Data.Length;
                totalChunks = (int)Math.Ceiling((double)fileStream.Length / chunk.Data.Length);
                completedChunks++;

                await responseStream.WriteAsync(new UploadProgress
                {
                    BytesUploaded = totalBytes,
                    TotalBytes = fileStream.Length,
                    TotalChunks = totalChunks,
                    CompletedChunks = completedChunks
                });

                if (chunk.IsFinal)
                {
                    // Save the file to permanent storage
                    // ...
                    return;
                }
            }
        }

        throw new RpcException(new Status(StatusCode.Unknown, "Failed to upload file"));
    }
}
