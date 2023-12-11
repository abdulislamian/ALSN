using ALSN.Domain.Entities.Documents;
using ALSN.Domain.Entities.TranslationOffice.Order;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static ALSN.Application.Common.Utility.SD;

namespace ALSN.Domain.Entities.Guest.Translation
{
    public class Translation
    {
        [Key]
        public int TranslationRequestId { get; set; }
        public int DocumentTypeId { get; set; }
        public ALSN.Domain.Entities.Documents.DocumentsType DocumentRequestType { get; set; }
        public decimal ServiceCost { get; set; }
        public bool IsQuotationRequested { get; set; }
        public bool IsDiscountRequested { get; set; }
        public decimal DiscountAmount { get; set; }
        public bool IsCheckedOut { get; set; }
        public bool IsAmendmentRequested { get; set; }
        public string AmendmentReason { get; set; }
        public DateTime AmendmentRequestDate { get; set; }
        public string SourceLanguage { get; set; }
        public string TargetLanguage { get; set; }
        public long WordCount { get; set; }
        public TranslationStatus Status { get; set; }
        public DocumentType DocumentType { get; set; }
        public byte[] RequestTranslationFile { get; set; }
        public ServiceCategoryType ServiceCategoryType { get; set; }
        public Address RequestDeliveryAddresss { get; set; }
        public bool IsSMSTracking { get; set; }
        public bool IsDelivery { get; set; }
        public bool IsExtendTimeForValidity { get; set; }
        public bool IsCertificationOfDocument { get; set; }

        // Navi props
        [ForeignKey("Guest")]
        public string GuestId { get; set; }
        public Guest Guest { get; set; }
        
        [ForeignKey("translationPrice")]
        public int TranslationPriceId { get; set; }
        public TranslationPrice translationPrice { get; set; }
        

        //nav prp for feedbck
        //public Feedback feedback { get; set; }
        //forAsignORdr
        //public OrderAssign OrderAssign { get; set; }

    }
}
