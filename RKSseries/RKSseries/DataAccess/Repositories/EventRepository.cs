using RKSseries.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RKSseries.DataAccess.Repositories
{
    public class EventRepository : Repository<GameEvent>
    {
        public EventRepository(RKDbContext context)
            : base(context)
        {

        }
    }
}