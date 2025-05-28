using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CommandosProject.Modeles
{
    public class WeaponCold : Weapon
    {
        public double Width;
        public string Color;
        public string Status;

        public WeaponCold(string name, double width, string color, string status) : base(name)
        {
            Width = width;
            Color = color;
            Status = status;
        }

        public void WeaponBroken()
        {
            if (Status == "broken")
            {
                Console.WriteLine("The Weapon is broken");
            }
        }
    }


    public class Stone : WeaponCold
    {
        public int SumBoom;

        public Stone(string name, double width, string color, string status, int sumBoom) : base( name, width, color, status)
        {
            SumBoom = sumBoom;
        }

        public void SumBoomBroken()
        {
            SumBoom++;
            if (SumBoom > 5)
            {
                Status = "broken";
            }
        }
    }

    public class Knife : WeaponCold
    {
        public string TypeMetal;
        public string Producer;

        public Knife(string name, double width, string color, string status, string typeMetal, string producer) : base(name, width, color, status)
        {
            TypeMetal = typeMetal;
            Producer = producer;
        }
    }
}
