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
        public void Greet(string name, int age)
        {
            Console.WriteLine($"Ciao, {name}! Hai {age} anni.");
        }
    }
}

