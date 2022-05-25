using ShowReel.Core.App.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowReel.Core.Domain
{
    public class NtscTimeCode : TimeCode
    {
        const int _mod = 30;

        public NtscTimeCode(string time) : base(time, _mod)
        {
        }

        public NtscTimeCode(int hour, int min, int sec, int frame) : base(hour, min, sec, frame, _mod)
        {

        }
    }
}
