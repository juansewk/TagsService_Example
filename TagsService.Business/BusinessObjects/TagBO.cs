using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagsService.Business.Interfaces;
using TagsService.DataAccess.DataAccess;
using TagsService.DataContext.Context;
using TagsService.Models.BusinessEntities;

namespace TagsService.Business.BusinessObjects
{
    public class TagBO : ITagBO
    {
        private static TagsServiceContext Context;

        public TagBO(TagsServiceContext _context)
        {
            Context = _context;
        }

        public IQueryable<TagBE> GetAll()
        {
            TagDA tagDA = new TagDA(Context);
            return (IQueryable<TagBE>)tagDA.GetAll();
        }

        public TagBE GetById(int id)
        {
            throw new NotImplementedException();
        }

        public TagBE Add(TagBE tag)
        {
            throw new NotImplementedException();
        }

        public TagBE Update(TagBE tag)
        {
            throw new NotImplementedException();
        }

        public TagBE EnableOrDisable(TagBE tag)
        {
            throw new NotImplementedException();
        }
    }
}
