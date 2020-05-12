﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CampTiger.Models
{
    public class AspNetUsers
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public string Address { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string FamilyId { get; set; }
    } 
}
