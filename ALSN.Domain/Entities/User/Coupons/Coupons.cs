using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALSN.Domain.Entities.User.Coupons
{
    public class Coupons
    {
        [Key]
        public int CouponId { get; set; }
        public string couponCode { get; set; }
        public int discountType { get; set; }
        public int discountValue { get; set; }
        public int minimumOrderAmount { get; set; }
        public DateTime validFrom { get; set; }
        public DateTime validTo { get; set; }

        //nav props to know who created the coupon
        [ForeignKey("ApplicationUser")]
        public string UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
