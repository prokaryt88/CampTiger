using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CampTiger.Models
{
    public class UserFamily
    {
        public string FamilyId { get; set; }
        public string UserId { get; set; }

    }
}