using HealthAppGCUData.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthAppGCU.Models
{
    [Table("HEALTHCARE_ACTIVITIES")]
    public class HealthcareActivity
    {
        public HealthcareActivity()
        {
            this.Id = Guid.NewGuid().ToString();
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


        //TODO: Change to heart rate 
        [Column("BLOOD_PRESSURE")]
        public int BloodPressure { get; set; }

        [Column("WEIGHT")]
        public double Weight { get; set; }

        [ForeignKey("USER_ID")]
        [Column("USER_ID")]
        public string UserId { get; set; }

        public User User { get; set; }

        [ForeignKey("HealthcareActivityCategoryId")]
        public string HealthcareActivityCategoryId { get; set; }

        //TODO: Remove nullable
        public HealthcareActivityCategory? HealthcareActivityCategory { get; set; }

    }
}






//using HealthAppGCU.Models;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace HealthAppGCUData.Models
//{
//    [Table("HEALTHCARE_ACTIVITIES")]
//    public class HealthcareActivity
//    {
//        public HealthcareActivity()
//        {
//            Guid guid = new Guid();
//            this.Id = guid.ToString();
//            this.DailyReports = new List<DailyReport>();
//        }

//        [Column("ID")]
//        [Key]
//        public string Id { get; set; }

//        [MaxLength(50)]
//        [Column("NAME")]
//        public string Name { get; set; }

//        [ForeignKey("HEALTHCARE_CATEGORY_ID")]
//        [Column("HEALTHCARE_CATEGORY_ID")]
//        public string HealthcareActivityCategoryId { get; set; }

//        public HealthcareActivityCategory HealthcareActivityCategory { get; set; }

//        public List<DailyReport> DailyReports { get; set; }
//    }
//}