using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.Web.CodeGeneration.Design;
using Swashbuckle.AspNetCore.Swagger;
using Microsoft.Extensions.PlatformAbstractions;
using System;
using System.IO;

namespace TestTask.WebAPI.Swagger
{
    public static class SwaggerConfig
    {
        public static void ConfigureSwagger(this IApplicationBuilder app)
        {
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS etc.), specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "Version 1");
            });
        }

        public static void AddSwaggerServices(this IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1",
                    new Info
                    {
                        Version = "v1",
                        Title = typeof(Program).Assembly.GetName().Name,
                        Description = "Inspirito Test Task",
                        Contact = new Contact
                        {
                            Name = "Inspirito",
                            Email = "",
                            Url = "https://inspiri.to/"
                        }
                    });

                var filePath = Path.Combine(PlatformServices.Default.Application.ApplicationBasePath, PlatformServices.Default.Application.ApplicationName + ".xml");
                if (File.Exists(filePath))
                {
                    options.IncludeXmlComments(filePath);
                }

                options.DescribeAllEnumsAsStrings();

                //Set the comments path for the swagger json and ui.
                var basePath = AppContext.BaseDirectory;
                var xmlPath = Path.Combine(basePath, "TestTask.WebAPI.xml");

                if (File.Exists(xmlPath))
                {
                    options.IncludeXmlComments(xmlPath);
                }
            });
        }
    }
}
