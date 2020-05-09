using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CampTiger.Models
{
    public class Group
    {
        public string GroupId { get; set; }
        public string Leader { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


    }
}