using System;

namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;

        public Enemy(string name)
        {
            SetName(name);
            health = 100;
            shield = 0;
        }

        public string GetName()
        {
            return name;
        }

        public float GetHealth()
        {
            return health;
        }

        public float GetShield()
        {
            return shield;
        }

        public void SetName(string name)
        {
            if(name.Length>8) name = name.Substring(0,8);
            this.name = name;
        }

        public void TakeDamage(float damage)
        {
            shield -= damage;
            if(shield<0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if(health<0) health = 0;
            }
        }

        public void PickupPowerUp(PowerUp powerUp, float value)
        {
            if(powerUp==PowerUp.Health)
            {
                health += value;
                if(health>100) health = 100;
            } else if(powerUp==PowerUp.Shield)
            {
                shield += value;
                if(shield>100) shield = 100;
            }
        }
    }
}