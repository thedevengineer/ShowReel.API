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
            services.AddScoped<IClipRepository, ClipRepository>();
            services.AddScoped<IVideoQualityRepository, VideoQualityRepository>();

            //Todo: move to secret
            services.AddDbContext<ShowReelDbContext>(options => options.UseSqlServer(@"Server=tcp:app-collection.database.windows.net,1433;Initial Catalog=ShowReelDb;Persist Security Info=False;User ID=mrkrmrez;Password={password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"));

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
