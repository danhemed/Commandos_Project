using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CommandosProject.Modeles
{
    public class WeaponHot : Weapon
    {
        public string Producer;
        public int Bullets;

        public WeaponHot(string name, string producer, int bullets) : base(name)
        {
            Producer = producer;
            Bullets = bullets;
        }

        public void Shoot()
        {
            Console.WriteLine("Shooting!!!");
            if (Bullets > 0)
            {
                Bullets -= 1;
            }
            else
            {
                Console.WriteLine("No Bulltes!");
            }
            Console.WriteLine($"Bullets:{Bullets}");
        }
    }
}
