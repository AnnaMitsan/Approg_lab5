using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CodeFirstModel;

namespace CodeFirstDataAccess
{
    public class BookEntityContext : DbContext
    {
        public BookEntityContext()
            : base("name=DbConnectionString")
        {
        } 
        public DbSet<Book> Books { get; set; }
    }
}
