
using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(HealthAppGCU.Areas.Identity.IdentityHostingStartup))]
namespace HealthAppGCU.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}

