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
        public string Description { get; private set; }
        public string VideoStandard { get; private set; }
        public string VideoDefinition { get; private set; }
        public string Duration { get; private set; }
        public IEnumerable<Session> SessionCollection { get; private set; }

        public Reel(string name, string description, string videoStandard, string videoDefinition, string duration, int id = -1)
        {
            this.Id              = id;
            this.Name            = name;
            this.Description     = description;
            this.VideoStandard   = videoStandard;
            this.VideoDefinition = videoDefinition;
            this.Duration        = duration;

        }
        protected Reel()
        {
        }

       
    }
}
