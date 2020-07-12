using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using POC_UserManagementInterface.Areas.Identity.Data;
using POC_UserManagementInterface.Data;

[assembly: HostingStartup(typeof(POC_UserManagementInterface.Areas.Identity.IdentityHostingStartup))]
namespace POC_UserManagementInterface.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AuthDBContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AuthDBContextConnection")));


                services.AddDefaultIdentity<ApplicationInterfaceUser>(options =>
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;

                }).AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<AuthDBContext>();
            });
        }
    }
}
