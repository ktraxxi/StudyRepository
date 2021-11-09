using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Hunter : Character
    {
        public Hunter(int rangeDamage, int arrowsCount, int meleeDamage) : base("Rexxar", 350, 350)
        {
            _rangeDamage = rangeDamage;
            _meleeDamage = meleeDamage;
            _arrowsCount = arrowsCount;
        }

        private int _rangeDamage;
        public int RangeDamage { get => _rangeDamage;}

        private int _meleeDamage;
        public int MeleeDamage { get => _meleeDamage;}

        private int _arrowsCount;
        
        public int ArrowsCount
        {
            get { return _arrowsCount; }
            set 
            {
                if (value < 0)
                {
                    _arrowsCount = 0;
                }
                else
                {
                    _arrowsCount = value;
                }
            }
        }

        public void HunterFight(Hunter hunter, Warrior warrior)
        {
            Console.WriteLine("Hunter attacks Warrior!");
            if (ArrowsCount > 0)
            {
                warrior.Health = warrior.Health - RangeDamage;
                ArrowsCount = ArrowsCount - 1;
                Console.WriteLine($"Hunters dealed damage is {RangeDamage}, Arrows left is {ArrowsCount}");
            }            
            else
            {
                warrior.Health -= hunter._meleeDamage;
                Console.WriteLine($"Hunters dealed damage is {MeleeDamage}, Arrows left is {ArrowsCount}");
            }
            if (warrior.Health <=0)
            {
                Death(warrior);
            }
            
        }
            
    }
        
}

