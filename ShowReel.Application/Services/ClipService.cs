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


    }
}
