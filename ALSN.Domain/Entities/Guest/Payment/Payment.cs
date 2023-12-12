using ALSN.Domain.Entities.TranslationOffice;
using ALSN.Domain.Entities.TranslationOffice.DeliveryService;
using ALSN.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALSN.Domain.Entities.Guest.Payment
{
    public class Payment
    {
        public int Id { get; set; }
        public string Narration { get; set; }

        [ForeignKey("serviceCategory")]
        public int ServiceTypeId { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentStatus { get; set; }

        [ForeignKey("translationOffice")]
        public string TranslationOfficeId { get; set; }
        
        [ForeignKey("guest")]
        public string GuestId { get; set; }

        [ForeignKey("translation")]
        public int translationId { get; set; }
        //nav props
        public TranslOffice translationOffice { get; set; }
        public ServiceCategory serviceCategory { get; set; }
        public Guest guest { get; set; }
        public ALSN.Domain.Entities.Guest.Translation.Translation translation { get; set; }
        public List<PaymentDetails> PaymentDetails { get; set; }
    }
}
