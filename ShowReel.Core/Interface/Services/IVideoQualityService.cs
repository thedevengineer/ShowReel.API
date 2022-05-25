using ShowReel.Core.Domain;

namespace ShowReel.Core.Interface.Services
{
    public interface IVideoQualityService
    {
        IEnumerable<VideoQuality> GetAll();
        VideoQuality Get(int id);
    }
}
