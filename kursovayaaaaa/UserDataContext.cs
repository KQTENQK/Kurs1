using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovayaaaaa
{
    public class UserDataContext : DbContext
    {
        public UserDataContext() : base("DbConnectionString") { }

        public DbSet<User> Users { get; set; }
    }
}
