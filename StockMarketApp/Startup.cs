using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using StockMarketApp.AdminService.Models;
using StockMarketApp.AdminService.Repository;
using StockMarketLibrary;

namespace StockMarketApp
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

            services.AddDbContext<AdminContextDB>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("SqlConnectionString")));
            services.AddScoped<IUploadRepository, UploadRepository>();
            services.AddScoped<IRepository<StockExchange>, StockExchangeRepository>();
            services.AddScoped<IRepository<Company>,CompanyRepository>();
            services.AddScoped<IRepository<IPODetails>, IPODetailsRepository>();
            services.AddScoped<IRepository<Sector>, SectorRepository>();
            services.AddScoped<IRepository<StockExchangeCompanies>, StockExchangeCompaniesRepository>();
            services.AddControllers();

           




        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            app.UseAuthentication();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
