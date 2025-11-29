using ProductETL.Domain.Exceptions;

namespace ProductETL.Domain.Entities
{
    public class SupplierListing
    {
        public Guid Id { get; private set; }
        public string PN { get; private set; }  
        public decimal Price { get; private set; }
        public string Currency { get; private set; } = string.Empty;
        public string Description { get; private set; } 
        public int StockQuantity { get; private set; }
        public IReadOnlyDictionary<string, string> Specs => _specs;
        private readonly Dictionary<string, string> _specs = new();
        public DateTime CreatedAt { get; private set; }
        public DateTime ValidUntil { get; private set; }

        public SupplierListing(string pn, decimal price, string curreny, string description, int quantity, Dictionary<string, string> specs, DateTime validUntil)
        {
            if (string.IsNullOrWhiteSpace(pn))
                throw new BusinessRuleException("O Número de série é requerido!");

            if (price <= 0)
                throw new BusinessRuleException("O Preço deve ser maior que zero!");


            if (string.IsNullOrWhiteSpace(curreny))
                throw new Exceptions.BusinessRuleException("A Moeda é requerida!");

            if (string.IsNullOrWhiteSpace(description))
                throw new Exceptions.BusinessRuleException("A descrição é requerida!");

            Id = Guid.CreateVersion7();
            PN = pn;
            Price = price;
            Currency = curreny;
            Description = description;
            StockQuantity = quantity;
            _specs = specs ?? new Dictionary<string, string>();
            ValidUntil = validUntil;
            CreatedAt = DateTime.UtcNow;
        }
    }
}
