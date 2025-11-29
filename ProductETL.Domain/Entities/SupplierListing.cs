namespace ProductETL.Domain.Entities
{
    public class SupplierListing
    {
        public Guid Id { get; set; }
        public required string PN { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int StockQuantity { get; set; }
        Dictionary<string, string> Specs { get; set; } = new();
        public DateTime CreatedAt { get; set; }
        public DateTime ValidUntil { get; set; }
    }
}
