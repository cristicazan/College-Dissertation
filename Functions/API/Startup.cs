using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;
using BlogsApp.Infrastracture;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using EntityGraphQL.Schema;

[assembly: WebJobsStartup(typeof(BlogsApp.API.Startup))]
namespace BlogsApp.API
{
    public class Startup : IWebJobsStartup
    {
        public void Configure(IWebJobsBuilder builder)
        {
            builder.Services.AddDbContext<BloggingContext>(opt => opt.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Blogging;Integrated Security=True"));
            builder.Services.AddSingleton(SchemaBuilder.FromObject<BloggingContext>());
        }
    }
}