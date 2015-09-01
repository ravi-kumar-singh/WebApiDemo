using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RKSseries.DataAccess.Entities
{
    public class GameEvent : EntityBase
    {
        public virtual Game Game { get; set; }
        public virtual Player Player { get; set; }
        public int pointValue { get; set; }
    }
}
