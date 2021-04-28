using HealthAppGCUData.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAppGCU.Models
{
    [Table("USERS")]
    public class User : IdentityUser
    {
        public User()
        {
            this.HealthcareActivities = new List<HealthcareActivity>();
            this.PhyiscalActivities = new List<PhysicalActivity>();
        }

        public List<HealthcareActivity> HealthcareActivities { get; set; }

        public List<PhysicalActivity> PhyiscalActivities { get; set; }

        [Column("FIRST_NAME")]
        public string FirstName { get; set; }

        [Column("LAST_NAME")]
        public string LastName { get; set; }

        [Column("AGE")]
        public int Age { get; set; }

        [Column("WEIGHT")]
        public int Weight { get; set; }

    }
}
