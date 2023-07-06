using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using Repository.Entities;
using Repository.Interfaces;
using Repository.Repositories;
using Services;
using Services.Interfaces;
using Services.ServiceClasses;

namespace UI
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
            builder.Services.AddScoped<IParentService, ParentService>();
            //builder.Services.AddScoped<IDescendantImageService, DescendantImageService>();
            //builder.Services.AddScoped<IImageService, ImageService>();
            //builder.Services.AddScoped<ISpecialDateService, SpecialDateService>();
            //builder.Services.AddScoped<ISpecialEventService, SpecialEventService>();
            builder.Services.AddScoped<IChildService, ChildService>();



            // builder.Services.AddDbContext<IDataSource, SqlDataSource>(options => options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MyProjectDB;Trusted_Connection=True;"));

            builder.Services.AddRepoDependencies();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

            builder.Services.AddTransient<IParentRepository, ParentRepository>();
            builder.Services.AddTransient<IChildRepository, ChildRepository>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            app.MapControllers();

            app.Run();
        }
    }
}