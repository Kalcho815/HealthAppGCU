using HealthAppGCU.Models;
using HealthAppGCUData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAppGCU.Adaptors
{
    public class PhysicalActivityAdaptor
    {
        public PhysicalActivity GetPhysicalActivity(PhysicalActivityViewModel viewModel)
        {
            var result = new PhysicalActivity
            {
                Name = viewModel.Name,
                Date = DateTime.Now,
                DistanceCovered = viewModel.DistanceCovered,
                TimeEnded = viewModel.TimeEnded,
                TimeStarted = viewModel.TimeStarted,
            };
            return result;
        }
    }
}
