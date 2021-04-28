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
        public PhysicalActivity()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Key]
        [Column("ID")]
        [MaxLength(255)]
        public string Id { get; set; }

        [Column("NAME")]
        [MaxLength(255)]
        public string Name { get; set; }

        [ForeignKey("USER")]
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
        public double DistanceCovered { get; set; }
    }
}
