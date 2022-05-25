using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowReel.Core.Exceptions
{
    public class RestrictedActionException:Exception
    {
        public RestrictedActionException(string message) : base(message)
        {
        }
    }
}
