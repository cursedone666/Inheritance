using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Vasya : Male
    {
        public override void playMidPosition(string hero)
        {
            Console.WriteLine($"Petya doesn't like to play mid position for {hero}");
        }
        public override void ShootSomeOne(string target)
        {
            Console.WriteLine($"Petya lost previous game so he shot {target}");
        }
        public override void SwimInPool(string meters)
        {
            Console.WriteLine($"Petya swimming very fast, he swam {meters} for just 20 seconds");
        }
        public override void WatchAnime(string anime)
        {
            Console.WriteLine($"Petya hate watching Bleach, but he adored of {anime}");
        }
        public static void BreakHearthToAnotherOne(string girlName)
        {
            Console.WriteLine($"Petya break relations with another one," +
                              $" her name is {girlName}, as i remember");
        }
        public static void GetDriverLicense(string licenseCategory)
        {
            Console.WriteLine($"Petya passed his exams in driving school," +
                              $" so he received his driver" +
                              $" license with {licenseCategory} category");
        }
    }
}
