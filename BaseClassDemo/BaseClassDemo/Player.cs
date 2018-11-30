using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClassDemo
{
    public class Player:LivingCreature
    {
        public bool HasArmor;
        public int Level;
        public int Gold;

        public Player(string name, bool isAlive, int currentHP, int dexterity, int strength, bool hasArmor, int level, int gold) : base(name, isAlive, currentHP, dexterity, strength)
        {
            Name = name;
            IsAlive = isAlive;
            CurrentHP = currentHP;
            Dexterity = dexterity;
            Strength = strength;
            HasArmor = hasArmor;
            Level = level;
            Gold = gold;
        }

        public void ReportStats()
        {
            Console.WriteLine("Player Name: {0}", Name);
            Console.WriteLine("\tIs Alive: {0}", IsAlive);
            Console.WriteLine("\tHP: {0}  \tDEX: {1}", CurrentHP, Dexterity);
            Console.WriteLine("\tStrength: {0}", Strength);
            Console.WriteLine("\tHas Armor: {0}", HasArmor);
            Console.WriteLine("\tLevel: {0}\t Gold:{1}", Level, Gold);
        }


    }
}
