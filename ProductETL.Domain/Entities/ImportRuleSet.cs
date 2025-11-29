namespace ProductETL.Domain.Entities
{
    public class ImportRuleSet
    {
        public Guid Id { get; set; }
        public string Process{ get; set; } = string.Empty;
        public List<ImportRule> Rules { get; set; } = new();
    }

    public class ImportRule
    {
        public Guid Id { get; set; }
        public string Condition { get; set; } = string.Empty;
        public string Action { get; set; } = string.Empty;
        public string TargetField { get; set; } = string.Empty;
        public string? Transform { get; set; }
    }

}
