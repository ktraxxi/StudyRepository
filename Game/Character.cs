using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Character
    {
        public Character(string name, int maxHealth, int currentHealth)     // constructor
        {
            _name = name;
            _maxHealth = maxHealth;
            _currentHealth = currentHealth;
        }

        private string _name;               // fields
        public string Name { get => _name; }
        private int _maxHealth;
        private int _currentHealth;

        
        public int Health               // Property
        {
            get { return _currentHealth; }
            set 
            {
                if (value <= 0)
                {
                     _currentHealth = 0;
                }
                else if (value > _maxHealth)
                {
                    _currentHealth = _maxHealth;
                }
                else
                {
                    _currentHealth = value;
                }
            }
        }
        public void Death(Hunter hunter)                       // "Death" method
        {
            Console.WriteLine($"{hunter._name} is dead.");  
        }
        public void Death(Warrior warrior)                       // "Death" method
        {
            Console.WriteLine($"{warrior._name} is dead.");
        }
        public void Death(Priest priest)                       // "Death" method
        {
            Console.WriteLine($"{priest._name} is dead.");
        }
        public void CharacterInfo(Hunter hunter)                  // Character Info Method
        {
            Console.WriteLine($"{hunter._name}'s arrow count is {hunter.ArrowsCount}, " +
                $"max health is {hunter._maxHealth}, current health is {hunter.Health}");
        }
        public void CharacterInfo(Warrior warrior)                  // Character Info Method
        {
            Console.WriteLine($"{warrior._name}'s max health is {warrior._maxHealth}, current health is {warrior.Health}");
        }
        public void CharacterInfo(Priest priest)                  // Character Info Method
        {
            Console.WriteLine($"{priest._name}'s mana left is {priest.Mana}, " +
                $"max health is {priest._maxHealth}, current health is {priest.Health}");
        }

    }
}
