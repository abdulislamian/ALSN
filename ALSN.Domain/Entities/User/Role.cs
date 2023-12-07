﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALSN.Domain.Entities.User
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        //public List<string> Permissions { get; set; }
    }
}
