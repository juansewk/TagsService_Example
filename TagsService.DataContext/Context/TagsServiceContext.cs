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
        public DbSet<SubTagModel> SubTag { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TagModel>().HasData(
                new TagModel { Id = 1, Name = "Tag example 1", Description = "Desciption example 1...", HexColor = "#1B999B", IsActive = true},
                new TagModel { Id = 2, Name = "Tag example 2", Description = "Desciption example 2...", HexColor = "#ED217C", IsActive = true},
                new TagModel { Id = 3, Name = "Tag example 3", Description = "Desciption example 3...", HexColor = "#55DDFF", IsActive = true},
                new TagModel { Id = 4, Name = "Tag example 4", Description = "Desciption example 4...", HexColor = "#FFFD82", IsActive = true},
                new TagModel { Id = 5, Name = "Tag example 5", Description = "Desciption example 5...", HexColor = "#FF9B71", IsActive = true}
                );

            modelBuilder.Entity<SubTagModel>().HasData(
                new SubTagModel { Id = 1, Name = "SubTag example 1 - tag 1", IsActive = true, TagId = 1},
                new SubTagModel { Id = 2, Name = "SubTag example 2 - tag 1", IsActive = true, TagId = 1},
                new SubTagModel { Id = 3, Name = "SubTag example 3 - tag 1", IsActive = true, TagId = 1}
                );
        }

    }
}
