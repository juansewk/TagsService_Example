using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagsService.Models.DataModels;

namespace TagsService.DataContext.Context
{
    public class TagsServiceContext : DbContext
    {
        public TagsServiceContext(DbContextOptions<TagsServiceContext> options)
            : base(options)
        {

        }

        public DbSet<TagModel> Tag { get; set; }


    }
}
