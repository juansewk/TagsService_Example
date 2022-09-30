using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagsService.Business.Interfaces;
using TagsService.DataAccess.DataAccess;
using TagsService.DataAccess.Interfaces;
using TagsService.DataContext.Context;
using TagsService.Models.BusinessEntities;
using TagsService.Models.DataModels;

namespace TagsService.Business.BusinessObjects
{
    public class TagBO : ITagBO
    {
        private static TagsServiceContext Context;
        private readonly IMapper _mapper;

        public TagBO(TagsServiceContext _context, IMapper mapper)
        {
            Context = _context;
            _mapper = mapper;
        }

        public List<TagBE> GetAll()
        {
            TagDA tagDA = new TagDA(Context);
            var dataResult = tagDA.GetAll().ToList();

            return _mapper.Map<List<TagBE>>(dataResult);
        }

        public TagBE GetById(int Id)
        {
            TagDA tagDA = new TagDA(Context);
            var dataResult = tagDA.GetById(Id);

            return _mapper.Map<TagBE>(dataResult);
        }

        public TagBE Add(TagBE tag)
        {
            TagDA tagDA = new TagDA(Context);
            var obj = _mapper.Map<TagModel>(tag);
            
            return _mapper.Map<TagBE>(tagDA.Add(obj));
        }

        public TagBE Update(TagBE tag)
        {
            TagDA tagDA = new TagDA(Context);
            var obj = _mapper.Map<TagModel>(tag);

            return _mapper.Map<TagBE>(tagDA.Update(obj));
        }

        public TagBE EnableOrDisable(TagBE tag)
        {
            throw new NotImplementedException();
        }
    }
}
