using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using TagsService.Models;

namespace TagsService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TagsServiceController : Controller
    {
        

        [HttpGet]
        public IActionResult GetStatusService()
        {
            TagModel tagModel = new TagModel();

            return Ok("ALGO ESTÁ BIEN");

        }

    




    }
}
