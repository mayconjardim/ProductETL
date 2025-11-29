namespace ProductETL.Domain.Entities
{
    public sealed class Product
    {
        public Guid Id { get; private set; }
        public required string PN { get; set; } 
        public string Manufacturer { get; set; } = string.Empty;
        public string Category { get; private set; } = string.Empty;
        public DateTime CreatedAt { get; private set; }
        public ICollection<SupplierListing> SupplierListings { get; private set; } = new List<SupplierListing>();
    }
}
