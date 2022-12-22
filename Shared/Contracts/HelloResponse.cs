using System.Runtime.Serialization;

namespace Shared.Contracts
{
    [DataContract]
    public class HelloResponse
    {
        [DataMember(Order = 1)]
        public string? Message { get; set; }

        public override string ToString()
        {
            return Message ?? "null";
        }
    }
}
