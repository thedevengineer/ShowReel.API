using ShowReel.Core.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowReel.Core.Domain
{
    public  class Session : BaseEntity
    {
        public string SessionId { get; private set; }
        public IEnumerable<Reel> ReelCollection { get; private set; }
        public DateTimeOffset TimeStamp { get; private set; }

        protected Session()
        {

        }
    }
}
