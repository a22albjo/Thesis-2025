namespace FluxClient.Models
{
    public record OperatorModel
    {
        public Guid Id { get; set; }
        public string? OpId { get; set; }
        public string? OpName { get; set; }
        public bool Access1 { get; set; }
        public bool Access2 { get; set; }
        public bool Access3 { get; set; }
        public string? ChangedBy { get; set; }
        public DateTime ChangedTime { get; set; }
        public string? Description { get; set; }
        public bool SelectedToBeDeleted { get; set; } = false;
    }
}

