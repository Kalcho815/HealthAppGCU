using HealthAppGCU.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HealthAppGCUData.Models
{
    [Table("HEALTHCARE_ACTIVITIES")]
    public class HealthcareActivity
    {
        public HealthcareActivity()
        {
            Guid guid = new Guid();
            this.Id = guid.ToString();
            this.DailyReports = new List<DailyReport>();
        }

        [Column("ID")]
        [Key]
        public string Id { get; set; }

        [MaxLength(50)]
        [Column("NAME")]
        public string Name { get; set; }

        public int Calories { get; set; }

        public double WaterIntake { get; set; }

        [ForeignKey("HEALTHCARE_CATEGORY_ID")]
        [Column("HEALTHCARE_CATEGORY_ID")]
        public string HealthcareActivityCategoryId { get; set; }

        public HealthcareActivityCategory HealthcareActivityCategory { get; set; }

        public List<DailyReport> DailyReports { get; set; }
    }
}
