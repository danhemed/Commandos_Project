using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CommandosProject.Modeles
{
    public class GAME
    {
        EnemyFactory enemys = new EnemyFactory();
        
        CommandoFactory commandos =  new CommandoFactory();

        Stone stone = new Stone("stone", 5, "white", "whole", 2, 0);
    }
}
