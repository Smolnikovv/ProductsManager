namespace ProductsManager.Entities
{
    public class Inventory
    {
        public int ProductId { get; set; }
        public string SKU { get; set; }
        public string Unit { get; set; }
        public int Quantity { get; set; }
        public string Manufacturer { get; set; }
        public string Shipping { get; set; }
        public double ShippingCost { get; set; }
        public virtual Products Products { get; set; }
    }
}
