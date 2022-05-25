using ShowReel.Core.Domain;
using ShowReel.Core.Interface.Repositories;

namespace ShowReel.Infrastructure.Repositories
{
    public class ClipRepository: BaseRepository<Clip>, IClipRepository
    {
        public ClipRepository(ShowReelDbContext context): base(context)
        {
        }

    }
}
