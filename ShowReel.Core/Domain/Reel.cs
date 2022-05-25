using ShowReel.Core.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowReel.Core.Domain
{
    public class Reel : BaseEntity
    {
        public string Name { get; private set; }
        public  ICollection<ReelClip> ReelClips { get; private set; }


       
    }
}
