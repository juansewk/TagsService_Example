using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using TagsService.Business.BusinessObjects;
using TagsService.Business.Interfaces;
using TagsService.DataContext.Context;
using TagsService.Models;

namespace TagsService.Controllers
{
    [ApiController]
    [Route("api/v1/tags")]
    public class TagsServiceController : Controller
    {
        private readonly ITagBO _tagBO;
        private static TagsServiceContext Context;

        public TagsServiceController(TagsServiceContext _context, ITagBO tagBO)
        {
            _tagBO = tagBO;
            Context = _context;
        }

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
            TagBO tagBO = (TagBO)_tagBO.GetAll();
            return new ObjectResult(tagBO);
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
