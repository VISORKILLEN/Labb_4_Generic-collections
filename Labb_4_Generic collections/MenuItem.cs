namespace Labb_4_Generic_collections
{
    internal class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public MenuItem(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        //metod for the name and price of the menu item
        public override string ToString()
        {
            return $"{Name} - {Price:C}";
        }
    }
}
