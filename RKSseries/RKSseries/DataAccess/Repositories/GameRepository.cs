using RKSseries.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RKSseries.DataAccess.Repositories
{
    public class GameRepository: Repository<Game>
    {
        public GameRepository(RKDbContext context)
            : base(context)
        {

        }
    }
}