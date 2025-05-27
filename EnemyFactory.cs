using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandosProject.Modeles
{
    public class EnemyFactory
    {
        Enemy[] enemyArr = 
        {
            new Enemy("jamil", 100, "life", "I'm Enemy!!!"),
            new Enemy("hchmed", 100, "life", "I'm Enemy!!!"),
            new Enemy("muchamad", 100, "life", "I'm Enemy!!!")
        };
    }
}