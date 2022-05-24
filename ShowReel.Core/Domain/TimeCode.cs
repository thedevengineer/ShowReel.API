using ShowReel.Core.App.CustomException;
using System.Text.RegularExpressions;

namespace ShowReel.Core.App.Domain
{
    public abstract class TimeCode
    {
        public int Hours { get;  set; }
        public int Minutes { get;  set; }
        public int Seconds { get;  set; }
        public int Frames { get;  set; }


        public readonly int _timeMod = 60;
        public readonly int _mod = 10;

        protected TimeCode(int mod)
        {
            this._mod = mod;
        }
        internal TimeCode(string time, int mod)
        {
            this._mod = mod;

            if (Validate(time))
            {
                var t = time.Split(':');

                this.Hours = Convert.ToInt32(t[0]);
                this.Minutes = Convert.ToInt32(t[1]);
                this.Seconds = Convert.ToInt32(t[2]);
                this.Frames = Convert.ToInt32(t[3]);
            }
            else
                throw new InvalidFormatException("Input is not a valid timecode");

        }

        internal TimeCode(int hour, int min, int sec, int frame, int mod)
        {
            this._mod = mod;

            this.Hours = hour;
            this.Minutes = min;
            this.Seconds = sec;
            this.Frames= frame;
        }

        internal TimeCode(int hour, int min, int sec, int frame)
        {

            this.Hours = hour;
            this.Minutes = min;
            this.Seconds = sec;
            this.Frames = frame;
        }


        private bool Validate(string Time)
        {
            const string pattern = @"^(?:[01]\d|2[0-3]):[0-5]\d:[0-5]\d:[0-5]\d$";

            Regex rg = new Regex(pattern);

            if(rg.IsMatch(Time))
                return true;

            return false;
        }

        public override string ToString()
        {
            return $"{this.Hours.ToString("00")}:{this.Minutes.ToString("00")}:{this.Seconds.ToString("00")}:{this.Frames.ToString("00")}";
        }


    }

}
