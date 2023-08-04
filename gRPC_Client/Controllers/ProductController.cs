using gRPC_Client.Grpc;
using gRPC_Client.Protos;
using Microsoft.AspNetCore.Mvc;

namespace gRPC_Client.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductGrpc _productGrpc;

        public ProductController(IProductGrpc productGrpc)
        {
            _productGrpc = productGrpc;
        }

        [HttpGet(Name = "TakeGrpcValues")]
        public ProductResponse TakeGrpcValues()
        {
            var result = _productGrpc.GetProducts();

            return result;
        }
    }
}