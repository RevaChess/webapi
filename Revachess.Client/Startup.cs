using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PizzaBox.Storage;
using Revachess.Storage;

namespace Revachess.Client
{
  public class Startup
  {

    public IConfiguration Configuration { get; set; }

    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }
    // This method gets called by the runtime. Use this method to add services to the container.
    // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddControllers();
      services.AddCors(options =>
      {
        options.AddPolicy("public", config =>
        {
          config.AllowAnyHeader();
          config.AllowAnyMethod();
          config.AllowAnyOrigin();
        });
      });
      services.AddScoped<UnitOfWork>();
      services.AddDbContext<ChessContext>(options =>
      {
        if (!string.IsNullOrWhiteSpace(Configuration.GetConnectionString("mssql")))
        {
          options.UseSqlServer(Configuration.GetConnectionString("mssql"), opts =>
          {
            opts.EnableRetryOnFailure(3);
          });
        }
      });
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      app.UseRouting();
      app.UseCors();
      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });
    }
  }
}
