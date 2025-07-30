using System;
using System.Collections.Generic;
using System.CommandLine;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CommandLine.NamingConventionBinder;

/* questa console app effettua un saluto all'utente se avvia da bash il programma e inserisce il proprio nome e la propria età tramite il comando apposito
utilizzare questo formato: greet nomeUtente cognomeUtente etaUtente */

namespace CLI
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var app = new CommandLineApp();
            await app.Run(args);
        }
    }

}