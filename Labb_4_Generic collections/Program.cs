namespace Labb_4_Generic_collections
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            var restaurant = new Restaurant();

            //Creates 4 new menu items that you can order using a method 4 times.
            restaurant.AddToMenu(new MenuItem(1, "Korv Stroganoff", 109));
            restaurant.AddToMenu(new MenuItem(2, "Fläsk med löksås", 98));
            restaurant.AddToMenu(new MenuItem(3, "Rödspetta med remoladsås", 137));
            restaurant.AddToMenu(new MenuItem(3, "Köttbullar med mos", 79));
            restaurant.ShowMenu();

            //Makes 3 differents menu combos you can order
            var order1Items = new List<MenuItem>
            {
                new MenuItem(1, "Korv Stroganoff", 109),
                new MenuItem(3, "Köttbullar med mos", 79)
            };

            var order2Items = new List<MenuItem>
            {
                new MenuItem(2, "Fläsk med löksås", 98),
                new MenuItem(3, "Rödspetta med remoladsås", 137)
            };

            var order3Items = new List<MenuItem>
            {
                new MenuItem(2, "Fläsk med löksås", 98),
                new MenuItem(3, "Köttbullar med mos", 79)
            };

            //Creates 3 new orders 
            Order order1 = new Order(order1Items, 5);
            Order order2 = new Order(order2Items, 3);
            Order order3 = new Order(order3Items, 6);
            restaurant.CreateOrder(order1);
            restaurant.CreateOrder(order2);
            restaurant.CreateOrder(order3);

            //Calls for some methods to show orders, next order,
            //make a order done for serving and show orders again.
            restaurant.ShowOrders();
            restaurant.ShowNextOrder();
            restaurant.HandleOrder();
            restaurant.ShowOrders();

            //Creates 1 more order and also calls a couple of methods after
            Order order4 = new Order(order2Items, 14);
            restaurant.CreateOrder(order4);
            restaurant.HandleOrder();
            restaurant.HandleOrder();
            restaurant.ShowOrders();
            restaurant.ShowNextOrder();
            restaurant.HandleOrder();
            restaurant.ShowOrders();
        }
    }
}
