using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using BlogsApp.Infrastracture;
using EntityGraphQL.Schema;

[assembly: FunctionsStartup(typeof(BlogsApp.API.Startup))]
namespace BlogsApp.API
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddDbContext<BloggingContext>(opt => opt.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Blogging;Integrated Security=True"));
            builder.Services.AddSingleton(SchemaBuilder.FromObject<BloggingContext>());
        }
    }
}