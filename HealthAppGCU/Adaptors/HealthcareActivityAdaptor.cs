using HealthAppGCU.Models;

namespace HealthAppGCU.Adaptors
{
    public class HealthcareActivityAdaptor
    {
        public HealthcareActivityViewModel GetActivityViewModel(HealthcareActivity healthcareActivity)
        {
            return new HealthcareActivityViewModel
            {
                BloodPressure = healthcareActivity.BloodPressure,
                Date = healthcareActivity.Date,
                Calories = healthcareActivity.Calories,
                Id = healthcareActivity.Id,
                WaterIntake = healthcareActivity.WaterIntake,
                Weight = healthcareActivity.Weight
            };
        }
    }
}
