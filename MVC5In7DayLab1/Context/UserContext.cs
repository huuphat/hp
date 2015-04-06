using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVC5In7DayLab1.Models;

namespace MVC5In7DayLab1.Context
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}