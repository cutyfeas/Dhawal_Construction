using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entity;
using WebApplication1.Service;

namespace WebApplication1
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
            services.AddDbContext<db_a67321_constructionappContext>(item => item.UseSqlServer(Configuration.GetConnectionString("BlogDBConnection")));

            services.AddScoped<ITblApartmentService, TblApartmentService>();
            services.AddScoped<ITblBeneficiaryChoiceMapService, TblBeneficiaryChoiceMapService>();
            services.AddScoped<ITblBeneficiarieservice, TblBeneficiarieservice>();

            services.AddScoped<ITblCondominiumService, TblCondominiumService>();
            services.AddScoped<ITblMasterfieldService, TblMasterfieldService>();
            services.AddScoped<ITblMastertypefieldService, TblMastertypefieldService>();

            services.AddScoped<ITblMastertypeService, TblMastertypeService>();
            services.AddScoped<ITblMastertypeSupplierMapService, TblMastertypeSupplierMapService>();
            services.AddScoped<ITblPageService, TblPageService>();

            services.AddScoped<ITblRolePageService, TblRolePageService>();
            services.AddScoped<ITblRoleService, TblRoleService>();
            services.AddScoped<ITblSupplierService, TblSupplierService>();
            services.AddScoped<ITblUserService, TblUserService>();
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
