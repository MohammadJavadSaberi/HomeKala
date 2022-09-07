using AccountManagement.Infrastructure.Configuration;
using CommentManagement.Infrastructure.Configuration;
using DiscountManagement.Infrastructure.Configuration;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OuroFramework.Application;
using ShopManagement.Infrastructure.Configuration;

namespace ServiceHost
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpContextAccessor();
            var connectionString = Configuration.GetConnectionString("HomeKala_DB");

            ShopBootstrapper.Config(services, connectionString);
            DiscountBootstrapper.Config(services, connectionString);
            CommentBootstrapper.Config(services, connectionString);
            AccountBootstrapper.Config(services, connectionString);

            services.AddTransient<IFileUploader, FileUploader>();
            services.AddTransient<IPasswordHasher, PasswordHasher>();
            services.AddTransient<IAuthHelper, AuthHelper>();

            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.Lax;
            });
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, o =>
                {
                    o.LoginPath = new PathString("/Account");
                    o.LogoutPath = new PathString("/Account");
                    o.AccessDeniedPath = new PathString("/AccessDenied");
                });
            services.AddAuthorization(o =>
            {
                o.AddPolicy("AdminArea", b => b.RequireRole("1", "3" , "4"));
                o.AddPolicy("AccountArea", b => b.RequireRole("1", "4"));
                o.AddPolicy("ShopArea", b => b.RequireRole("1", "3"));
            });
            services.AddRazorPages()
                .AddRazorPagesOptions(o =>
                {
                    o.Conventions.AuthorizeAreaFolder("Administration", "/", "AdminArea");
                    o.Conventions.AuthorizeAreaFolder("Administration", "/Accounts", "AccountArea");
                    o.Conventions.AuthorizeAreaFolder("Administration", "/Shop", "ShopArea");
                    o.Conventions.AuthorizeAreaFolder("Administration", "/Discounts", "ShopArea");             
                });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }
            app.UseAuthentication();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
