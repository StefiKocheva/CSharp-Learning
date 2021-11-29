using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyFirstMvcApp.Data;
using MyFirstMvcApp.Filters;
using MyFirstMvcApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstMvcApp
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
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddControllersWithViews();

            services.AddResponseCaching(); // needed attribute
            services.AddMemoryCache();

            services.AddResponseCompression(options =>
            {
                options.EnableForHttps = true;
            }); // to compress static files

            //services.AddDistributedSqlServerCache(options =>
            //{
            //    options.ConnectionString = Configuration.GetConnectionString("DefaultConnection");
            //    options.SchemaName = "dbo";
            //    options.TableName = "CacheEntries";
            //});
            //need command from the presentation

            services.AddSession(options =>
            {
                options.Cookie.HttpOnly = true;
            });

            services.AddMvc(options =>
            {
                options.Filters.Add(new AddHeaderAttribute("X-Debug", "Global!!!")); 
                options.Filters.Add(new MyResourceFilter());
                options.Filters.Add(new ValidateModelStateFilterAttribute()); 
                options.Filters.Add(new MyResultFilter()); 
                options.Filters.Add(new MyExceptionFilter()); 
                options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute()); 
            }).SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_2_2)
                .AddCookieTempDataProvider();

            services.AddTransient<IUsersService, UsersService>(); // each time makes new instation
            //services.AddTransient<ICounterService, CounterService>();
            //services.AddScoped<ICounterService, CounterService>(); // new instation per requset
            services.AddSingleton<ICounterService, CounterService>(); // only one instation throught the whole application
            services.AddTransient<MyAuthorizedFilterAttribute>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(new DeveloperExceptionPageOptions() { SourceCodeLineCount = 100 });
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            //app.UseStatusCodePagesWithRedirects("/Home/Errors?code={0}")
            //app.UseStatusCodePagesWithReExecute();
            app.UseHttpsRedirection();

            app.UseResponseCompression(); // compression middleware
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseSession();
            app.UseResponseCaching(); // needed middleware

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{Controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
