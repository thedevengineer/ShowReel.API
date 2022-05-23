using ShowReel.Core.Domain;
using ShowReel.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowReel.Data.Repositories
{
    public class VideoQualityRepository : BaseRepository<VideoQuality>, IVideoQualityRepository
    {
        public VideoQualityRepository(ShowReelDbContext context): base(context)
        {
        }
    }
}
