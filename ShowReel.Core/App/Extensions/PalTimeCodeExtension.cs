using ShowReel.Core.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowReel.Core.App.Extensions
{
    public static class PalTimeCodeExtension 
    {
        public static PalTimeCode Sum1(this PalTimeCode currentTimeCode, PalTimeCode otherTimeCode)
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

            return new PalTimeCode(_hour,_min,_sec,_ff);
        }


        private static (int quotient, int modulo, bool hasValue) CheckMod(int mod, double data)
        {
            if (data % mod > 0)
            {
                int _modulo = (int)Math.Ceiling(data % mod);
                int _quotient = (int)Math.Ceiling(data / mod);

                return (_quotient, _modulo, true);
            }

            return (0, 0, false);
        }
    }
}
