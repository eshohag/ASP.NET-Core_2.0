using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HelloWorld
{
    public class Startup
    {
        public IConfiguration Configuration {set;get; }
        public Startup(IConfiguration config)
        {
            Configuration=config;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())   //ei section ta comment korle details buja jabe je ki karone error hocce
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMvc();
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("<b>Hello World Web!</b>");
            });
        }
    }
}
