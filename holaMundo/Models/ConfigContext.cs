
using holaMundo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace holaMundo.Models
{
    public class ConfigContext : DbContext
    {

        public ConfigContext()
            : base("defaultConnection")
        {

        }


        public DbSet<User> User { get; set; }
        public DbSet<Profesion> Profesion { get; set; }

    }
}