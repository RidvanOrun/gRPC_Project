using Grpc.Core;
using gRPC_Client.Protos;
using Microsoft.AspNetCore.Hosting.Server;

namespace gRPC_Server.Service
{
    public class ProductService : productGRPC.productGRPCBase
    {
        public ProductService()
        {           
        }

        public override async Task<ProductResponse> ByIds(ByIdsRequest request, ServerCallContext context)
        {
            var result =new ProductResponse() { Id = "1", Value="Value"};


            return result;
        }
    }
}
