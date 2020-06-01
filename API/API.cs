using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using BlogsApp.Infrastracture;
using EntityGraphQL.Schema;
using EntityGraphQL;

namespace BlogsApp.API
{
    public class API
    {
        private readonly BloggingContext context;
        private readonly SchemaProvider<BloggingContext> schemaProvider;

        public API(BloggingContext context, SchemaProvider<BloggingContext> schemaProvider)
        {
            this.context = context;
            this.schemaProvider = schemaProvider;
        }

        [FunctionName("get")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req)
        {
            var queryParam = req.Query["query"];

            if (string.IsNullOrEmpty(queryParam))
            {
                return new BadRequestObjectResult("query parameter is missing. please pass it accordind to GraphQL standards in order to be able to retrieve data");
            }

            try
            {
                var query = new QueryRequest
                {
                    Query = queryParam
                };

                var result = schemaProvider.ExecuteQuery(query, context, null, null);

                if (result.Errors.Any())
                {
                    return new BadRequestObjectResult(JsonConvert.SerializeObject(result.Errors));
                }

                return new OkObjectResult(JsonConvert.SerializeObject(result.Data));
            }
            catch (Exception)
            {
                return new BadRequestResult();
            }
        }
    }
}
