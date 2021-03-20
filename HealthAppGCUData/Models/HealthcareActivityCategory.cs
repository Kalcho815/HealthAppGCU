using HealthAppGCU.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HealthAppGCUData.Models
{
    [Table("HEALTHCARE_ACTIVITIES_CATEGORIES")]
    public class HealthcareActivityCategory
    {
        public HealthcareActivityCategory()
        {
            Guid guid = new Guid();
            this.Id = guid.ToString();
            this.HealthcareActivities = new List<HealthcareActivity>();
        }

        [Key]
        [Column("ID")]
        public string Id { get; set; }

        [Column("NAME")]
        [MaxLength(50)]
        public string Name { get; set; }

        public List<HealthcareActivity> HealthcareActivities { get; set; }
    }
}
