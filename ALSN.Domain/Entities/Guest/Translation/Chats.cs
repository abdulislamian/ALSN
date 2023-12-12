using ALSN.Domain.Entities.Translator;
using ALSN.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALSN.Domain.Entities.Guest.Translation
{
    public class Chats
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime SendDate { get; set; }

        [ForeignKey("translation")]
        public int TranslationId { get; set; }
       
        [ForeignKey("guest")]
        public string GuestID { get; set; }

        [ForeignKey("translators")]
        public string TranslatorID { get; set; }
        
        //nav props
        public Translation translation { get; set; }
        public Guest guest { get; set; }
        public Translators translators { get; set; }
    }
}
