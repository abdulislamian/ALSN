using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALSN.Domain.Entities.User
{
    public class User
    {
        public int UserId { get; set; }
        public string fullName { get; set; }
        public string Email { get; set; }
        public string country { get; set; }
        public string phone { get; set; }
        public string RoleId { get; set; }
        //navigatio prop 
        public Role Roles { get; set; }

    }
}
