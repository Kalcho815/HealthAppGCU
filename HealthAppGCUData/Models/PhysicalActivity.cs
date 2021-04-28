using HealthAppGCU.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HealthAppGCUData.Models
{
    [Table("PHYSICAL_ACTIVITIES")]
    public class PhysicalActivity
    {
        [Key]
        [Column("NAME")]
        public string Name { get; set; }

        [ForeignKey("ID")]
        [Column("USER_ID")]
        public string UserId { get; set; }

        public User User { get; set; }

        [Column("DATE")]
        public DateTime Date { get; set; }

        [Column("TIME_STARTED")]
        public DateTime TimeStarted { get; set; }

        [Column("TIME_ENDED")]
        public DateTime TimeEnded { get; set; }

        [Column("DISTANCE_COVERED")]
        public double distanceCovered { get; set; }



    }
}
