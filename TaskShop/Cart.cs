using System;
using System.Collections.Generic;

namespace TaskShop
{
    class Cart
    {
        private Dictionary<Good, int> _items;
        private Warehouse _warehouse;

        private const string Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        public string Paylink { get; private set; }

        public Cart(Warehouse warehouse)
        {
            _items = new Dictionary<Good, int>();
            _warehouse = warehouse;
        }

        public string Order()
        {
            string items = "";

            foreach (Good item in _items.Keys)
            {
                _warehouse.RemoveItem(item);

                items += item.Name + " ";
            }

            Paylink = CreateRandomLink();

            return items;
        }

        public void Add(Good good, int quantity)
        {
            if (CheckItem(good, quantity))
            {
                _items.Add(good, quantity);
            }
            else
            {
                throw new ArgumentException(nameof(good));
            }
        }

        private bool CheckItem(Good good, int quantity)
        {
            return good == null || quantity <= _warehouse.TryGetItemQuantity(good);
        }

        private string CreateRandomLink()
        {
            Random random = new Random();

            string link = "";

            for (int i = 0; i < Chars.Length; i++)
            {
                link += Chars[random.Next(Chars.Length)];
            }

            return link;
        }
    }
}