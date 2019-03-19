using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class QueryExpressionDemo
    {

        static bool CostlyBook(Book b)
        {
            return b.Price > 500;
        }

        static void Main(string[] args)
        {
            var books = Book.GetBooks();

            var selbooks = from b in books
                           where b.Price > 500
                           orderby b.Title
                           select new
                           {
                               Title = b.Title,
                               Price = b.Price * 1.08
                           };

            foreach (var b in selbooks)
                Console.WriteLine($"{b.Title} - {b.Price}");


            var highprice = books.Max(b => b.Price);

            var topbooks = from b in books
                           where b.Price == highprice
                           select b;

            var topbook = (from b in books
                           where b.Price < 500
                           select b).FirstOrDefault();

            if (topbook != null)
                Console.WriteLine(topbook.Title);
            else
                Console.WriteLine("Book Not Found");

            var avgprice = books.Average(b => b.Price);


        }
    }
}
