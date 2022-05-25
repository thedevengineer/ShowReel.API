using Microsoft.Extensions.DependencyInjection;
using ShowReel.Application.Services;
using ShowReel.Core.Interface.Services;

namespace ShowReel.Application
{
    public static class ApplicationModuleStartupSetup
    {
        public static void AddApplicationModule(this IServiceCollection services)
        {
            services.AddScoped<IClipService, ClipService>();
            services.AddScoped<IVideoQualityService, VideoQualityService>();
        }
    }
}
