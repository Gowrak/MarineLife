using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarineLife.Services;
using MarineLife.Services.HttpClients;
using MarineLife.Web.Version;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace MarineLife.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddHealthChecks();
            services.AddHttpClient<IFishHttpClient, FishHttpClient>();
            
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc(VersionProvider.Current.SwaggerVersion,
                    new OpenApiInfo {Title = "Marine Life", Version = VersionProvider.Current.SwaggerVersion});
                c.EnableAnnotations();
            });
            
            services.AddCors(o => o.AddPolicy("marine.life.policy", builder =>
            {
                builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
            }));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            app.UseCors("marine.life.policy");

            app.UseRouting();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint($"/swagger/{VersionProvider.Current.SwaggerVersion}/swagger.json", $"Marine Life {VersionProvider.Current.SwaggerVersion}");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapHealthChecks("/health");
            });
        }
    }
}