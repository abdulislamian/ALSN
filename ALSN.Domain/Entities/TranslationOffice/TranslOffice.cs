using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALSN.Domain.Entities.TranslationOffice
{
    public class TranslOffice
    {
        [Key]
        public int OfficeId { get; set; }
        public string CompanyName { get; set; }
        public string CompOwnerName { get; set; }
        public string City { get; set; }
        public string ContactNo { get; set; }
        public string Email { get;set; }
        public string LocalizationLanguage { get; set; }
        public int TotalNoOfTranslators { get; set; }
    }
}
