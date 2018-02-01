using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ConsoleApplication3.Model
{
    public class MSCEntity : DbContext
    {
        public MSCEntity() : base ("name = DefaultConnection")
        {
            
        }

        public DbSet<User> Users { get; set; }
    }
}
