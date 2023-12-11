using ALSN.Domain.Entities.Guest.Translation;
using ALSN.Domain.Entities.Translator;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALSN.Domain.Entities.TranslationOffice.Order
{
    public class OrderAssign
    {
        [Key]
        public int assignId { get; set; }
        //nav prop for Assignee
        [ForeignKey("translators")]
        public string TranslatorId { get; set; }
        public Translators translators { get; set; }

        //nav propety for Order/Translation REquest
        [ForeignKey("translation")]
        public int TranslationId { get; set; }
        public Translation translation { get; set; }
    }
}
