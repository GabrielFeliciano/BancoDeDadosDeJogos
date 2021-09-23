using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace GameService
{
    public partial class GameServiceInMemory : ServiceBase
    {
        private List<Game> games = new List<Game>();

        public GameServiceInMemory()
        {
            InitializeComponent();
        }

        public void addGame(Game game) {
            this.games.Add(game);
        }

        public void removeGame(int id) {
            this.games = this.games
                .Where(game => game.id != id)
                .ToList();
        }

        public void updateGame(Game game)
        {
            this.games = this.games
                .ConvertAll(gotGame =>
                {
                    if (gotGame.id == game.id)
                    {
                        return game;
                    }
                    else
                    {
                        return gotGame;
                    }
                })
                .ToList();
        }

        public List<Game> getGames()
        {
            return this.games.ConvertAll(game => {
                return new Game(game.id, game.name, game.genre, game.release, game.score);
            });
        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }
    }
}
