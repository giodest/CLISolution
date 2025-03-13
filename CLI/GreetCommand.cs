using System;
using System.Collections.Generic;
using System.CommandLine;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CommandLine.NamingConventionBinder;

namespace CLI
{
    public class GreetCommand
    {
        public Command GetCommand()
        {
            var greetCommand = new Command("greet")
            {
                new Option<string>(
                    "--name",
                    description: "Il nome della persona"
                ) { IsRequired = true },

                new Argument<int>(
                    "age",
                    description: "L'età della persona"
                ) { Arity = ArgumentArity.ExactlyOne }
            };

            greetCommand.Handler = CommandHandler.Create((string name, int age) =>
            {
                var greetingHandler = new GreetingHandler(); 
                greetingHandler.Greet(name, age);
                return Task.CompletedTask;
            });

            return greetCommand;
        }
    }

}
