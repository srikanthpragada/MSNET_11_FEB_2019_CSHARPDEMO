using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.CF
{
    public partial class BooksContext : DbContext
    {
        public BooksContext()
        {
            //Disable initializer 
            Database.SetInitializer<BooksContext>(null);
        }

        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<Title> Titles { get; set; }
    }
}
