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

        WeaponFactory weapons = new WeaponFactory();
    }

}
