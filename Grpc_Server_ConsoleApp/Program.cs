using Bogus;
using Grpc.Core;
using Grpc_Server_ConsoleApp.Data;
using Grpc_Server_ConsoleApp.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Shared.Protos;


var serviceProvider = ConfigureServices();
var peopleContext = serviceProvider.GetRequiredService<ServerAppDbContext>();
peopleContext.Database.EnsureCreated();



//----------------------------------------
const string serverHostName = "localhost";
const int serverListenPort = 2000;

var server = new Server()
{
    Ports = { new ServerPort(serverHostName, serverListenPort, ServerCredentials.Insecure) },
    Services =
    {
        WelcomeService.BindService(new WelcomeServiceImpl()),
        MathService.BindService(new MathServiceImpl()),
        UploaderService.BindService(new UploaderServiceImpl()),
        PeopleService.BindService(new PeopleServiceImpl(peopleContext)),
    }
};

try
{
    server.Start();
    Console.WriteLine($"[xxx Server] is running on port {serverListenPort}");
    
    //peopleContext.PrintPeople();
    //var persons = new PersonFaker().Generate(100);
    
    Console.ReadLine();
}
catch (Exception exp)
{
    Console.WriteLine($"An error has been occured : {exp.Message}");
}
finally
{
    await server.ShutdownAsync();
}



static IServiceProvider ConfigureServices()
{
    var services = new ServiceCollection();

    services.AddDbContext<ServerAppDbContext>(opt=>opt.UseInMemoryDatabase("PeopleDb"));

    return services.BuildServiceProvider();
}

