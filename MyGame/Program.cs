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
