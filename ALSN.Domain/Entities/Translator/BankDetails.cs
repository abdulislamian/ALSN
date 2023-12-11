using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ALSN.Domain.Entities.Translator
{
    public class BankDetails
    {
        [Key]
        public int bankDetailId { get; set; }
        public string IBAN { get; set; }
        public string AccountHolderName { get; set; }
        public string BankName { get; set; }
        public int BranchCode { get; set; }
        public string BankAddress { get; set; }
        //Navi prop
        [ForeignKey("translator")]
        public string TranslatorId { get; set; }
        public Translators translator { get; set; }
    }
}
