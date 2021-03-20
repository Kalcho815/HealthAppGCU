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
            this.DailyReports = new List<DailyReport>();
        }

        public List<DailyReport> DailyReports { get; set; }

        [MaxLength(30)]
        [Column("PASSWORD")]
        public string Password { get; set; }

        [Column("AGE")]
        public int Age { get; set; }

        [Column("WEIGHT")]
        public int Weight { get; set; }
    }
}
