using RKSseries.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKSseries.Models
{
   public interface IModelFactory
    {
       PlayerModel Create(Player player);
    }
}
