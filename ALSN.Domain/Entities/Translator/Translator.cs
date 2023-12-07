using ALSN.Domain.Entities.Documents;
using ALSN.Domain.Entities.TranslationOffice;
using ALSN.Domain.Entities.TranslationOffice.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALSN.Domain.Entities.Translator
{
    public class Translator
    {
        public int TranslatorId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string fullAddress { get; set; }
        public string LocalizationLanguage { get; set; }
        public Language[] languages { get; set; }

        //nav prop
        public int TransOfficeId { get; set; }
        public TranslOffice TranslOffice { get; set; }

        //forfedbck
        public Feedback feedback { get; set; }
        //forAsignORdr
        public OrderAssign OrderAssign { get; set; }

    }
}
