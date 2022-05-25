using ShowReel.Core.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowReel.Core.Domain
{
    public class ReelClip : BaseEntity
    {
        public int ClipId { get; set; }
        public int ReelId { get; set; }
    }
}
