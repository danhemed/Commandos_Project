using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandosProject.Modeles
{
    public class Enemy
    {
        public string Name;
        public int HealthBar;
        public string Status;
        public string Shout;

        public Enemy(string name, int healthBar, string status, string shout)
        {
            Name = name;
            HealthBar = healthBar;
            Status = status;
            Shout = shout;
        }
    }
}
