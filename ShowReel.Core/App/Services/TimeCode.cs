using ShowReel.Core.App.CustomException;
using System.Text.RegularExpressions;

namespace ShowReel.Core.App.Services
{
    public  class TimeCode 
    {
        public int Hours { get;  set; }
        public int Minutes { get;  set; }
        public int Seccods { get;  set; }
        public int Frames { get;  set; }




        protected TimeCode()
        {

        }
        public TimeCode(string time)
        {
            if (Validate(time))
            {
                var t = time.Split(':');

                this.Hours = Convert.ToInt32(t[0]);
                this.Minutes = Convert.ToInt32(t[1]);
                this.Seccods = Convert.ToInt32(t[2]);
                this.Frames = Convert.ToInt32(t[3]);
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
