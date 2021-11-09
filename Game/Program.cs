using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start of Fight!");
            Console.WriteLine("------------------------------");

            Hunter hunter = new Hunter(100, 4, 40);
            Warrior warrior = new Warrior(80);
            Priest priest = new Priest(30, 100, 20);

            while (hunter.Health > 0 && warrior.Health > 0 && priest.Health > 0)
            {
                hunter.HunterFight(hunter, warrior);
                warrior.WarriorFight(hunter, warrior);
                priest.ActionHeal(priest, hunter);
                warrior.CharacterInfo(warrior);
                hunter.CharacterInfo(hunter);
                priest.CharacterInfo(priest);
                Console.WriteLine();

                hunter.HunterFight(hunter, warrior);
                warrior.WarriorFightPriest(priest, warrior);
                priest.ActionSelfHeal(priest);
                warrior.CharacterInfo(warrior);
                hunter.CharacterInfo(hunter);
                priest.CharacterInfo(priest);
                Console.WriteLine();
            }
            

            
        }
    }
}
