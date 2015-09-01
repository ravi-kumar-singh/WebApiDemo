﻿using RKSseries.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RKSseries.DataAccess.Repositories
{
    public class PlayerRepository: Repository<Player>
    {
        public PlayerRepository(RKDbContext context): base(context)
        {

        }
    }
}