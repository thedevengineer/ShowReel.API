using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowReel.Core.Exceptions
{
    public class InvalidCollectionException : Exception
    {
        public InvalidCollectionException(string message) : base(message)
        {
        }
    }
}
