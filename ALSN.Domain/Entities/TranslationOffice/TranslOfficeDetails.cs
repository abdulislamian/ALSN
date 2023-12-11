using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALSN.Domain.Entities.TranslationOffice
{
    public class TranslOfficeDetails
    {
        [Key]
        public int Detailid { get; set; }
        public int commissionPercentage { get; set; }
        public string accountNumber { get; set; }
        public string accountHolderName { get; set; }
        public string bankName { get; set; }
        public string branchCode { get; set; }
        public string bankAddress { get; set; }

        //nav prop
        [ForeignKey("transOffice")]
        public string TranslOfficeId { get; set; }
        public TranslOffice transOffice { get; set; }
    }
}
