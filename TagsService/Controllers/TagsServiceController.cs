using Microsoft.AspNetCore.Mvc;

namespace TagsService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TagsServiceController : Controller
    {
        

        [HttpGet]
        public IActionResult GetStatusService()
        {
            return Ok("ALGO ESTÁ BIEN");
        }

    




    }
}
