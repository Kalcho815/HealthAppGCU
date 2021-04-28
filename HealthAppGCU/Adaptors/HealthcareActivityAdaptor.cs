using HealthAppGCU.Models;

namespace HealthAppGCU.Adaptors
{
    public class HealthcareActivityAdaptor
    {
        public HealthcareActivityViewModel GetActivityViewModel(HealthcareActivity healthcareActivity)
        {
            return new HealthcareActivityViewModel
            {
                HoursSlept = healthcareActivity.HoursSlept.ToString().Substring(0,2),
                Date = healthcareActivity.Date,
                Calories = healthcareActivity.Calories,
                Id = healthcareActivity.Id,
                WaterIntake = healthcareActivity.WaterIntake,
                Weight = healthcareActivity.Weight
            };
        }
    }
}
