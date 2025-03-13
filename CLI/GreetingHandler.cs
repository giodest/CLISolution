using System;
using System.Collections.Generic;
using System.CommandLine;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CommandLine.NamingConventionBinder;
using System.CommandLine.Invocation;

namespace CLI
{
    public class GreetingHandler
    {
        public void Greet(string name, string surname, int age)
        {
            Console.WriteLine($"Ciao, {name} {surname}! Hai {age} anni.");
        }
    }
}

