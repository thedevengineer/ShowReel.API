using ShowReel.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowReel.Core.Interface.Services
{
    public interface IReelClipService
    {
        string CalculateTimeCode(List<Clip> clipCollection);
    }
}
