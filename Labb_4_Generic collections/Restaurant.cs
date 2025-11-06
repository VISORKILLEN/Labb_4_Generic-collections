namespace Labb_4_Generic_collections
{
    internal class Restaurant
    {
        private List<MenuItem> _menu;
        private Queue<Order> _orders;

        public Restaurant()
        {
            _menu = new List<MenuItem>();
            _orders = new Queue<Order>();
        }

        //Method to add new meal to the menu
        public void AddToMenu(MenuItem menuItem)
        {
            _menu.Add(menuItem);
            Console.WriteLine($"Ny rätt tillagd: {menuItem}");
        }

        //Mehtod to show menu and a loop so it shows everything
        public void ShowMenu()
        {
            Console.WriteLine("\n -- Meny --");
            foreach (var item in _menu)
            {
                Console.WriteLine($"{item.Id}. {item}");
            }
        }

        //Method to create new order
        public void CreateOrder(Order order)
        {
            _orders.Enqueue(order);
            Console.WriteLine($"Ny beställning gjord: {order}");
        }

        public void HandleOrder()
        {
            if(_orders.Count > 0)
            {
                var nextOrder = _orders.Dequeue();
                Console.WriteLine("Beställning klar:");
                nextOrder.PrintOrder();
            }
            else
            {
                Console.WriteLine("Finns inga beställningar att hantera.");
            }
        }
    }
}
