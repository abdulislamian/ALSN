using ALSN.Domain.Entities.Guest.Tickets;
using ALSN.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALSN.Domain.Entities.Guest
{
    public class Guest : ApplicationUser
    {
        //public int GuestId { get; set; }
        //public string FullName { get; set; }
        //public string Email { get; set; }
        //public string Password { get; set; }
        //public string ConfirmPassword { get; set; }
        //public string LocalizationLanguage { get; set; }    
        //public string ContactNo { get; set; }

        //navi prop
        //[ForeignKey("Ticket")]
        public List<Ticket> Tickets { get; set; }
    }
}
