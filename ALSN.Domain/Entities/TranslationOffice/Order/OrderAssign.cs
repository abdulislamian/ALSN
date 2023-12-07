using ALSN.Domain.Entities.Guest.Translation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public int TranslatorId { get; set; }
        public ALSN.Domain.Entities.Translator.Translator translators { get; set; }

        //nav propety for Order/Translation REquest
        public int TranslationId { get; set; }
        public Translation translation { get; set; }
    }
}
