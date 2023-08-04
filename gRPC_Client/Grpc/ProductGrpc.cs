using Grpc.Net.Client;
using gRPC_Client.Protos;

namespace gRPC_Client.Grpc
{
    public class ProductGrpc : IProductGrpc
    {
        public ProductResponse GetProducts()
        {
            using GrpcChannel channel = GrpcChannel.ForAddress("https://localhost:7111");

            productGRPC.productGRPCClient productGRPCClient = new(channel);
            ByIdsRequest keys = new ByIdsRequest();
            keys.Id = "1";

            return productGRPCClient.ByIds(keys);
        }
    }
}
