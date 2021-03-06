using ShowReel.Application;
using ShowReel.Infrastructure;
using System.Text.Json.Serialization;

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
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.WithOrigins("http://localhost:3000", "https://green-smoke-0cc6ae700.1.azurestaticapps.net")
                    .AllowAnyHeader()
                    .AllowAnyMethod());
            });


            services.AddInfrastructureModule();
            services.AddApplicationModule();

            //Todo: move to secret
            services.AddDbContext(@"Server=tcp:app-collection.database.windows.net,1433;Initial Catalog=ShowReelDb;Persist Security Info=False;User ID=mrkrmrez;Password=p0wflbkEXRCopZJV56mY;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

            services.AddControllers().AddJsonOptions(options =>
                 options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

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
            app.UseCors("CorsPolicy");
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
