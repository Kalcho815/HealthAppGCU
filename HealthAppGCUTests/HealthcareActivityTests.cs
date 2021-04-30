using HealthAppGCU.Models;
using System;
using Xunit;

namespace HealthAppGCUTests
{
    public class HealthcareActivityTests
    {
        [Fact]
        public void SetCaloriesToHealtcareActivitySuccessfully()
        {
            HealthcareActivity healthcareActivity = new HealthcareActivity();

            healthcareActivity.Calories = 300;
            int calories = healthcareActivity.Calories;

            Assert.Equal(300, calories);
        }

        [Fact]
        public void SetSleepToHealtcareActivitySuccessfully()
        {
            HealthcareActivity healthcareActivity = new HealthcareActivity();
            DateTime date1 = new DateTime(2010, 1, 1, 8, 0, 15);
            DateTime date2 = new DateTime(2010, 8, 18, 13, 30, 30);
            TimeSpan timeSpan = date2 - date1;

            healthcareActivity.BedHour = date1;
            healthcareActivity.WakeHour = date2;

            TimeSpan hoursSlept = healthcareActivity.HoursSlept;
            TimeSpan expected = new TimeSpan(229, 05, 30, 15);

            Assert.Equal(expected, hoursSlept);
        }

        [Fact]
        public void SetWaterIntakeToHealtcareActivitySuccessfully()
        {
            HealthcareActivity healthcareActivity = new HealthcareActivity();

            healthcareActivity.WaterIntake = 2000;
            double litres = healthcareActivity.WaterIntake;

            Assert.Equal(2000, litres);
        }

        [Fact]
        public void SetWeightToHealtcareActivitySuccessfully()
        {
            HealthcareActivity healthcareActivity = new HealthcareActivity();

            healthcareActivity.Weight = 80;
            double kilograms = healthcareActivity.Weight;

            Assert.Equal(80, kilograms);
        }
    }
}                                                                                       
