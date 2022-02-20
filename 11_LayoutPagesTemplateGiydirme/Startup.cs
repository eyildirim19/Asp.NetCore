using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11_LayoutPagesTemplateGiydirme
{
    using Microsoft.EntityFrameworkCore;
    using Models;
    using Models.Entities;
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // Dependenct injections IOC container configurasyonu
        // This method gets called by the runtime. Use this method to add services to the container.

        // IOC (Inversion of Container) => DIP ve DI ile kullanýlan patterndir. Bu patern ile instance yönetimi saðlanýr..
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            // Burada ProjectDbContext sýnýfýna connectionstring appsettings.json dosyasýndan alýnarak gönderilir... 
            services.AddDbContext<ProjectDbContext>(c => c.UseSqlServer(Configuration.GetConnectionString("ProjectConStr")));




        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        // Middleware configurasyonu...
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
