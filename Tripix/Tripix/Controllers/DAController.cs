using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;
using Tripix.Abstractions;
using Tripix.Contracts.Car;
using Tripix.Contracts.DA;
using Tripix.Services.Interfaces;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DAController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public DAController ( IUnitOfWork unitOfWork )
        {
            this.unitOfWork = unitOfWork;
        }
        [HttpGet("TrendingProducts")]
        public async Task<IActionResult> GetTrendingProducts ()
        {
            var res = await unitOfWork.DAService.GetTrendingProducts();

            return Ok(res);
        }
        [HttpPost("GetProductNames")]
        public async Task<IActionResult> GetProductName(ProductSearch model)
        {
            var res = await unitOfWork.DAService.GetProductsName(model.ProductCategory);

            return Ok(res);
        }
        [HttpPost("GetNewArrivalsForProduct")]
        public async Task<IActionResult> GetNewArrivalsForProduct(FilterProductDTO model)
        {
            var res = await unitOfWork.DAService.GetNewArrivalFromProduct(model.ProductName);

            return Ok(res);
        }
        [HttpPost("GetTrendingForProduct")]
        public async Task<IActionResult> GetTrendingForProduct(FilterProductDTO model)
        {
            var res = await unitOfWork.DAService.GetTrendingFromProduct(model.ProductName);

            return Ok(res);
        }
        [HttpGet("GetAllProductNames")]
        public IActionResult GetAllProductsName()
        {
            var res =  unitOfWork.DAService.GetAllProductsName();

            return Ok(res);
        }
        [HttpPost("GetTopRatedForProduct")]
        public async Task<IActionResult> GetTopRatedForProduct(FilterProductDTO model)
        {
            var res = await unitOfWork.DAService.GetTopRatedFromProduct(model.ProductName);

            return Ok(res);
        }

        [HttpGet("NewArrivalsProducts")]
        public async Task<IActionResult> GetNewArrivalsProducts ()
        {
            var res = await unitOfWork.DAService.GetNewArrivalsProduct();

            return Ok(res);
        }
        [HttpGet("TopRatedProducts")]
        public async Task<IActionResult> GetTopRatedProducts ()
        {
            var res = await unitOfWork.DAService.GetTopRatedProduct();

            return Ok(res);
        }
        [HttpGet("BestSellerProducts")]
        public async Task<IActionResult> BestSellerProducts ()
        {
            var res = await unitOfWork.DAService.GetBestSellerProducts();

            return Ok(res);
        }
        
        [HttpGet("GetWashletCount")]
        
        public async Task<IActionResult> GetUserWashlet(CancellationToken canToken)
        {
            var UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var res = await unitOfWork.DAService.GetWashletcount(UserId!,canToken);

            return res.IsSuccess ? Ok(res.Value) : res.ToProblem();

        }
        [HttpGet("getProductsCount")]
        
        public async Task<IActionResult> GetCountOfProducts()
        {
            var res = await unitOfWork.DAService.GetProductcounts();

            return Ok(res);
        }
        [HttpGet("GetProductCount")]
        public async Task<IActionResult> GetProductCount()
        {
            var res = await unitOfWork.DAService.GetProductcounts();

            return Ok(res);
        }
    }
}
