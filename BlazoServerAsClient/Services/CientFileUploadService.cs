using Shared.Protos;

namespace BlazoServerAsClient.Services;

public class CientFileUploadService
{
    private readonly UploaderService.UploaderServiceClient _client;

    public CientFileUploadService(UploaderService.UploaderServiceClient client)
    {
        _client = client;
    }



    
}
