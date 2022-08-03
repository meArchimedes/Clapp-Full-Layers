using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App_Services.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
namespace Web_API
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddAppServices();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                }
                );
            });
        }
        
    }
}
