using System;
using System.Collections.Generic;
using System.CommandLine;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CommandLine.NamingConventionBinder;

namespace CLI
{
    public class CommandLineApp
    {
        private readonly RootCommand _rootCommand;

        public CommandLineApp()
        {
            _rootCommand = new RootCommand();
            InitializeCommands();
        }

        private void InitializeCommands()
        {
            var greetCommand = new GreetCommand();
            _rootCommand.AddCommand(greetCommand.GetCommand());
        }

        public async Task Run(string[] args)
        {
            await _rootCommand.InvokeAsync(args);
        }
    }

}
