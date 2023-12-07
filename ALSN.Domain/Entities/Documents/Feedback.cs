using ALSN.Domain.Entities.Guest.Translation;

namespace ALSN.Domain.Entities.Documents
{
    public class Feedback
    {
        public int FeedbackId { get; set; }
        public string subject { get; set; }
        public string remarks { get; set; }
        public int rating { get; set; }

        //nav prop
        public int translationId { get; set; }
        public Translation Translation { get; set; }
        public int TranslatorId { get; set; }
        public ALSN.Domain.Entities.Translator.Translator Translator { get; set; }
    }
}
