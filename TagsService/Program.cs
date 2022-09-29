using Microsoft.EntityFrameworkCore;
using TagsService.Business.BusinessObjects;
using TagsService.Business.Interfaces;
using TagsService.DataContext.Context;

namespace TagsService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Depence inyection
            builder.Services.AddTransient<ITagBO, TagBO>();

            // Get string connection
            builder.Services.AddDbContext<TagsServiceContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("TagsServiceConnection"))
            );

            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                var dataContext = scope.ServiceProvider.GetRequiredService<TagsServiceContext>();
                dataContext.Database.Migrate();

                // $PM: Add-Migration [Name migration]
            }

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}