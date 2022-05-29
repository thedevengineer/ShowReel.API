using ShowReel.Core.Domain;
using ShowReel.Core.Exceptions;
using ShowReel.Core.Extensions;
using ShowReel.Core.Interface.Services;
using ShowReel.Core.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowReel.Application.Services
{
    public class ReelClipService: IReelClipService
    {
        public string CalculateTimeCode(List<Clip> clipCollection)
        {
            if(Validate(clipCollection))
            {
                var videoStandard = clipCollection.First().VideoQuality.Standard;
                var resultTimeCode = "";

                if (videoStandard == StringConstants.VideoStandard_PAL)
                    resultTimeCode = CalculatePAL(clipCollection);
                else if (videoStandard == StringConstants.VideoStandard_NTSC)
                    resultTimeCode = CalculateNTSC(clipCollection);
                else
                    throw new InvalidFormatException("Video Standard not recognized.");
                
                return resultTimeCode;
            }
            throw new InvalidCollectionException("Requested Collection is not valid.");
        }

        private bool Validate(List<Clip> clipCollection)
        {
            var videoQualityCollection = clipCollection.Select(x => $"{x.VideoQuality.Definition}-{x.VideoQuality.Standard}");
            var timeCodeCollection = clipCollection.Select(x => x.Description);

            return videoQualityCollection.Select(s => s.ToLower()).Distinct().Count() == 1;
        }

        private string CalculateNTSC(List<Clip> clipCollection)
        {
            var sumation = new NtscTimeCode(0, 0, 0, 0);
            foreach (var clip in clipCollection)
            {
                var timeCode = new NtscTimeCode(clip.Duration);
                var res = timeCode.Sum(sumation);

                sumation = new NtscTimeCode(res.hour, res.minute, res.sec, res.frame);
            }

            return sumation.ToString();

        }

        private string CalculatePAL(List<Clip> clipCollection)
        {
            var sumation = new PalTimeCode(0, 0, 0, 0);
            foreach (var clip in clipCollection)
            {
                var timeCode = new PalTimeCode(clip.Duration);
                var res = timeCode.Sum(sumation);

                sumation = new PalTimeCode(res.hour, res.minute, res.sec, res.frame);
            }

            return sumation.ToString();

        }

    }
}
