using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CommandosProject.Modeles
{
    public class CommandoFactory
    {
        string name = "solider";
        string nameCodeC = "c";
        string nameCodeA = "a";
        string nameCodeS = "s";
        string[] tools = ["Hammer", "Chisel", "Rope", "Bag", "WaterBottle"];
        string status = "stand";


        public List<Commando> CreateSoldier()
        {
            Random random = new Random();
            List<Commando> soliders = new List<Commando>();

            bool swape = true;
            while (swape)
            {
                Console.WriteLine("Enter your Soldier to make (1. Commando, 2. AirCommando, 3. SeaCommando, 4. Exit): ");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        soliders.Add(new Commando(name + random.Next(1, 100), $"{nameCodeC}{random.Next(1, 100)}", tools, status));
                        Console.WriteLine("makeing Soldier Commando!");
                        break;

                    case 2:
                        soliders.Add(new AirCommando(name + random.Next(1, 100), $"{nameCodeA}{random.Next(1, 100)}", tools, status));
                        Console.WriteLine("makeing Soldier AirCommando!");
                        break;

                    case 3:
                        soliders.Add(new SeaCommando(name + random.Next(1, 100), $"{nameCodeS}{random.Next(1, 100)}", tools, status));
                        Console.WriteLine("makeing Soldier SeaCommando!");
                        break;
                    case 4:
                        swape = false;
                        break;
                }
            }
            return soliders;
        }
    }
}