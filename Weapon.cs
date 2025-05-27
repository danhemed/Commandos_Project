using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CommandosProject.Modeles
{
    public class Weapon
    {
        public string Name;
        public string Producer;
        public int Bullets;

        public Weapon(string name, string producer, int bullets)
        {
            Name = name;
            Producer = producer;
            Bullets = bullets;
        }

        public void Shoot()
        {
            Console.WriteLine("Shooting!!!");
            Bullets -= 1;
            Console.WriteLine($"Bullets:{Bullets}");
        }
    }
}
