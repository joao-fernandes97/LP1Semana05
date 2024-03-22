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
    }
}