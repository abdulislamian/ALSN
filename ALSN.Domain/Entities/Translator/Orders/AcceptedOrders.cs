using ALSN.Domain.Entities.Guest.Translation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALSN.Domain.Entities.Translator.Orders
{
    public class AcceptedOrders
    {
        [Key]
        public int Id { get; set; }
        //NAV PROPS
        public int TranslationId { get; set; }
        public Translation translation { get; set; }

        public int TranslatorId { get; set; }
        public Translator translator { get; set; }

    }
}
