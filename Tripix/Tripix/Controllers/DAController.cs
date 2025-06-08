using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;
using Tripix.Abstractions;
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
        [HttpGet("Gettestimonial")]
        public async Task<IActionResult> Gettestimonial ()
        {
            var res = await unitOfWork.DAService.GetTestimonial();

            return Ok(res);
        }
        [HttpGet("GetWashletCount")]
        public async Task<IActionResult> GetUserWashlet(CancellationToken canToken)
        {
            var UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var res = await unitOfWork.DAService.GetWashlet(UserId!,canToken);

            return res.IsSuccess ? Ok(res) : res.ToProblem();

        }
    }
}
