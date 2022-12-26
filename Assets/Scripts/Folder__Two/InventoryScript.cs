namespace Folder__Two {
    using System.Collections.Generic;

    public class InventoryScript
    {
        private List<Item> _items = new List<Item>();

        public int ItemsCount => _items.Count;

        public void PlaceItem(Item item)
        {
            if (_items.Contains(item))
            {
                return;
            }
        
            _items.Add(item);
        }
    }

    public class Item
    {
        private ICounter _counter;
        
        public Item(ICounter counter)
        {
            _counter = counter;
        }
        
        public int Count;
    }
    
    public interface ICounter {}
}