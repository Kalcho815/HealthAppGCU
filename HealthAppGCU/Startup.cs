using HealthAppGCU.Adaptors;
using HealthAppGCU.DbManagers;
using HealthAppGCU.Models;
using HealthAppGCUData;
using HealthAppGCUData.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAppGCU
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

            services.AddDbContext<HealthAppContext>(options =>
            {
                options.UseMySQL(@"datasource=localhost;username=root;password=;Database=HEALTH_APP;");
            });

            services.AddIdentity<User, HealthUserRole>()
                .AddEntityFrameworkStores<HealthAppContext>()
                .AddDefaultTokenProviders();

            services.AddTransient<HealtchcareActivityDbManager>();
            services.AddTransient<CalorieDbManager>();
            services.AddTransient<WaterIntakeDbManager>();
            services.AddTransient<HealthcareActivityAdaptor>();
            services.AddTransient<WeightDbManager>();
            services.AddTransient<SleepDbManager>();

            services.AddRazorPages();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();



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
           

            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapRazorPages();
            });
        }
    }
}
