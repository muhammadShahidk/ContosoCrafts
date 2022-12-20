using System.Collections.Generic;
using System.Text.Json;
using ContosoCrafts.WebSite.Controllers;
using ContosoCrafts.WebSite.Models;
using ContosoCrafts.WebSite.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ContosoCrafts.WebSite
{
    public class Startup
    {
        public Startup(IConfiguration configuration) =>
            Configuration = configuration;

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddMvc();
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddHttpClient();
            services.AddControllers();
            services.AddTransient<JsonFileProductService>();
            services.AddTransient<EmployeeGetService>();
            //mvcOptions.EnableEndpointRouting = true;
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

            //app.UseHttpsRedirection();
            app.UseStaticFiles();
            //app.UseMvcWithDefaultRoute();
            app.UseRouting();

            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {

                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
              
                endpoints.MapGet("/Employees", (context) =>
                {
                    var Employess = app.ApplicationServices.GetService<EmployeeGetService>().GetEmployees();
                    //var emp = Employess.ToArray();
                    var json = JsonSerializer.Serialize<List<Employee>>(Employess);

                    return context.Response.WriteAsync(json);
                });

                endpoints.MapGet("/Employee/details", (context) =>
                {
                    return context.Response.WriteAsJsonAsync("hello" + env.EnvironmentName);
                });
                //endpoints.MapGet("/Employee/EmpController", (context) =>
                //{
                //    EmployeeControler employeeControler = new EmployeeControler();
                //    ViewResult viewResult = new ViewResult();
                //    viewResult= employeeControler.Hello();
                    
                //    //return context.Response.WriteAsJsonAsync(employeeControler.Hello());
                //});
            });
        }
    }
}
