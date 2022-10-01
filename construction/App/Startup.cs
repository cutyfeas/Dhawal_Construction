using App.Entity;
using App.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
//using App.Entity;
//using App.Service;

namespace App
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
            services.AddMvc().AddSessionStateTempDataProvider();
            services.AddSession();
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            //services.AddMvc(option => option.EnableEndpointRouting = false);

            services.AddDbContext<ConAppContext>(item => item.UseSqlServer(Configuration.GetConnectionString("BlogDBConnection")));

            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<Itbl_userService, tbl_userService>();
            services.AddScoped<Itbl_roleService, tbl_roleService>();
            //services.AddScoped<ITblBeneficiarieservice, TblBeneficiarieservice>();

            //services.AddScoped<Itbl_condominiumService, tbl_condominiumService>();
            //services.AddScoped<ITblMasterfieldService, TblMasterfieldService>();
            //services.AddScoped<ITblMastertypefieldService, TblMastertypefieldService>();

            //services.AddScoped<ITblMastertypeService, TblMastertypeService>();
            //services.AddScoped<ITblMastertypeSupplierMapService, TblMastertypeSupplierMapService>();
            //services.AddScoped<ITblPageService, TblPageService>();

            //services.AddScoped<ITblRolePageService, TblRolePageService>();
            //services.AddScoped<ITblRoleService, TblRoleService>();
            //services.AddScoped<ITblSupplierService, TblSupplierService>();

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
            }
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();
            //app.UseMvcWithDefaultRoute();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute("register", "home/register",
            //        new { controller = "home", action = "register" });
            //});
        }
    }
}
