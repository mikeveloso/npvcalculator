using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using NpvCalculator.Repositories;
using NpvCalculator.Services;

namespace NpvCalculator.Configurations
{
    public class ApplicationServiceConfiguration
    {
        public static IServiceCollection Configure(IServiceCollection services, IConfiguration configuration, bool userCookies = true)
        {
            if (userCookies)
            {
                services.Configure<CookiePolicyOptions>(options =>
                {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                    options.MinimumSameSitePolicy = SameSiteMode.None;
                });
            }

            services.AddHttpClient<INpvCalculatorService, NpvCalculatorService>(); 
            services.AddScoped<INpvCalculator, NpvCalculator>();
            services.AddScoped<INpvRepository, NpvRepository>();
            

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            return services;
        }

        public static void ConfigureApi(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
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
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Npv}/{action=Index}/{id?}");
            });
        }
    }
}
