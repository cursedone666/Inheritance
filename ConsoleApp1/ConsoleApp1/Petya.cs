using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Petya : Male
    {
        public override void playMidPosition(string hero)
        {
            Console.WriteLine($"Petya is playing mid position for {hero}");

        }
        public override void ShootSomeOne(string target)
        {
            Console.WriteLine($"Petya was angry so he shot {target}");
        }

        public override void WatchAnime(string anime)
        {
            Console.WriteLine($"Petya's most favorite anime is {anime}");
        }
        public override void SwimInPool(string meters)
        {
            Console.WriteLine($"Petya swam just a {meters} meters");
        }
        public static void JoinITCourse(string coursesName)
        {
            Console.WriteLine($"Petya didn't like education" +
                              $" in university so he joined {coursesName}");
        }
        public static void PullProject(string projectName)
        {
            Console.WriteLine($"Petya pulled his project '{projectName}' to GitHub branch");
        }
    }
}
