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
            GAME game = new GAME();
            game.Game();
        }
    }
}
