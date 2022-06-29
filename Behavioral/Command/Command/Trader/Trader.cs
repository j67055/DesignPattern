using System.Collections.Generic;
using System.Text;

namespace Command
{
    class Trader
    {
        public string Name { get; private set; }

        private int money;
        private Dictionary<string, Item> items = new Dictionary<string, Item>();

        public Trader(string name)
            => Name = name;

        public bool hasEnoughMoney(int price)
            => money >= price;

        public void adjustMoney(int delta)
            => money += delta;

        public void addItem(Item item)
            => items.Add(item.Name, item);

        public void removeItem(string itemName)
            => items.Remove(itemName);

        public Item getItem(string itemName)
        {
            if(items.ContainsKey(itemName))
                return items[itemName];
            return null;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append('\t')
                .Append(Name)
                .Append("\n\t\t돈: ")
                .Append(money.ToString())
                .Append("\n\t\t물품: ");
            foreach (var itemName in items.Keys)
                sb.Append(itemName)
                    .Append(", ");

            return sb.ToString();
        }
    }
}
