using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Repository.Entities;
using Repository.Interfaces;
using Repository.Repositories;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Models;
using Microsoft.AspNetCore.Http;

namespace Services
{
    public static class Extensions
    {
        public static void AddRepoDependencies(this IServiceCollection services)
        {
            services.AddScoped<IParentRepository, ParentRepository>();
            services.AddScoped<IChildRepository, ChildRepository>();
            MapperConfiguration config = new MapperConfiguration(
               conf => { conf.CreateMap<Parent, ParentModel>().ReverseMap();
                         conf.CreateMap<Child, ChildModel>().ReverseMap();
             }) ;

            IMapper mapper = config.CreateMapper();


            services.AddSingleton(mapper);

            services.AddDbContext<IDataSource, SqlDataSource>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }
    }
}
