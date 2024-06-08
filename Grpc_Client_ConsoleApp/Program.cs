using Grpc.Core;
using Grpc_Client_ConsoleApp.Services;

const string serverHostName = "localhost";
const int serverListenPort = 2000;

var chanel = new Channel(serverHostName, serverListenPort, ChannelCredentials.Insecure);

try
{
    await chanel.ConnectAsync();
    Console.WriteLine($"[xxx Client] connected to server running on port {serverListenPort}");

    //await ClientWelcomeService.Welcome(chanel);
    //await ClientPeopleService.CreatePerson(chanel);
    //await ClientPeopleService.GetAllPeople(chanel);
    //await ClientMathService.Factorial_ServerStreaming(chanel,10);
    //await ClientMathService.Average_ClientStreaming(chanel);
    //await ClientMathService.Sum_ClientServerBothStreaming(chanel);
    await ClientWelcomeService.SendNotification(chanel);

    Console.ReadLine();
}
catch (Exception exp)
{
    Console.WriteLine($"An error has been occured : {exp.Message}");
}
finally
{
    await chanel.ShutdownAsync();
}


//QQQQQQQQQQQ
