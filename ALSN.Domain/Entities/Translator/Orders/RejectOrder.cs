using ALSN.Domain.Entities.Guest.Translation;
using System.ComponentModel.DataAnnotations;

namespace ALSN.Domain.Entities.Translator.Orders
{
    public class RejectOrder
    {
        [Key]
        public int RejectionId { get; set; }
        public int TranslationId { get; set; }
        public string DeclineReasonSubject { get; set; }
        public string DeclineReasonDescription { get; set; }
        //nav
        public Translation translation { get; set; }
    }
}
