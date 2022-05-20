﻿using ShowReel.Core.Domain;
using ShowReel.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowReel.Data.Repositories
{
    internal class ReelRepository: Repository<Reel>, IRepository<Reel>
    {
        public ReelRepository(ShowReelDbContext context): base(context)
        {
        }
    }
}
