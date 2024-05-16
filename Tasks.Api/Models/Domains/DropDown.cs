namespace TestingCosmo.Api.Models.Domain
{
    public class DropDown
    {
        public Guid id { get; set; }
        public string? Type { get; set; }
        public string? Question { get; set; }
        public string? Choice { get; set; }
        public bool Enable { get; set; }
    }
}