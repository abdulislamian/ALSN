using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALSN.Domain.Entities.Documents
{
    public class TranslationPrice
    {
        public int TranslationPriceId { get; set; }
        public string sourceLanguage { get; set; }
        public string targetLanguage { get; set; }
        public int price { get; set; }

        //nav props
        [ForeignKey("DocumentsType")]
        public int DocTypeId { get; set; }
        public DocumentsType DocumentsType { get; set; }
    }
}
