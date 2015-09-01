using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RKSseries.DataAccess.Entities
{
    public class Game:EntityBase
    {
        public virtual Team Team1 { get; set; }
        public virtual Team Team2 { get; set; }

        public DateTime StartTime { get; set; }

        public virtual ICollection<GameEvent> GameEvents { get; set; }
    }
}