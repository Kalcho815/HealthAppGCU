using System;

namespace HealthAppGCU.Models
{
    public class HealthcareActivityViewModel
    {
        public string Id { get; set; }

        public DateTime Date { get; set; }

        public int Calories { get; set; }

        public double WaterIntake { get; set; }

        public int BloodPressure { get; set; }

        public double Weight { get; set; }
    }
}
