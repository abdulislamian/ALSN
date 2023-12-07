using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALSN.Application.Common.Utility
{
    public class SD
    {
        public enum LanguageDirection{LTR,RTL}
        public enum Role{ALSNAdmin,TranslationOffice,Translator}
        public enum TicketStatus{ Pending, InProgress,Done}
        public enum DocumentType { CNIC, BirthCertificate,LegalDocuments, OtherDocumentType}
        public enum ServiceCategoryType { Standard, Priority,SuperPriority}
        public enum TranslationStatus{New,InProgress,Completed,Returned}
        public enum OrderStatus { Assigned,InProgress,Completed,Returned}
    }
}
