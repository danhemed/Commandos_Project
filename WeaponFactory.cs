using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandosProject.Modeles
{
    public class WeaponFactory
    {
        public List<Weapon> CreateWeapons()
        {
            List<Weapon> weapons = new List<Weapon>();

            bool swape = true;
            while (swape)
            {
                Console.WriteLine("Enter your Weapon to make (1. Stone, 2. Knife, 3. M16, 4. AK47, 5. Exit): ");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        weapons.Add(new Stone("stone", 3.5, "white", "whole", 0));
                        Console.WriteLine("makeing Stone Weapon!");
                        break;
                    case 2:
                        weapons.Add(new Knife("Knife", 3.5, "white", "whole", "steel", "MODO"));
                        Console.WriteLine("makeing Knife Weapon!");
                        break;
                    case 3:
                        weapons.Add(new WeaponHot("M16", "COLT", 29));
                        Console.WriteLine("makeing M16 Weapon!");
                        break;
                    case 4:
                        weapons.Add(new WeaponHot("AK47", "KALASHNIKOV", 30));
                        Console.WriteLine("makeing AK47 Weapon!");
                        break;
                    case 5:
                        swape = false;
                        Console.WriteLine("Exit...");
                        break;
                }
            }
            return weapons;
        }
    }
}