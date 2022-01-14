using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Vasya : Male
    {
        public override void Oplodotvorenie()
        {
            Console.WriteLine("");
        }
        public override void ThinkingByAllbrain()
        {
            Console.WriteLine("I Can think with all my brain?");
            
        }
        public override void Run()
        {
            
            int answer =  500;
            Console.WriteLine($"I have runed {answer}");
        }
        public override void Talk()
        {
           
            string story = "Once upon a time there was a wolf who ate someone";
            Console.WriteLine($"{story}");
        }
    }
}
