using ShowReel.Core.App.CustomException;
using ShowReel.Core.Domain;
using ShowReel.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowReel.Data.Repositories
{
    public class ClipRepository: BaseRepository<Clip>, IClipRepository
    {
        public ClipRepository(ShowReelDbContext context): base(context)
        {
        }

    }
}
