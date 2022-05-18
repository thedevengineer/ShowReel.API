using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowReel.Lib.Domain
{
    public class Reel
    {
        public string Name { get; private set; }
        public string VideoStandard { get; private set; }
        public string VideoDefinition { get; private set; }
        public TimeCode Duration { get; private set; }

        public Reel(string name, string videoStandard, string videoDefinition, string duration)
        {
            this.Name            = name;
            this.VideoStandard   = videoStandard;
            this.VideoDefinition = videoDefinition;
            this.Duration        = new TimeCode(duration);
        }
    }
}
