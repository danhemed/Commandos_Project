using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CommandosProject.Modeles
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Commando soldier = new Commando("boomy", "x65", ["Hammer", "Chisel", "rope", "bag", "WaterBottle"], "stand");
            // soldier.Walk();
            // soldier.Hide();
            // soldier.Attack();
            // soldier.NameCode = "Y77";
            // soldier.SayName("colonel");
            // soldier.SayName("general");
            // soldier.SayName("");
            // Console.WriteLine();

            // Weapon weapon = new Weapon("gon", "apple", 10);
            // weapon.Shoot();
            // Console.WriteLine();

            // Commando[] arraySoldier =
            // {
            //     new Commando("soldier1", "r17", ["Hammer", "Chisel", "rope", "bag", "WaterBottle"], "stand"),
            //     new AirCommando("soldier2", "a90", ["Hammer", "Chisel", "rope", "bag", "WaterBottle"], "stand"),
            //     new SeaCommando("soldier3", "j88", ["Hammer", "Chisel", "rope", "bag", "WaterBottle"], "stand")
            // };

            // foreach (var sold in arraySoldier)
            // {
            //     sold.SayName("General");
            //     sold.Walk();
            //     sold.Hide();
            //     sold.Attack();
            //     Console.WriteLine();
            // }


            CommandoFactory createSoldiers = new CommandoFactory();
            List<Commando> soldiers = createSoldiers.CreateSoldier();
            foreach (var soldier in soldiers)
            {
                Console.WriteLine(soldier.NameCode);
                Console.WriteLine(soldier.Status);
            }
        }
    }
}
