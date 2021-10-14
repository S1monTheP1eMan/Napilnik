using System;
using System.Collections.Generic;

namespace TaskShop
{
    class Warehouse
    {
        private Dictionary<Good, int> _goods;

        public Warehouse()
        {
            _goods = new Dictionary<Good, int>();
        }

        public void Delive(Good good, int quantity)
        {
            if (quantity <= 0)
                throw new ArgumentOutOfRangeException(nameof(quantity));

            _goods.Add(good, quantity);
        }

        public void RemoveItem(Good good)
        {
            _goods.Remove(good);
        }

        public int TryGetItemQuantity(Good good)
        {
            int qantity;

            if (_goods.TryGetValue(good, out qantity))
            {
                return qantity;
            }
            else
            {
                throw new ArgumentNullException(nameof(good));
            }
        }
    }
}
