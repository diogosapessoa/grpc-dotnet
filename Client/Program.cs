using Grpc.Net.Client;

using ProtoBuf.Grpc.Client;

using Shared.Contracts;
using Shared.Services;

using GrpcChannel channel = GrpcChannel.ForAddress("https://localhost:7225");
IHelloService helloService = channel.CreateGrpcService<IHelloService>();

string message = args.Length > 0 ? string.Join(" ", args) : "Empty";

var request = new HelloRequest(message);
HelloResponse response = await helloService.SayHelloAsync(request);

Console.WriteLine(response);
