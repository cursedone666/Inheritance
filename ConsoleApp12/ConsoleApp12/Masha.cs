using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Masha : Female
    {
        public override void giveBirth()
        {
            
            Console.WriteLine($"I gave birth to a boy");

        }
        public override void Run()
        {
           
            int meters = 1235;
            Console.WriteLine($"Masha runed {meters}");
        }

        public override void pregnance()
        {
            Console.WriteLine("I got pregnant");
        }
        public override void Talk()
        {
            Console.WriteLine("Let's talk, i feel so lonely");
            
        }
    }
}
