using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Warrior : Character
    {
        public Warrior(int meleeDamage) : base("Varian", 500, 500)
        {
            _meleeDamage = meleeDamage;
        }

        private int _meleeDamage;
        public int MeleeDamage { get => _meleeDamage; }

        public void WarriorFight(Hunter hunter, Warrior warrior)
        {
            Console.WriteLine("Warrior attacks Hunter!");
            
            hunter.Health = hunter.Health - MeleeDamage;                
            Console.WriteLine($"Warrior's dealed damage is {MeleeDamage}");            
            
            if (hunter.Health <= 0)
            {
                Death(hunter);
            }
        }
        public void WarriorFightPriest(Priest priest, Warrior warrior)
        {
            Console.WriteLine("Warrior attacks Priest!");

            priest.Health -= MeleeDamage;
            Console.WriteLine($"Warrior's dealed damage is {MeleeDamage}");

            if (priest.Health <= 0)
            {
                Death(priest);
            }

        }
    }
}
