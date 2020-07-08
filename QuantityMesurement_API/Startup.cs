
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using QMBusinessLayer.Interface;
using QMBusinessLayer.Service;
using QMCommanLayer;
using QMCommanLayer.Models;
using QMRepositoryLayer.Interface;
using QMRepositoryLayer.Service;

namespace QuantityMesurement_API
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
            //Add db context pool for connection string and migration
            services.AddDbContextPool<QuantityMesurementContext>(options => options.UseSqlServer(Configuration["ConnectionString:QuantityMesurementDb"], b => b.MigrationsAssembly("QuantityMesurement_API")));

            services.AddTransient<IQuantityMesurementBL, QuantityMesurementBL>();
            // depedency Of Repository Layer
            services.AddTransient<IQuantityMesurementRL, QuantityMesurementRL>();

            // depedency Of Repository Layer
            
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
