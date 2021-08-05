using System;

namespace TaskWeapon
{
    class Player
    {
        private int _health;

        public Player(int health)
        {
            if (health <= 0)
                throw new ArgumentOutOfRangeException(nameof(health));

            _health = health;
        }

        public void TryTakeDamage(int damage)
        {
            if (_health <= 0)
                throw new ArgumentOutOfRangeException(nameof(_health));

            _health -= damage;
        }
    }
}
