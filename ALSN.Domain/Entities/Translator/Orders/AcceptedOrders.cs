using ALSN.Domain.Entities.Guest.Translation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ALSN.Domain.Entities.Translator.Orders
{
    public class AcceptedOrders
    {
        [Key]
        public int AcceptId { get; set; }
        //NAV PROPS
        [ForeignKey("translation")]
        public int TranslationId { get; set; }
        public Translation translation { get; set; }
        
        [ForeignKey("translators")]
        public string translatorId { get; set; }
        public Translators translators { get; set; }

    }
}
