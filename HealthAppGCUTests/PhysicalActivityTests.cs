using HealthAppGCUData.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HealthAppGCUTests
{
    public class PhysicalActivityTests
    {
        [Fact]
        public void SetWalkingToPhysicalActivitySuccessfully()
        {
            PhysicalActivity physicalActivity = new PhysicalActivity();
            physicalActivity.Date = DateTime.Now;
            physicalActivity.Name = "Walk";
            physicalActivity.DistanceCovered = 2.5;
            
            Assert.Equal("Walk", physicalActivity.Name);
            Assert.Equal(2.5, physicalActivity.DistanceCovered);
        }

        [Fact]
        public void SetRunningToPhysicalActivitySuccessfully()
        {
            PhysicalActivity physicalActivity = new PhysicalActivity();
            physicalActivity.Date = DateTime.Now;
            physicalActivity.Name = "Run";
            physicalActivity.DistanceCovered = 5.5;

            Assert.Equal("Run", physicalActivity.Name);
            Assert.Equal(5.5, physicalActivity.DistanceCovered);
        }

        [Fact]
        public void SetSwimmingToPhysicalActivitySuccessfully()
        {
            PhysicalActivity physicalActivity = new PhysicalActivity();
            physicalActivity.Date = DateTime.Now;
            physicalActivity.Name = "Swimming";
            physicalActivity.DistanceCovered = 1.5;

            Assert.Equal("Swimming", physicalActivity.Name);
            Assert.Equal(1.5, physicalActivity.DistanceCovered);
        }

        [Fact]
        public void SetCyclingToPhysicalActivitySuccessfully()
        {
            PhysicalActivity physicalActivity = new PhysicalActivity();
            physicalActivity.Date = DateTime.Now;
            physicalActivity.Name = "Cycling";
            physicalActivity.DistanceCovered = 10.9;

            Assert.Equal("Cycling", physicalActivity.Name);
            Assert.Equal(10.9, physicalActivity.DistanceCovered);
        }
    }
}
