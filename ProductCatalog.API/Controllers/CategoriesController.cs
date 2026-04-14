using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductCatalog.API.Models;

namespace ProductCatalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(new[]
            {
                new Category { Id = 1, Name = "Electronics" },
                new Category { Id = 2, Name = "Accessories" }
            });

        }
    }
}
