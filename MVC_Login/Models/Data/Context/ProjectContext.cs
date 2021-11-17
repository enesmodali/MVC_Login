using MVC_Login.Models.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_Login.Models.Data.Context
{
    public class ProjectContext: DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = @"Server=DESKTOP-E9LRMFA\MSSQLSERVER2019; Database=BoostKD5AccountDB; Uid=sa; Pwd=3123754;";

        }
        public DbSet<ApplicationUser>Users { get; set; }
    }
}