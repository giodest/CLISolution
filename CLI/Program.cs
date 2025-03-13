using System;
using System.CommandLine;
using System.CommandLine.NamingConventionBinder;
using System.Threading.Tasks;

/* questa console app effettua un saluto all'utente se avvia da bash il programma e inserisce il proprio nome e la propria età tramite il comando apposito
utilizzare questo formato: --name nomeUtente etaUtente */

namespace CLI
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var rootCommand = new RootCommand
            {
                new Option<string>(
                    "--name",
                    description: "Il nome della persona"
                ),

                new Argument<int>(
                    "age",
                    description: "L'età della persona"
                )
            };

            rootCommand.Handler = CommandHandler.Create<string, int>((name, age) =>
            {
                Console.WriteLine($"Ciao, {name}! Hai {age} anni.");
                return Task.CompletedTask;
            });

            await rootCommand.InvokeAsync(args);
        }
    }
}