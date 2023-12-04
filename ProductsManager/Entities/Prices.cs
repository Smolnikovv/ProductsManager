namespace ProductsManager.Entities
{
    public class Prices
    {
        public string Id { get; set; }
        public string SKU { get; set; }
        public double NettPrice { get; set; }
        public double NettPriceDiscount { get; set; }
        public int VATRate { get; set; }
        public double NettPriceDiscountLU { get; set; }
    }
}
