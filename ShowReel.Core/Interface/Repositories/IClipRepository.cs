using ShowReel.Core.Domain;

namespace ShowReel.Core.Interface.Repositories
{
    public interface IClipRepository : IRepository<Clip>
    {
        IEnumerable<Clip> FindAllByIds(int[] ids);
        Clip FindWithVideoQualityById(int id);
        IEnumerable<Clip> GetAllWithVideoQuality();
        IEnumerable<Clip> FindAllWithVideoQuality(int[] ids);
    }
}
