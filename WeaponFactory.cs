using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandosProject.Modeles
{
    public class WeaponFactory
    {
        Weapon[] weaponArr = 
        {
            new Weapon("M16", "apple", 40),
            new Weapon("AK47", "BOOMBOOM", 80),
            new Weapon("GON", "shootAM", 15)
        };
    }
}