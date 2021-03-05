using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnionArcExample.Application.Interfaces.Repositories;
using OnionArcExample.Application.Interfaces.Services;

namespace OnionArcExample.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController: ControllerBase
    {
        private readonly IProductRepository _productRepository;
        private readonly IEmailService _emailService;

        public ProductController(IProductRepository productRepository, IEmailService emailService)
        {
            _productRepository = productRepository;
            _emailService = emailService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var allProducts = await _productRepository.GetAsync();
            return Ok(allProducts);
        }
        [HttpGet("sendemail")]
        public IActionResult SendEmail()
        {
            var result = _emailService.Send("metalsimyaci@gmail.com", "...");
            return Ok(result);
        }

    }
}
