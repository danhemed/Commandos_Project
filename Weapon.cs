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

        public Weapon(string name)
        {
            Name = name;
        }

        public int Damage(Weapon weapon)
        {
            if (weapon is WeaponCold)
            {
                return 40;
            }
            else if (weapon is WeaponHot)
            {
                return 70;
            }
            else
            {
                return 0;
            }
        }
    }
}
