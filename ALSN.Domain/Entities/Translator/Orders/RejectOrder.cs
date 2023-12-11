using ALSN.Domain.Entities.Guest.Translation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ALSN.Domain.Entities.Translator.Orders
{
    public class RejectOrder
    {
        [Key]
        public int RejectionId { get; set; }
        
        [ForeignKey("Translation")]
        public int TranslationId { get; set; }
        public string DeclineReasonSubject { get; set; }
        public string DeclineReasonDescription { get; set; }
        //nav
        public Translation translation { get; set; }
    }
}
