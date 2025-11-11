namespace Labb_4_Generic_collections
{
    internal class Order
    {
        static int orderIdCounter = 1;
        private int _orderId;
        private List<MenuItem> _orderItems;
        private int _tableNumber;

        public Order(List<MenuItem> orderItems, int tableNumber)
        {
            _orderId = orderIdCounter;
            orderIdCounter++;
            _orderItems = orderItems;
            _tableNumber = tableNumber;
        }

        //Method that print outs orders that are left
        public void PrintOrder()
        {
            Console.WriteLine($"Beställning #{_orderId} - Bord {_tableNumber}");
            Console.WriteLine("Innehåll:");
            
            foreach(var item in _orderItems)
            {
                Console.WriteLine($" - {item}");
            }
        }

        //Mehtod that tells the order and what table it is,
        //Also what menu items are connected to it
        public override string ToString()
        {
            return $"Order #{_orderId} (Bord {_tableNumber}) - {_orderItems.Count} artiklar";
        }
    }
}
