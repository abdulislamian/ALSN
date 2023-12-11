using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALSN.Domain.Entities.Documents
{
    public class DocumentsType
    {
        [Key]
        public int Id { get; set; }
        public string documentName { get; set; }
        public bool isFixedPrice { get; set; }
        public int price { get; set; }
        public bool isActive { get; set; }

        //nav
        //public TranslationPrice TranslationPrice { get; set; }
    }
}
