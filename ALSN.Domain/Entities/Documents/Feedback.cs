using ALSN.Domain.Entities.Guest.Translation;
using ALSN.Domain.Entities.Translator;
using System.ComponentModel.DataAnnotations.Schema;

namespace ALSN.Domain.Entities.Documents
{
    public class Feedback
    {
        public int FeedbackId { get; set; }
        public string subject { get; set; }
        public string remarks { get; set; }
        public int rating { get; set; }

        //nav prop
        [ForeignKey("translations")]
        public int TranslationId { get; set; }
        public Translation translations { get; set; }
        
        [ForeignKey("translators")]
        public string TranslatorId { get; set; }
        public Translators translators { get; set; }
    }
}
