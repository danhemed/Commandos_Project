using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandosProject.Modeles
{
    public class WeaponFactory
    {
        public string Name;
        public int Width;
        public string Color;
        public string Status;

        public WeaponFactory(string name, int width, string color, string status)
        {
            Name = name;
            Width = width;
            Color = color;
            Status = status;
        }

        Weapon[] weaponArr =
        {
            new Weapon("M16", "COLT", 29),
            new Weapon("AK47", "KALASHNIKOV", 30),
        };
    }

    public class Stone : WeaponFactory
    {
        public int SumBoomBroken;
        public int SumBoom;

        public Stone(string name, int width, string color, string status, int sumBoomBroken, int sumBoom) : base(name, width, color, status)
        {
            SumBoomBroken = sumBoomBroken;
            SumBoom = sumBoom;
        }
    }

    public class Knife : WeaponFactory
    {
        public string TypeMetal;
        public string Producer;

        public Knife(string name, int width, string color, string status, string typeMetal, string producer) : base(name, width, color, status)
        {
            TypeMetal = typeMetal;
            Producer = producer;
        }
    }
}