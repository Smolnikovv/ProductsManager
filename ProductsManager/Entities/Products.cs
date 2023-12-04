namespace ProductsManager.Entities
{
    public class Products
    {
        public int Id { get; set; }
        public string SKU { get; set; }
        public string Name { get; set; }
        public string ReferenceNumber { get; set; }
        public string EAN { get; set; }
        public string ProducerName { get; set; }
        public bool IsWire { get; set; }
        public bool Avialable { get; set; }
        public bool IsVendor { get; set; }
        public string DefaultImage { get; set; }
    }
}
