using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Masha : Female
    {
        public override void BeStrongAndIndepndent(string name)
        {
            Console.WriteLine($"{name} is strong and indepndent");
        }

        public override void playSupportPosition(string hero)
        {
            Console.WriteLine($"She plays for {hero} on support position");
        }

        public override void ShootSomeOne(string target)
        {
            Console.WriteLine($"Masha was bored, so she shot the {target}");
        }
        public override void SwimInPool(string meters)
        {
            
            Console.WriteLine($"Masha swam {meters} meters in the pool");
        }

        public static void ChangeSurname(string surname)
        {
            Console.WriteLine($"Masha didn't like her surname, that's why she changed it on {surname}");
        }

        public static void BlewBoyfriendsMind(string boyfriendsName)
        {
            Console.WriteLine($"Masha blewed her boyfriend's mind. Rest in Piece {boyfriendsName}");
        }
    }
}
