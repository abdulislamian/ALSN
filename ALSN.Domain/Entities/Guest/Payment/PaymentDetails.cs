using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALSN.Domain.Entities.Guest.Payment
{
    public class PaymentDetails
    {
        [Key]
        public int DetailId { get; set; }

        [ForeignKey("Payment")]
        public int PaymentId { get; set; }
        public int Debit { get; set; }
        public int Credit { get; set; }
        //nav 
        public Payment Payment { get; set; }
    }
}
