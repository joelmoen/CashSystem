namespace Checkout_System
{
    public class Product
    {
        private string plu;
        private string name;
        private int price;

        public Product(string plu, string name, int price)
        {
            this.plu = plu;
            this.name = name;
            this.price = price;
        }
        public void PrintProduct()
        {
            Console.WriteLine("Plu: {0}\nName: {1}\nPrice: {2}", plu, name, price);
        }
        public string GetPlu()
        {
            return plu;
        }

        public int GetPrice()
        {
            return price;
        }
        public string GetName()
        {
            return name;
        }
    }
}
