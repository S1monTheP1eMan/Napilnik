using System;

namespace TaskWeapon
{
    class Player
    {
        public bool IsAlive { get; private set; }

        private int _health;

        public Player(int health)
        {
            if (health <= 0)
                throw new ArgumentOutOfRangeException(nameof(health));

            IsAlive = true;
            _health = health;
        }

        public void TakeDamage(int damage)
        {
            _health -= damage;

            if (_health <= 0)
                IsAlive = false;
        }
    }
}
