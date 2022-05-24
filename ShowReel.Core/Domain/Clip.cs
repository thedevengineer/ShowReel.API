using ShowReel.Core.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowReel.Core.Domain
{
    public class Clip : BaseEntity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Duration { get; private set; }

        public int VideoQualityId { get; set; }
        public VideoQuality VideoQuality { get; private set; }


        public Clip(string name, string description, VideoQuality videoQuality, string duration, int id)
        {
            this.Id              = id;
            this.Name            = name;
            this.Description     = description;
            this.Duration        = duration;
            this.VideoQuality    = videoQuality;

        }

        public Clip(string name, string description,string duration, int videoQualityId, int id)
        {
            this.Id             = id;
            this.Name           = name;
            this.Description    = description;
            this.Duration       = duration;
            this.VideoQualityId = videoQualityId;

        }
    }
}
