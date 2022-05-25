using ShowReel.Core.App.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowReel.Core.Extensions
{
    public static class TimeCodeExtension
    {
        public static (int hour, int minute, int sec, int frame) Sum(this TimeCode currentTimeCode, TimeCode otherTimeCode)
        {

            var _hour = currentTimeCode.Hours + otherTimeCode.Hours;
            var _min = currentTimeCode.Minutes + otherTimeCode.Minutes;
            var _sec = currentTimeCode.Seconds + otherTimeCode.Seconds;
            var _ff = currentTimeCode.Frames + otherTimeCode.Frames;


           
            var _resMin = CheckMod(_min, currentTimeCode._timeMod);
            if(_resMin.hasValue)
            {
                _hour += _resMin.quotient;
                _min = _resMin.modulo;
            }


            var _resSec = CheckMod(_sec, currentTimeCode._timeMod);
            if(_resSec.hasValue)
            {
                _min += _resSec.quotient;
                _sec = _resSec.modulo;
            }
            
            
            var _resFrame = CheckMod(_ff, currentTimeCode._mod);
            if (_resFrame.hasValue)
            {
                _sec += _resFrame.quotient;
                _ff = _resFrame.modulo;
            }

            return (_hour,_min,_sec,_ff);
        }


       

        private static (int quotient, int modulo, bool hasValue) CheckMod(double data, int mod)
        {
            if ((data > mod && data % mod > 0) 
                || (data == mod && data % mod == 0))
            {
                int _modulo = (int)Math.Ceiling(data % mod);
                int _quotient = (int)Math.Floor(data / mod);

                return (_quotient, _modulo, true);
            }

            return (0, 0, false);
        }
    }
}
