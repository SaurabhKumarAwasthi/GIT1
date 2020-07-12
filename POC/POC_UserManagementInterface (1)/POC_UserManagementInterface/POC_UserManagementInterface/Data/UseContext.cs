using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using POC_UserManagementInterface.Models;

namespace POC_UserManagementInterface.Data
{
    public class UseContext : DbContext
    {
        public UseContext (DbContextOptions<UseContext> options)
            : base(options)
        {
        }

        
    }
}
