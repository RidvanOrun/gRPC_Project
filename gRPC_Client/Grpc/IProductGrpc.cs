using gRPC_Client.Protos;

namespace gRPC_Client.Grpc
{
    public interface IProductGrpc
    {
        public ProductResponse GetProducts();
    }
}
