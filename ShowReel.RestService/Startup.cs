using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using ShowReel.Core.Repositories;
using ShowReel.Data;
using ShowReel.Data.Repositories;

namespace ShowReel.RestService
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = new ConfigurationBuilder().Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ShowReelDbContext>(options => options.UseSqlite("Data Source=./ShowReelDb.db;"));
            services.AddScoped<IReelRepository, ReelRepository>();
            services.AddScoped<IVideoQualityRepository, VideoQualityRepository>();

            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseRouting();
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseEndpoints(endpoint =>
            {
                endpoint.MapControllers();
            });
        }
    }
}
