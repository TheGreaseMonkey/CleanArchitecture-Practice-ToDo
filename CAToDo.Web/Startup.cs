using CAToDo.Application;
using CAToDo.Infra.EF.DI;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CAToDo.Web
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
            services.AddControllersWithViews();

            /*
             * This is really important. These 2 services come from the
             * CAToDo.Application and CAToDo.Infra.IM projects
             * 
             * .AddApp() includes MediatR package from Jimmy Bogard, this package
             * is responsible for CQRS and is needed to send the communication commands.
             * This inserts the MediatR package using dependency injection
             */
            services.AddApp();

            /*
             * This adds the infrastructure to the project using dependency injection.
             * While it is true that CADToDo.Web itself does not use it, as it should.
             * The CADToDo.Application project does, since we injected it in the .AddApp()
             * line, the infra is also injected there
             */
            services.AddInfra();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
