using ProtoBuf.Grpc.Reflection;

using Shared.Services;

string schema = new SchemaGenerator
{
    ProtoSyntax = ProtoBuf.Meta.ProtoSyntax.Proto3,
}
.GetSchema<IHelloService>();

Console.WriteLine(schema);
