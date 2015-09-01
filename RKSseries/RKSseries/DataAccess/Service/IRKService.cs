using RKSseries.DataAccess.Entities;
using RKSseries.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKSseries.DataAccess.Service
{
    public interface IRKService
    {
        Repository<Game> Games { get; }
        Repository<Player> Players { get; }
        Repository<Team> Teams { get; }
        Repository<GameEvent> Events { get; }
    }
}
