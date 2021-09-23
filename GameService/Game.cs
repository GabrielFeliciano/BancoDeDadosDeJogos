using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameService
{
    public class Game
    {
        public readonly int id;
        public readonly string name;
        public readonly string genre;
        public readonly string release;
        public readonly int score;

        public Game(int id, string name, string genre, string release, int score) {
            this.id = id;
            this.name = name;
            this.genre = genre;
            this.release = release;
            this.score = score;
        }
    }
}
