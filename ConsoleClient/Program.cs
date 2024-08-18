using ASPDotnetLearn.Shared;
using Grpc.Net.Client;
using MagicOnion.Client;
using Cysharp.Net.Http;

var channel = GrpcChannel.ForAddress("https://localhost:5001", new ()
{
        
});
var client = MagicOnionClient.Create<IMyFirstService>(channel);
var result = await client.SumAsync(123, 456);

using var handler    = new YetAnotherHttpHandler();
var       httpClient = new HttpClient(handler);
Console.WriteLine($"Result: {result}");