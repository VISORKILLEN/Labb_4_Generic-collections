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

        //A method to handel orders if there are any to handle, and removes the order on top
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
        
        //A method that show all the orders that are in queue. 
        //And a message if there aren't any.
        public void ShowOrders()
        {
            Console.WriteLine("-- Nuvarande beställningar -- ");
            if(_orders.Count == 0)
            {
                Console.WriteLine("Finns inga beställnignar i kö.");
            }

            foreach(var order in _orders)
            {
                order.PrintOrder();
            }
        }

        //Method that shows the next order in queue,
        //messages if there aren't any in queue.
        public void ShowNextOrder()
        {
            if (_orders.Count > 0)
            {
                Console.WriteLine("-- Nästa beställning --");
                _orders.Peek().PrintOrder();
            }
            else
            {
                Console.WriteLine("Ingen nästa beställning " +
                    "(finns ingen beställning i kön");
            }
        }

        //A method that shows how many orders there are
        public void ShowOrderCount()
        {
            Console.WriteLine($"Det finns {_orders.Count} beställningar i kön.");
        }
    }
}
