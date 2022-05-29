using ShowReel.Core.Domain;
using ShowReel.Core.Interface.Repositories;
using ShowReel.Core.Interface.Services;

namespace ShowReel.Application.Services
{
    public class ClipService : IClipService
    {
        private readonly IClipRepository _clipRepository;
        public ClipService(IClipRepository clipRepository)
        {
            this._clipRepository = clipRepository;
        }

        public Clip Get(int id)
        {
            return this._clipRepository.Get(id);
        }

        public IEnumerable<Clip> GetAll()
        {
            return this._clipRepository.GetAll();
        }

        public IEnumerable<Clip> FindAllByIds(int[] ids)
        {
            return this._clipRepository.Find(d => ids.Contains(d.Id));
        }

        public IEnumerable<Clip> GetAllWithVideoQuality()
        {
            return this._clipRepository.GetAllWithVideoQuality();
        }

        public IEnumerable<Clip> FindAllWithVideoQuality(int[] ids)
        {
            return this._clipRepository.FindAllWithVideoQuality(ids);
        }

        public Clip FindWithVideoQualityByIds(int id)
        {
            return this._clipRepository.FindWithVideoQualityById(id);
        }
    }
}
