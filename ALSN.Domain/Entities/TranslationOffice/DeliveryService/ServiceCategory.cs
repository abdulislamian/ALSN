using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALSN.Domain.Entities.TranslationOffice.DeliveryService
{
    public class ServiceCategory
    {
        [Key]
        public int serviceCatId { get; set; }
        public string ServiceName { get; set; }
        public double ServiceFee { get; set; }
        public string RequiredTime { get; set; }
    }
}
