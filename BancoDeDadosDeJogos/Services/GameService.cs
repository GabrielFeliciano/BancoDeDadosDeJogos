using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoDeDadosDeJogos.Models;

namespace BancoDeDadosDeJogos.Services
{
    public class GameService
    {
        private readonly GameModelContainer _context;

        public GameService(GameModelContainer ctx)
        {
            _context = ctx;
        }

        public void CreateGame(string name, string genre, string release, int score)
        {
            var game = new Game()
            {
                Name = name,
                Genre = genre,
                Release = release,
                Score = score
            };

            _context.Add(game);
            _context.SaveChanges();
        }

        public List<Game> GetGames()
        {
            return _context.Games1.ToList();
        }
    }
}
