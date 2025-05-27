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
            new Weapon("M16", "COLT", 29),
            new Weapon("AK47", "KALASHNIKOV", 30),
        };
    }

    public class Stone : WeaponFactory
    {
        public string Name;
        public int Width;
        public string Status;
        public int SumBoomBroken;
        public int SumBoom;
    }
}