namespace Labb_4_Generic_collections
{
    internal class Order
    {
        static int orderIdCounter = 1;
        private int orderId;
        private List<MenuItem> orderItems;
        private int tableNumber;

        public Order(List<MenuItem> orderItems, int tableNumber)
        {
            orderId = orderIdCounter;
            orderIdCounter++;
            this.orderItems = orderItems;
            this.tableNumber = tableNumber;
        }

        //Method that print outs orders that are left
        public void PrintOrder()
        {
            decimal totalSum = 0;
            Console.WriteLine($"Beställning #{orderId} - Bord {tableNumber}");
            
            foreach(var item in orderItems)
            {
                totalSum += item.Price;
                Console.WriteLine($" - {item}");
            }
            Console.WriteLine($"Totalt belopp för beställning: {totalSum:C}");
        }

        //Mehhod to return orderId so other classes can call for it
        public int GetOrderID()
        {
            return orderId;
        }

        //Mehtod that tells the order and what table it is,
        //Also what menu items are connected to it
        public override string ToString()
        {
            return $"Order #{orderId} (Bord {tableNumber}) - {orderItems.Count} artiklar";
        }
    }
}
