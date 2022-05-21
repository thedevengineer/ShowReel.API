using ShowReel.Core.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowReel.Core.Domain
{
    public class VideoQuality : BaseEntity
    {
        public string Standard { get; private set; }
        public string Definition { get; private set; }

        public ICollection<Reel> Reels { get; private set; }

        public VideoQuality(string standard, string definition, int id)
        {
            this.Id         = id;
            this.Standard   = standard;
            this.Definition = definition;
        }

        public VideoQuality()
        {

        }
    }
}
