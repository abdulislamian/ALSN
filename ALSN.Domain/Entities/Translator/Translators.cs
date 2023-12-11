using ALSN.Domain.Entities.Documents;
using ALSN.Domain.Entities.TranslationOffice;
using ALSN.Domain.Entities.TranslationOffice.Order;
using ALSN.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALSN.Domain.Entities.Translator
{
    public class Translators:ApplicationUser
    {
        //public int TranslatorId { get; set; }
        //public string FullName { get; set; }
        //public string Email { get; set; }
        //public string Phone { get; set; }
        public string fullAddress { get; set; }
        //public string LocalizationLanguage { get; set; }
        public Language[] languages { get; set; }

        //nav prop
        //public Guid TransOfficeId { get; set; }
        //public TranslOffice TranslOffice { get; set; }

        [ForeignKey("TranslOffice")]
        public string TransOfficeId { get; set; }
        public TranslOffice TranslOffice { get; set; }

        //forfedbck
        //public Feedback feedback { get; set; }
        //forAsignORdr
        //public OrderAssign OrderAssign { get; set; }

    }
}
