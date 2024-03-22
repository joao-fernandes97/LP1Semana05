using System;

namespace JogoDeSexta
{
    public class Level
    {
        private int rooms;
        private Toughness difficulty;
        private Enemy[] enemies;

        public Level(int rooms, Toughness difficulty)
        {
           this.rooms = rooms;
           this.difficulty = difficulty
           enemies = new Enemy[rooms];
        }

        public Toughness GetToughness()
        {
            return difficulty;
        }

        public int GetNumRooms()
        {
            return rooms;
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
    }
}