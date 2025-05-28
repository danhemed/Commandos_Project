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
        public void Game()
        {
            CommandoFactory createSoldiers = new CommandoFactory();
            List<Commando> soldiers = createSoldiers.CreateSoldier();

            WeaponFactory createWeapons = new WeaponFactory();
            List<Weapon> weapons = createWeapons.CreateWeapons();

            // pring the soldiers
            foreach (var soldier in soldiers)
            {
                Console.WriteLine();
                soldier.SayName("general");
                Console.WriteLine($"CodeName: {soldier.NameCode}");
                Console.WriteLine($"Status: {soldier.Status}");
                soldier.Hide();
                soldier.Attack();
                Console.WriteLine();
            }

            // print the Weapons
            foreach (var weapon in weapons)
            {
                Console.WriteLine();
                Console.WriteLine($"Weapon name: {weapon.Name}");
                weapon.Damage(weapon);
                Console.WriteLine();
            }


        }
    }
}
