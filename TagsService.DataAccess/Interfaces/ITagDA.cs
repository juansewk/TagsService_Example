using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagsService.Models.DataModels;

namespace TagsService.DataAccess.Interfaces
{
    public interface ITagDA
    {   
        IQueryable<TagModel> GetAll();
        TagModel GetById(int id);
        TagModel Add(TagModel tagModel);
        TagModel Update(TagModel tagModel);
        TagModel EnableOrDisable(TagModel tagModel);
    }
}
