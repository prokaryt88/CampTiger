using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CampTiger.Models
{
    public class Family
    {
        public string FamilyId { get; set; }
        public string LeaderId { get; set; }
        public string Name { get; set; }
    }
}