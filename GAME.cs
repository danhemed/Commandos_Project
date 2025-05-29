using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CommandosProject.Modeles
{
    public class GAME
    {
        public void Game()
        {
            CommandoFactory createSoldiers = new CommandoFactory();
            WeaponFactory createWeapons = new WeaponFactory();
            EnemyFactory createEnemys = new EnemyFactory();


            List<Commando> soldiers = new List<Commando>();
            List<Weapon> weapons = new List<Weapon>();
            List<Enemy> enemys = new List<Enemy>();

            bool swape = true;
            while (swape)
            {
                Console.WriteLine("Enter your choise (1. create commando 2. create weapon 3. create enemy 4. exit):");
                string? input = Console.ReadLine();
                int choise;
                if (int.TryParse(input, out choise))
                {
                    switch (choise)
                    {
                        case 1:
                            soldiers = createSoldiers.CreateSoldiers();
                            break;
                        case 2:
                            weapons = createWeapons.CreateWeapons();
                            break;
                        case 3:
                            enemys = createEnemys.CreateEnemys();
                            break;
                        case 4:
                            swape = false;
                            break;
                        default:
                            Console.WriteLine("enter only 1 and 2!!!");
                            break;
                    }
                }
            }

            // pring the soldiers
            Console.WriteLine();
            Console.WriteLine("SOLDIERS:");
            foreach (var soldier in soldiers)
            {
                Console.WriteLine();
                soldier.SayName("general");
                Console.WriteLine($"CodeName: {soldier.NameCode}");
                Console.WriteLine($"Status: {soldier.Status}");
                soldier.Hide();
                soldier.Attack();
            }

            // print the Weapons
            Console.WriteLine();
            Console.WriteLine("WEAPONS:");
            foreach (var weapon in weapons)
            {
                Console.WriteLine();
                Console.WriteLine($"Weapon name: {weapon.Name}");
                weapon.Damage(weapon);
            }

            // print the enemys
            Console.WriteLine();
            Console.WriteLine("ENEMYS:");
            foreach (var enemy in enemys)
            {
                Console.WriteLine();
                Console.WriteLine($"Enemy name: {enemy.Name}");
                Console.WriteLine($"Enemy healthBar: {enemy.HealthBar}");
                Console.WriteLine($"Enemy status: {enemy.Status}");
                Console.WriteLine($"Enemy shout: {enemy.Shout}");
            }


        }
    }
}
