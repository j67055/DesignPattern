using System;

namespace Iterator
{
    class InventoryIterator : Iterator<string>
    {
        public string Current => isDone() ? throw new IndexOutOfRangeException() : inventory.get(index);

        private Inventory inventory;
        private int index;

        public InventoryIterator(Inventory inventory)
            => this.inventory = inventory;

        public void first()
            => index = 0;

        public bool isDone()
            => index == inventory.ItemCount;

        public void next()
            => ++index;
    }
}
