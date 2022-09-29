﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagsService.DataAccess.Interfaces;
using TagsService.DataContext.Context;
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
            var a = Context.Tag.ToList();

            return (IQueryable<TagModel>)a;
        }

        public TagModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public TagModel Add(TagModel tagModel)
        {
            throw new NotImplementedException();
        }

        public TagModel Update(TagModel tagModel)
        {
            throw new NotImplementedException();
        }

        public TagModel EnableOrDisable(TagModel tagModel)
        {
            throw new NotImplementedException();
        }
    }
}
