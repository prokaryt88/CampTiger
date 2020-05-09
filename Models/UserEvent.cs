using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CampTiger.Models
{
    public class UserEvent
    {
        public string EventId { get; set; }
        public string UserId { get; set; }
        public Boolean Approved { get; set; }
    }
}