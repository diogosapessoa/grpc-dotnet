using ProtoBuf.Grpc;

using Shared.Contracts;
using Shared.Services;

namespace Server.Services
{
    public class HelloService : IHelloService
    {
        private readonly ILogger<HelloService> _logger;

        public HelloService(ILogger<HelloService> logger)
        {
            _logger = logger;
        }

        public Task<HelloResponse> SayHelloAsync(HelloRequest request, CallContext context = default)
        {
            _logger.LogInformation("{Name}", request.Name);

            var response = new HelloResponse
            {
                Message = $"Hello {request.Name}",
            };

            return Task.FromResult(response);
        }
    }
}
