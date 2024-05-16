using System.ComponentModel.DataAnnotations;

namespace TestingCosmo.Api.Models.Domain
{
    public class ParagrapQuestion
    {
        public Guid id { get; set; }
        public string? Type { get; set; }
        public string? Question { get; set; }
    }
}