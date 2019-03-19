using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class QueryOperatorsDemo
    {

        static bool CostlyBook(Book b)
        {
            return b.Price > 500;
        }

        static void Main(string[] args)
        {
            var books = Book.GetBooks();
            #region "Old way of selecting objects"
            /* Old way 
            var selbooks = new List<Book>();
            foreach (Book b in books)
                if (b.Price > 500)
                    selbooks.Add(b);    */
            #endregion

            #region "Where and OrderBy"
            var selbooks = books.Where(b => b.Price > 500)
                                .OrderBy(b => b.Price);

            //foreach (Book b in selbooks)
            //    Console.WriteLine($"{b.Title} -  {b.Price}");
            #endregion

            #region "Select Demo"
            var disbooks = books.Select(b => new { Title = b.Title,
                                                   Discount = b.Price * 0.20,
                                                   Price = b.Price });

            //foreach(var b in disbooks)
            //    Console.WriteLine($"{b.Title} -  {b.Price}  - {b.Discount}");
            #endregion 

            var topbooks = books.OrderByDescending(b => b.Price).Skip(2).Take(3);
            //foreach(var b in topbooks)
            //  Console.WriteLine($"{b.Title} -  {b.Price}");

            var highprice = books.Max(b => b.Price);
            foreach (var b in books.Where(b => b.Price == highprice))
                Console.WriteLine($"{b.Title} -  {b.Price}");


        }
    }
}
