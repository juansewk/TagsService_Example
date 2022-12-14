using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagsService.DataAccess.Interfaces;
using TagsService.DataContext.Context;
using TagsService.Models.BusinessEntities;
using TagsService.Models.DataModels;

namespace TagsService.DataAccess.DataAccess
{
    public class TagDA : ITagDA
    {
        public static TagsServiceContext Context;

        public TagDA(TagsServiceContext _context)
        {
            Context = _context;
        }

        public IQueryable<TagModel> GetAll()
        {
            IQueryable<TagModel> result = Context.Set<TagModel>().AsNoTracking();

            return result;
        }

        public TagModel GetById(int Id)
        {
            return Context.Set<TagModel>().Find(Id);
        }

        public TagModel Add(TagModel tagModel)
        {
            Context.Set<TagModel>().Add(tagModel);
            Context.SaveChanges();

            return tagModel;
        }

        public TagModel Update(TagModel tagModel)
        {
            Context.Entry(tagModel).State = EntityState.Modified;
            Context.SaveChanges();
            return tagModel;
        }

        public TagModel EnableOrDisable(TagModel tagModel)
        {
            tagModel.IsActive = !tagModel.IsActive;

            Context.Entry(tagModel).State = EntityState.Modified;
            Context.SaveChanges();
            return tagModel;
        }

    }
}
