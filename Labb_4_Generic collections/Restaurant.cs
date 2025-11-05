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

        public void AddToMenu(MenuItem menuItem)
        {
            _menu.Add(menuItem);
            Console.WriteLine($"Ny rätt tillagd: {menuItem}");
        }

    }
}
