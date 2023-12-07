using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALSN.Domain.Entities.TranslationOffice
{
    public class TranslOfficeDetails
    {
        public int id { get; set; }
        public int commissionPercentage { get; set; }
        public string accountNumber { get; set; }
        public string accountHolderName { get; set; }
        public string bankName { get; set; }
        public string branchCode { get; set; }
        public string bankAddress { get; set; }

        //nav prop
        public string TransOfficeId { get; set; }
        public TranslOffice transOffices { get; set; }
    }
}
