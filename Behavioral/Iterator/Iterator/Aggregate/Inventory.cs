using System.Collections.Generic;

namespace Iterator
{
    class Inventory : Aggregate<string>
    {
        public int ItemCount => items.Count;

        private List<string> items;

        public Inventory(params string[] items)
            => this.items = new List<string>(items);

        public string get(int i)
            => items[i];

        public Iterator<string> createIterator()
            => new InventoryIterator(this);
    }
}
