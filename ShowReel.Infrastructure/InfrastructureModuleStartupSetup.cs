using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShowReel.Core.Interface.Repositories;
using ShowReel.Infrastructure.Repositories;

namespace ShowReel.Infrastructure
{
    public static class InfrastructureModuleStartupSetup
    {
        public static void AddDbContext(this IServiceCollection services, string connectionString) =>
            services.AddDbContext<ShowReelDbContext>(options =>
                options.UseSqlServer(connectionString)); // will be created in web project root


        public static void AddInfrastructureModule(this IServiceCollection services)
        {
            services.AddScoped<IClipRepository, ClipRepository>();
            services.AddScoped<IVideoQualityService, VideoQualityRepository>();
        }
             
    }

}
