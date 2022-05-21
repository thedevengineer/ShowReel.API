using ShowReel.Core.Domain;
using ShowReel.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowReel.Data.Repositories
{
    internal class VideoQualityRepository : BaseRepository<VideoQuality>, IRepository<VideoQuality>
    {
        public VideoQualityRepository(ShowReelDbContext context): base(context)
        {
        }
    }
}
