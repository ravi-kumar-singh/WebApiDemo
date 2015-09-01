using RKSseries.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RKSseries.DataAccess.Repositories
{
    public class TeamRepository : Repository<Team>
    {
        public TeamRepository(RKDbContext context)
            : base(context)
        {

        }
    }
}