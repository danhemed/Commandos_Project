using System;
using System.Collections.Generic;
using System.Linq;
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
            Console.WriteLine("Enter your Soldier to make (1. Commando, 2. AirCommando, 3. SeaCommando): ");
            int option = int.Parse(Console.ReadLine());
            List<Commando> soliders = new List<Commando>();
            switch (option)
            {
                case 1:
                    soliders.Add(new Commando(name + random.Next(1, 100), $"{nameCodeC}{random.Next(1, 100)}", tools, status));
                    break;

                case 2:
                    soliders.Add(new AirCommando(name + random.Next(1, 100), $"{nameCodeA} {random.Next(1, 100)}", tools, status));
                    break;

                case 3:
                    soliders.Add(new SeaCommando(name + random.Next(1, 100), $"{nameCodeS} {random.Next(1, 100)}", tools, status));
                    break;
            }
            return soliders;
        }
    }
}