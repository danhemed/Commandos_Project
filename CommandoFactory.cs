using System;
using System.Collections.Generic;
using System.Linq;
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

        Random random = new Random();

        Console.WriteLine("Enter your Soldier to make (1. Commando, 2. AirCommando, 3. SeaCommando): ");
        int option = int.Parse(Console.ReadLine());
        switch (option)     
        {
            case 1:
                new Commando(name + random.Next(1,100), nameCode + random.Next(1,100), tools, status);
                break;

            case 2:
                new AirCommando(name + random.Next(1,100), nameCode + random.Next(1,100), tools, status);
                break;
            
            case 3:
                new SeaCommando(name + random.Next(1,100), nameCode + random.Next(1,100), tools, status);
                break;
        }
    }
}