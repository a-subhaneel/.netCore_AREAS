using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WebPACS
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
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddMvc().AddSessionStateTempDataProvider();
            services.AddMvc(option => option.EnableEndpointRouting = false);

            services.AddMvc();
            services.AddDistributedMemoryCache(); // Adds a default in-memory implementation of IDistributedCache
            services.AddSession();
            services.AddHttpContextAccessor();

            //addedIIS
            services.Configure<IISServerOptions>(options =>
            {
                options.AutomaticAuthentication = false;
            });
            services.Configure<IISOptions>(options =>
            {
                options.ForwardClientCertificate = false;
            });
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
            app.UseSession();

            app.UseAuthorization();
            app.UseCookiePolicy();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                name: "MyAreaAdministrator",
                areaName: "Administrator",
                pattern: "{controller=Login}/{action=Signin}/{id?}");

                endpoints.MapAreaControllerRoute(
               name: "MyAreaAdministrator",
               areaName: "Administrator",
               pattern: "Administrator/{controller=Administrator}/{action=RegisterAdmin}/{id?}");

                endpoints.MapAreaControllerRoute(
                name: "MyAreaCustomer",
                areaName: "Customer",
                pattern: "Customer/{controller=Customer}/{action=Customer}/{id?}");

                endpoints.MapAreaControllerRoute(
                name: "MyAreaDCCB",
                areaName: "DCCB",
                pattern: "DCCB/{controller=DCCB}/{action=DCCB}/{id?}");

                endpoints.MapAreaControllerRoute(
                name: "MyAreaDeposit",
                areaName: "Deposit",
                pattern: "Deposit/{controller=Deposit}/{action=Deposit}/{id?}");

                endpoints.MapAreaControllerRoute(
                name: "MyAreaFinYear_ROI",
                areaName: "FinYear_ROI",
                pattern: "FinYear_ROI/{controller=FinYear_ROI}/{action=FinYear_ROI}/{id?}");

             //   endpoints.MapAreaControllerRoute(
             //name: "MyAreaInsurance",
             //areaName: "Insurance",
             //pattern: "{area:exists}/{controller=Customer}/{action=Customer}/{id?}");

                endpoints.MapAreaControllerRoute(
                name: "MyAreaSCB",
                areaName: "SCB",
                pattern: "SCB/{controller=SCB}/{action=SCB}/{id?}");

                endpoints.MapControllerRoute(
                name: "Administrator",
                pattern: "{controller=Login}/{action=Signin}/{id?}");
            });
        }
    }
}
