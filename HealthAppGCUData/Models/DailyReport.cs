using HealthAppGCUData.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAppGCU.Models
{
    [Table("DAILY_REPORTS")]
    public class DailyReport
    {
        public DailyReport()
        {
            Guid guid = new Guid();
            this.Id = guid.ToString();
        }

        [Key]
        [Column("ID")]
        public string Id { get; set; }

        [Column("DATE")]
        public DateTime Date { get; set; }

        [Column("CALORIES")]
        public int Calories { get; set; }

        [Column("WATER_INTAKE")]
        public double WaterIntake { get; set; }

        [Column("BLOOD_PRESSURE")]
        public int BloodPressure { get; set; }

        [Column("WEIGHT")]
        public double Weight { get; set; }

        [ForeignKey("USER_ID")]
        [Column("USER_ID")]
        public string UserId { get; set; }

        public User User { get; set; }

        [ForeignKey("HEALTHCARE_ACTIVITY_ID")]
        public string HealthcareActivityId { get; set; }

        public HealthcareActivity HealthcareActivity{ get; set; }
    }
}
