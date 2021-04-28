using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAppGCU.Models
{
    public class PhysicalActivityViewModel
    {
        public string Name { get; set; }

        public DateTime Date { get; set; }

        public DateTime TimeStarted { get; set; }

        public DateTime TimeEnded { get; set; }

        public double DistanceCovered { get; set; }
    }
}
