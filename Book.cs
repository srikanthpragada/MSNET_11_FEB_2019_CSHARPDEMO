using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class Book
    {
        public string Title { get; set; }
        public int Price { get; set; }

        public static List<Book> GetBooks()
        {
            List<Book> books = new List<Book> {
                new Book { Title ="C# Comp. Ref." , Price = 400},
                new Book { Title ="Asp.net Unleashed" , Price = 800},
                new Book { Title ="Asp.Net MVC Unleashed" , Price = 700},
                new Book { Title ="Entity Framework" , Price = 600},
                new Book { Title ="Angular" , Price = 450},
                new Book { Title ="jQuery" , Price = 350}
            };

            return books; 
        }
    }
}
