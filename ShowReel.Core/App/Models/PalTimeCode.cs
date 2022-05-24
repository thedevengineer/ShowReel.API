using ShowReel.Core.App.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowReel.Core.App.Models
{
    public class PalTimeCode : TimeCode
    {
        const int _mod = 25;

        public PalTimeCode(string time) : base(time, _mod)
        {
        }

        public PalTimeCode(int hour, int min, int sec, int frame) : base(hour, min, sec, frame, _mod)
        {

        }
        
    }
}
