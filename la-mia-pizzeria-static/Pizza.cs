namespace la_mia_pizzeria_static
{
    public class Pizza
    {
        public string Nome { get; set; }
        public string Descr { get; set; }
        public string Img { get; set; }
        public decimal Price { get; set; }
        public int Id { get; set; }

        public Pizza(string nome, string descr, string img, decimal price, int id)
        {
            Nome = nome;
            Descr = descr;
            Img = img;
            Price = price;
            Id = id;
        }
    }
}
