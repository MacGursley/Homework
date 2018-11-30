using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bass Class Demo");

            Monster gobl = new Monster("Armored Goblin", true, 25, 15, 20, true, 10, 15);

            Player crome = new Player("Crome", true, 30, 20, 25, true, 20, 50);

            gobl.ReportStats();
            Console.WriteLine();
            crome.ReportStats();

            GameEngine.battleCount = 0;

            while (crome.IsAlive && gobl.IsAlive)
            {
                GameEngine.H2HPlayerBattleMonster(crome, gobl);
                gobl.ReportStats();
                Console.WriteLine();
                crome.ReportStats();
                GameEngine.battleCount++;
            }
            Console.WriteLine("battleCount:{0}", GameEngine.battleCount);

            Console.WriteLine("Press ANY KEY to quit.");
            Console.ReadKey();
        }
    }
}
