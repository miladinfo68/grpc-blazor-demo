using BlazoServerAsClient.Components;
using BlazoServerAsClient.Services;
using Grpc.Net.Client;
using Shared.Protos;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddGrpcClient<UploaderService.UploaderServiceClient>(options =>
{
    options.Address = new Uri(builder.Configuration["Grpc:ServerUrl"]!);
});

builder.Services.AddSingleton(services =>
  GrpcChannel.ForAddress(new Uri(builder.Configuration["Grpc:ServerUrl"]!)));


builder.Services.AddScoped(sp =>
{
    var channel = sp.GetRequiredService<GrpcChannel>();
    return new UploaderService.UploaderServiceClient(channel);
});


builder.Services.AddScoped<CientFileUploadService>();

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();


app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
