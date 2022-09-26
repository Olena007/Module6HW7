namespace ASP_hometask1.Entity
{
    public class Flora
    {
        public int id { get; set; }

        public string name { get; set; }

        public decimal price { get; set; }

        public Flora(int id, string name, decimal price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }
    }
}
