using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BancoDeDadosDeJogos.Services;
using BancoDeDadosDeJogos.Models;

namespace BancoDeDadosDeJogos
{
    static class Program
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services
                .AddScoped<GameService>()
                .AddDbContext<GameModelContainer>(opt => opt.UseInMemoryDatabase("db"));
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main(serviceProvider));
        }
    }
}
