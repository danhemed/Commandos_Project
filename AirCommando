using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandosProject.Modeles
{
    public class AirCommando : Commando
    {
        public AirCommando(string name, string nameCode, string[] tools, string status) : base(name, nameCode, tools, status)
        {
        }

        public void Parachuting()
        {
            Console.WriteLine("The commandos are parachuting from a plane.");
        }

        public override void Attack()
        {
            Console.WriteLine($"AirCommando {NameCode}: is attacting in the air...");
        }
    }
}
