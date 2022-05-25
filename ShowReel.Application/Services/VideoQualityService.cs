using ShowReel.Core.Domain;
using ShowReel.Core.Interface.Repositories;
using ShowReel.Core.Interface.Services;

namespace ShowReel.Application.Services
{
    public class VideoQualityService : Core.Interface.Services.IVideoQualityService
    {
        private readonly Core.Interface.Repositories.IVideoQualityService _videoQualityRepository;
        public VideoQualityService(Core.Interface.Repositories.IVideoQualityService videoQualityRepository)
        {
            this._videoQualityRepository = videoQualityRepository;
        }

        public VideoQuality Get(int id)
        {
            return this._videoQualityRepository.Get(id);
        }

        public IEnumerable<VideoQuality> GetAll()
        {
            return this._videoQualityRepository.GetAll();
        }


    }
}
