using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RKSseries.DataAccess.Entities;
using RKSseries.DataAccess.Repositories;

namespace RKSseries.DataAccess.Service
{
    public class RKService: IRKService
    {
        private Repository<Game> _games;
        private Repository<Player> _players;
        private Repository<Team> _teams;
        private Repository<GameEvent> _events;

        public Repository<Game> Games
        {
            get
            {
                if (_games == null)
                
                    _games = new GameRepository(new RKDbContext());
                    return _games;
               
            }
          
        }

        public Repository<Player> Players
        {
            get
            {
                if (_players == null)
                
                    _players = new PlayerRepository(new RKDbContext());
                    return _players;
                
            }
          
        }

        public Repository<Team> Teams
        {
            get
            {
                if (_teams == null)
               
                    _teams = new TeamRepository(new RKDbContext());
                    return _teams;
               
            }
            
        }

        public Repository<GameEvent> Events
        {
            get
            {
                if (_events == null)
               
                    _events = new EventRepository(new RKDbContext());
                    return _events;
                
            }
           
        }
    }
}