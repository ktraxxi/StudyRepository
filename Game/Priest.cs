using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Priest : Character
    {
        private int _healValue;            // поля и свойства
        public int healValue { get => _healValue; }


        private int _manaCost;
        public int ManaCost
        {
            get { return _manaCost; }
            set
            {
                if (value < 0)
                {
                    _manaCost = 0;
                    Console.WriteLine("Mana is low!");
                }
                else
                {
                    _manaCost = value;
                }
            }
        }


        private int _mana;
        public int Mana
        {
            get { return _mana; }
            set 
            {
                if (value < 0)
                {
                    _mana = 0;
                }
                else
                {
                    _mana = value;
                }                
            }
        }

        public Priest(int healValue, int mana, int manaCost) : base("Anduin", 150,  150)     // конструктор
        {
            _healValue = healValue;
            _mana = mana;
            _manaCost = manaCost;
        }

        public void ActionHeal(Priest priest, Hunter hunter)
        {
            if (Mana > 0)
            {
                Console.WriteLine("Paladin healed Hunter!");
                hunter.Health += healValue;
                Mana -= ManaCost;
                Console.WriteLine($"Priest dealed healing is {healValue}, Mana spent is {ManaCost}, Mana left is {Mana}");
            }
            else
            {
                Console.WriteLine($"{priest.Name} is out of mana!");
            }
        }
        public void ActionSelfHeal(Priest priest)
        {
            if (Mana > 0)
            {
                Console.WriteLine("Paladin healed himself!");
                priest.Health += healValue;
                Mana -= ManaCost;
                Console.WriteLine($"Priest dealed healing is {healValue}, Mana spent is {ManaCost}, Mana left is {Mana}");
            }
            else
            {
                Console.WriteLine($"{priest.Name} is out of mana!");
            }
        }

    }
}
