using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(args[0]);
            Enemy[] enemies = new Enemy[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nome do inimigo {i+1}: ");
                enemies[i] = new Enemy(Console.ReadLine());
            }

            Console.WriteLine($"{enemies[0].GetName()} {enemies[0].GetHealth()} {enemies[0].GetShield()}");
            enemies[0].PickupPowerUp(PowerUp.Shield, 200);
            Console.WriteLine($"{enemies[0].GetName()} {enemies[0].GetHealth()} {enemies[0].GetShield()}");
            enemies[0].TakeDamage(150);
            Console.WriteLine($"{enemies[0].GetName()} {enemies[0].GetHealth()} {enemies[0].GetShield()}");
            enemies[0].TakeDamage(100);
            enemies[0].PickupPowerUp(PowerUp.Health,100);

            for (int i = 0; i < n; i++)
            {
                string name = enemies[i].GetName();
                float health = enemies[i].GetHealth();
                float shield = enemies[i].GetShield();
                Console.WriteLine($"{name} {health} {shield}");
            }
        }        
    }
}
