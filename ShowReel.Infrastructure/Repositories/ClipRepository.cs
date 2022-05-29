using Microsoft.EntityFrameworkCore;
using ShowReel.Core.Domain;
using ShowReel.Core.Interface.Repositories;

namespace ShowReel.Infrastructure.Repositories
{
    public class ClipRepository: BaseRepository<Clip>, IClipRepository
    {
        public ClipRepository(ShowReelDbContext context): base(context)
        {
        }

        public IEnumerable<Clip> FindAllByIds(int[] ids)
        {
           return GetAll().Where(c => ids.Contains(c.Id)); 
        }

        public IEnumerable<Clip> GetAllWithVideoQuality()
        {
            return Context.Set<Clip>().Include(c => c.VideoQuality);
        }

        public IEnumerable<Clip> FindAllWithVideoQuality(int[] ids)
        {
            return Context.Set<Clip>().Include(c => c.VideoQuality).Where(d => ids.Contains(d.Id));
        }

        public Clip FindWithVideoQualityById(int id)
        {
            return Context.Set<Clip>().Include(c => c.VideoQuality).First(d => d.Id == id);
        }
    }
}
