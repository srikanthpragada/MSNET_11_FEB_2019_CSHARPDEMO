using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.CF
{
    class Test
    {
        static void Main(string[] args)
        {
            BooksContext ctx = new BooksContext();
            ctx.Publishers.Add(new Publisher { Name = "Wrox" });
            ctx.Publishers.Add(new Publisher { Name = "Sams" });
            ctx.SaveChanges();

        }
    }
}
