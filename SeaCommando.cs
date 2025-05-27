using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandosProject.Modeles
{
    public class SeaCommando : Commando
    {
        public SeaCommando(string name, string nameCode, string[] tools, string status) : base(name, nameCode, tools, status)
        {
        }

        public void Swimming()
        {
            Console.WriteLine("The commandos are swimming in the oceaon.");
        }

        public override void Attack()
        {
            Console.WriteLine($"SeaCommando {NameCode}: is attacting in the sea...");
        }
    }
}