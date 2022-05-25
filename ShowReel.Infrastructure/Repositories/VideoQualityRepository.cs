using ShowReel.Core.Domain;
using ShowReel.Core.Interface.Repositories;

namespace ShowReel.Infrastructure.Repositories
{
    public class VideoQualityRepository : BaseRepository<VideoQuality>, IVideoQualityService
    {
        public VideoQualityRepository(ShowReelDbContext context): base(context)
        {
        }
    }
}
