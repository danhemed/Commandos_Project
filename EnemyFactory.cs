using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandosProject.Modeles
{
    public class EnemyFactory
    {
        string name = "enemy";
        int healthBar = 100;
        string status = "life";
        string shout = "I'm enemy";

        public List<Enemy> CreateEnemys()
        {
            Random random = new Random();
            List<Enemy> enemys = new List<Enemy>();

            Console.WriteLine("Enter how much enemys you want: ");
            string? input = Console.ReadLine();
            int choise;
            if (int.TryParse(input, out choise))
            {
                while (choise > 0)
                {
                    enemys.Add(new Enemy(name + random.Next(0, 100), healthBar, status, shout));
                    choise--;
                }
            }
            return enemys;
        }
    }
}