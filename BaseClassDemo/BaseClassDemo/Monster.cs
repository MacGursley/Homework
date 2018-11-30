using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClassDemo
{
    public class Monster:LivingCreature
    {
        public bool HasArmor;
        public int RewardGold;
        public int RewardXP;

        public Monster(string name, bool isAlive, int currentHP, int dexterity, int strength, bool hasArmor, int rewardGold, int rewardXP):base(name, isAlive, currentHP, dexterity, strength)
        {
            Name = name;
            IsAlive = isAlive;
            CurrentHP = currentHP;
            Dexterity = dexterity;
            Strength = strength;
            HasArmor = hasArmor;
            RewardGold = rewardGold;
            RewardXP = rewardXP;
        }

        public void ReportStats()
        {
            Console.WriteLine("Monster Name: {0}", Name);
            Console.WriteLine("\tIs Alive:{0}", IsAlive);
            Console.WriteLine("\tHP: {0} \tDEX:{1}", CurrentHP, Dexterity);
            Console.WriteLine("\tStrength:{0}", Strength);
            Console.WriteLine("\tHas Armor:{0}", HasArmor);
        }


    }
}
