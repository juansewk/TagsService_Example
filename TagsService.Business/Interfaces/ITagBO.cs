using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagsService.Models.BusinessEntities;
using TagsService.Models.DataModels;

namespace TagsService.Business.Interfaces
{
    public interface ITagBO
    {
        List<TagBE> GetAll();
        TagBE GetById(int id);
        TagBE Add(TagBE tagBE);
        TagBE Update(TagBE tagBE);
        TagBE EnableOrDisable(TagBE tagBE);

    }
}
