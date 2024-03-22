using System;

namespace JogoDeSexta
{
    public class Level
    {
        private Toughness difficulty;
        private Enemy[] enemies;

        public Level(int rooms, Toughness difficulty)
        {
           this.difficulty = difficulty;
           enemies = new Enemy[rooms];
        }

        public Toughness GetToughness()
        {
            return difficulty;
        }

        public int GetNumRooms()
        {
            return enemies.Length;
        }

        public int GetNumEnemies()
        {
            int numEnemies = 0;
            foreach (Enemy enemy in enemies)
            {
                if(enemy!=null) numEnemies++;
            }
            return numEnemies;
        }

        public void SetEnemyInRoom(int room, Enemy enemy)
        {
            enemies[room] = enemy;
        }

        public void PrintEnemies()
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                if(enemies[i]!=null)
                {
                    Console.WriteLine($"Room {i}: {enemies[i].GetName()}");
                }
            }
        }
    }
}
