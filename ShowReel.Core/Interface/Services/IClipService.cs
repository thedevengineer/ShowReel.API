using ShowReel.Core.Domain;

namespace ShowReel.Core.Interface.Services
{
    public interface IClipService
    {
        IEnumerable<Clip> GetAll();

        Clip Get(int id);
        IEnumerable<Clip> FindAllByIds(int[] ids);
        IEnumerable<Clip> GetAllWithVideoQuality();
        IEnumerable<Clip> FindAllWithVideoQuality(int[] ids);

    }
}
