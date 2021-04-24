using System;
using bugtracker.Areas.Identity.Data;
using bugtracker.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(bugtracker.Areas.Identity.IdentityHostingStartup))]
namespace bugtracker.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<bugtrackerContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("bugtrackerContextConnection")));

                services.AddDefaultIdentity<bugtrackerUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<bugtrackerContext>();
            });
        }
    }
}