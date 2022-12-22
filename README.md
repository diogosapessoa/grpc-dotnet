# GrpcDotNet

Code-First sample solution using [GRPC](https://grpc.io/) with dotnet

## Shared

Common code to server and client projects

## Server

GRPC server service

## Client

GRPC client calls server

## Generator

Generate protobuf schema from code

```powershell
> dotnet run --project .\Generator\Generator.csproj
```

```
syntax = "proto3";
package Shared.Services;

message HelloRequest {
   string Name = 1;
}
message HelloResponse {
   string Message = 1;
}
service HelloService {
   rpc SayHello (HelloRequest) returns (HelloResponse);
}
```
