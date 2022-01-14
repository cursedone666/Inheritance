using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Petya : Male
    {
        public override void Oplodotvorenie()
        {
            Console.WriteLine("Something bad happend");
        }
        public override void ThinkingByAllbrain()
        {
            Console.WriteLine("I'm thinking with all my brain");
        }
        public override void Run()
        {
            int meters = 100;
            Console.WriteLine($"Petya runed {meters}");
        }
        public override void Talk()
        {
            Console.WriteLine("I'm just saying some words");
        }
    }
}
