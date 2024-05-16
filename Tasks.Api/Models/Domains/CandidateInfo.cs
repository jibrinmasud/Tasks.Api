using System.ComponentModel.DataAnnotations;

namespace TestingCosmo.Api.Models.Domain
{
    public class CandidateInfo
    {
        public Guid id { get; set; }

        public int CandidateId { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        [Required, EmailAddress]
        public string? Email { get; set; }

        [Phone]
        public string? Phone { get; set; }

        public string? Nationality { get; set; }
        public string? CureentResident { get; set; }
        public string? IdNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Gender { get; set; }

        public string? AboutSelf { get; set; }
        public string? YearOfGradution { get; set; }
        public bool Rejected { get; set; }
        public string? YearOfExpirence { get; set; }
        public DateTime RelocationDate { get; set; }
    }
}