using ShowReel.Lib.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ShowReel.Lib.Domain
{
    public  class TimeCode
    {
        public int Hours { get; private set; }
        public int Minutes { get; private set; }
        public int Seccods { get; private set; }
        public int Frames { get; private set; }

        public TimeCode(string time)
        {
            if (Validate(time))
            {
                var t  = time.Split(':');

                this.Hours   = Convert.ToInt32(t[0]);
                this.Minutes = Convert.ToInt32(t[1]);
                this.Seccods = Convert.ToInt32(t[2]);
                this.Frames  = Convert.ToInt32(t[3]);
            }
            else
                throw new InvalidFormatException("Input is not a valid timecode");
            
        }


        private bool Validate(string Time)
        {
            const string pattern = @"^(?:[01]\d|2[0-3]):[0-5]\d:[0-5]\d:[0-5]\d$";

            Regex rg = new Regex(pattern);

            if(rg.IsMatch(Time))
                return true;

            return false;
        }
    }
}
