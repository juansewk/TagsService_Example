using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using TagsService.Business.BusinessObjects;
using TagsService.Business.Interfaces;
using TagsService.DataContext.Context;
using TagsService.Models;
using TagsService.Models.BusinessEntities;

namespace TagsService.Controllers
{
    [ApiController]
    [Route("api/v1/tags")]
    public class TagsServiceController : Controller
    {
        private readonly ITagBO _tagBO;
        private static TagsServiceContext Context;
        private readonly IMapper _mapper;

        public TagsServiceController(TagsServiceContext _context, ITagBO tagBO, IMapper mapper)
        {
            _tagBO = tagBO;
            _mapper = mapper;
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
            ITagBO tagBO = _tagBO;
            return Ok(tagBO.GetAll());
        }

        [HttpGet]
        [Route("GetById")]
        public IActionResult GetById(int Id)
        {
            ITagBO tagBO = _tagBO;
            return Ok(tagBO.GetById(Id));
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult Add([FromBody] TagBE tagBE)
        {
            ITagBO tagBO = _tagBO;
            return new ObjectResult(_tagBO.Add(tagBE));
        }

        [HttpPut]
        [Route("Update")]
        public IActionResult Update([FromBody] TagBE tagBE)
        {
            ITagBO tagBO = _tagBO;
            return new ObjectResult(_tagBO.Update(tagBE));
        }

        [HttpPut]
        [Route("EnableOrDisable")]
        public IActionResult EnableOrDisable([FromBody] TagBE tagBE)
        {
            ITagBO tagBO = _tagBO;
            return new ObjectResult(_tagBO.EnableOrDisable(tagBE));
        }
    }
}
