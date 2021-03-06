using Blazored.LocalStorage;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Oficondo.Management.Web.App.Auth;
using Oficondo.Management.Web.App.Contracts;
using Oficondo.Management.Web.App.Services;
using Oficondo.Management.Web.App.Services.Base;
using System;
using System.Net.Http;

namespace Oficondo.Management.Web.App
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
            services.AddRazorPages();
            services.AddAutoMapper(typeof(Startup));
            services.AddBlazoredLocalStorage();
            services.AddAuthenticationCore();
            services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();

            services.AddSingleton(new HttpClient
            {
                BaseAddress = new Uri("https://localhost:5001")
            });

            services.AddHttpClient<IClient, Client>(client => client.BaseAddress = new Uri("https://localhost:5001"));

            services.AddScoped<IPaymentMethodDataService, PaymentMethodDataService>();
            services.AddScoped<IBankDataService, BankDataService>();
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
