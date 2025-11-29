namespace ProductETL.Domain.Entities
{
    public sealed class Product
    {
        public Guid Id { get; private set; }
        public string PN { get; private set; } 
        public string Manufacturer { get; private set; } = string.Empty;
        public string Category { get; private set; } = string.Empty;
        public DateTime CreatedAt { get; private set; }
        public ICollection<SupplierListing> SupplierListings { get; private set; } = new List<SupplierListing>();

        public Product(string pn, string manufacture, string category)
        {
            if (string.IsNullOrWhiteSpace(pn))
                throw new Exceptions.BusinessRuleException("Número de série é requerido!");

            Id = Guid.CreateVersion7();
            PN = pn;
            Manufacturer = manufacture;
            Category = category;
            CreatedAt = DateTime.UtcNow;
        }
    }
}
