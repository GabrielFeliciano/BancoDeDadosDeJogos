using BancoDeDadosDeJogos.Models;
using BancoDeDadosDeJogos.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BancoDeDadosDeJogos
{
    public partial class Main : Form
    {
        public readonly GameService gameService;

        public Main(ServiceProvider Services)
        {
            gameService = Services.GetService<GameService>();
            InitializeComponent();
        }

        private void updateList(IEnumerable<Game> games) {
            this.listView1.Items.Clear();

            foreach (Game game in games)
            {
                string[] values = {
                    game.Id.ToString(),
                    game.Name,
                    game.Genre,
                    game.Release,
                    game.Score.ToString()
                };
                this.listView1.Items.Add(new ListViewItem(values));
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            string nameInput = this.NameBox.Text;
            string genreInput = this.GenreBox.Text;
            string releaseInput = this.ReleaseBox.Text;
            string scoreInput = this.ScoreBox.Text;

            try
            {
                var scoreParsedInput = int.Parse(scoreInput);
                gameService.CreateGame(nameInput, genreInput, releaseInput, scoreParsedInput);
                var games = gameService.GetGames();
                updateList(games);
            } catch (FormatException)
            {
                // do nothing
                // programming at 3 AM, im so sleepy and angry to microsoft
                // i hate the docs, the package manager, the visual studio, every-thing
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
