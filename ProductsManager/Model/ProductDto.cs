namespace ProductsManager.Model
{
    public class ProductDto
    {
        public string ProductName { get; set; }
        public string EAN { get; set; }
        public string ProducerName { get; set; }
        public string Category {  get; set; }
        public string DefaultImage { get; set; }
        public int Quantity { get; set; }
        public double NettPrice { get; set; }
        public double ShippingCost { get; set; }
        public string Unit { get; set; }

    }
}
