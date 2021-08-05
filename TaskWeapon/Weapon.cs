using System;

namespace TaskWeapon
{
    class Weapon
    {
        private int _damage;
        private int _bullets;

        public Weapon(int damage, int bullets)
        {
            if (bullets < 0)
                throw new ArgumentOutOfRangeException(nameof(bullets));

            if (damage < 0)
                throw new ArgumentOutOfRangeException(nameof(damage));

            _damage = damage;
            _bullets = bullets;
        }

        public void Fire(Player player)
        {
            if (_bullets <= 0)
                throw new InvalidOperationException();

            _bullets -= 1;
            player.TryTakeDamage(_damage);
        }
    }
}
