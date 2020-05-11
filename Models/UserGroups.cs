using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CampTiger.Models
{
    public class UserGroups
    {
        public string GroupId { get; set; }
        public string UserId { get; set; }
    }
}