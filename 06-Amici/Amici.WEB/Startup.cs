using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amici.DA.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Amici.WEB {
    public class Startup {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services) {
            // registriamo i servizi del framework
            services.AddMvc();

            // registriamo i nostri servizi
            services.AddTransient<IAmicoRepository, MockAmicoRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }

            /*app.Run(async (context) => {
                await context.Response.WriteAsync("Hello World!");
            });*/
            app.UseStatusCodePages();
            app.UseStaticFiles();
            //app.UseMvcWithDefaultRoute();         // use for start at HomeController/index()
            app.UseMvc(
                routes => routes.MapRoute(
                    name: "default",
                    template: "{controller-Amico}/{action-Index}/{id?}"
                    )
                );
        }
    }
}
