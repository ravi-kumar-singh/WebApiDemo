using RKSseries.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RKSseries.Models
{
    public class ModelFactory : IModelFactory
    {
        public PlayerModel Create(Player player)
        {
            return new PlayerModel { FirstName = player.FirstName, LastName = player.LastName, PlayerId = player.ID, TeamId = player.Team.ID, TeamName = player.Team.Name };
        }
    }
}