using System.ComponentModel.DataAnnotations;

namespace TestingCosmo.Api.Models.Domain
{
    public class QuestionsType
    {
        public Guid id { get; set; }

        [Key]
        public int QuestionsId { get; set; }

        public ParagrapQuestion? ParagrapQuestion { get; set; }
        public YesNoQuestion? YesNoQuestion { get; set; }
        public DropDown? DropDown { get; set; }
        public DateQuestion? DateQuestion { get; set; }
        public NumberQuestion? NumberQuestion { get; set; }
    }
}