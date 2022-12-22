using System.Runtime.Serialization;

namespace Shared.Contracts
{
    [DataContract]
    public class HelloRequest
    {
        [DataMember(Order = 1)]
        public string? Name { get; set; }

        public HelloRequest() { }

        public HelloRequest(string? name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name ?? "null";
        }
    }
}
