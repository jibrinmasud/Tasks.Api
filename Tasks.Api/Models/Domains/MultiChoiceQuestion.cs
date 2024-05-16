namespace TestingCosmo.Api.Models.Domain
{
    public class MultiChoiceQuestion
    {
        public Guid id { get; set; }
        public string? Type { get; set; }
        public string? Question { get; set; }
        public string? Choice { get; set; }
        public bool EnableMore { get; set; }
        public string? MaxNumber { get; set; }
    }
}