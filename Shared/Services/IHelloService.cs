using ProtoBuf.Grpc;

using Shared.Contracts;

using System.ServiceModel;

namespace Shared.Services
{
    [ServiceContract]
    public interface IHelloService
    {
        [OperationContract]
        Task<HelloResponse> SayHelloAsync(HelloRequest request, CallContext context = default);
    }
}
