using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using TagsService.Models;

namespace TagsService.Controllers
{
    [ApiController]
    [Route("api/v1/tags")]
    public class TagsServiceController : Controller
    {
        [HttpGet]
        [Route("GetStatus")]
        public IActionResult GetStatusService()
        {
            return Ok("OK. :)");
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            return Ok("Get all tags OK.");
        }

        [HttpGet]
        [Route("GetById")]
        public IActionResult GetById()
        {
            return Ok("Get by id OK.");
        }

        [HttpPost] 
        [Route("Add")]
        public IActionResult Add()
        {
            return Ok("Add OK.");
        }

        [HttpPut]
        [Route("Update")]
        public IActionResult Update()
        {
            return Ok("Udate OK.");
        }

        [HttpPut]
        [Route("EnableOrDisable")]
        public IActionResult EnableOrDisable()
        {
            return Ok("Enable or disable OK.");
        }




    }
}
