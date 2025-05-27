using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CommandosProject.Modeles
{
    public class Commando
    {
        private string Name;
        public string NameCode { get; set; }
        public string[] Tools;
        public string Status;

        public Commando(string name, string nameCode, string[] tools, string status)
        {
            Name = name;
            NameCode = nameCode;
            Tools = tools;
            Status = status;
        }

        public void Walk()
        {
            Console.WriteLine($"Soldier is walking...");
            Status = "Walk";
            Console.WriteLine($"Status: {Status}");
        }

        public void Hide()
        {
            Console.WriteLine("Soldier is Hideing...");
            Status = "Hide";
            Console.WriteLine($"Status: {Status}");
        }

        public virtual void Attack()
        {
            Console.WriteLine($"Commando {NameCode}: is attacting...");
        }

        public void SayName(string commanderRank)
        {
            string gen = "GENERAL";
            string col = "COLONEL";
            string rankCom = commanderRank.ToUpper();
            if (rankCom == gen)
            {
                Console.WriteLine($"Soldier name: {Name}");
            }
            else if (rankCom == col)
            {
                Console.WriteLine($"Soldier name: {NameCode}");
            }
            else
            {
                Console.WriteLine("This is classified information!!");
            }
        } 
    }
}
