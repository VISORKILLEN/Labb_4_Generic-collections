namespace Labb_4_Generic_collections
{
    internal class Restaurant
    {
        private List<MenuItem> menu;
        private Queue<Order> orders;

        public Restaurant()
        {
            menu = new List<MenuItem>();
            orders = new Queue<Order>();
        }
       
        //Method to add new meal to the menu
        public void AddToMenu(MenuItem menuItem)
        {
            menu.Add(menuItem);
            Console.WriteLine($"Ny rätt tillagd: {menuItem}");
            Console.WriteLine();
        }

        //Mehtod to show menu and a loop so it shows everything
        public void ShowMenu()
        {
            Console.WriteLine("-- Meny --");
            foreach (var item in menu)
            {
                Console.WriteLine($"{item.Id}. {item}");
            }
            Console.WriteLine();
        }

        //Method that creates new order
        public void CreateOrder(Order order)
        {
            orders.Enqueue(order);
            Console.WriteLine($"Ny beställning gjord: {order}");
            Console.WriteLine();
        }
        
        //A method that show all the orders that are in queue. 
        //And a message if there aren't any.
        public void ShowOrders()
        {
            Console.WriteLine("-- Nuvarande beställningar --");
            if(orders.Count == 0)
            {
                Console.WriteLine("Finns inga beställnignar i kö.");
                Console.WriteLine();
            }

            foreach(var order in orders)
            {
                order.PrintOrder();
                Console.WriteLine();
            }
        }

        //Method that shows the next order in queue,

        //A method to handel orders if there are any to handle, and removes the order on top
        public void HandleOrder()
        {
            if(orders.Count > 0)
            {
                var nextOrder = orders.Dequeue();
                Console.WriteLine($"Beställning #{nextOrder.GetOrderID()} är klar!"); 
            }
            else
            {
                Console.WriteLine("Finns inga beställningar att hantera.");
            }
            Console.WriteLine();
        }
        //messages if there aren't any in queue.
        //Or print the next order in queue
        public void ShowNextOrder()
        {
            if (orders.Count > 0)
            {
                Console.WriteLine("-- Nästa beställning --");
                orders.Peek().PrintOrder();
            }
            else
            {
                Console.WriteLine("Ingen nästa beställning " +
                    "(finns ingen beställning i kön");
            }
            Console.WriteLine();
        }

        //A method that shows how many orders there are
        public void ShowOrderCount()
        {
            Console.WriteLine($"Det finns {orders.Count} beställningar i kön.");
        }
    }
}
