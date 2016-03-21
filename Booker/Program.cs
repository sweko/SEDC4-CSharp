using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booker
{
    class Program
    {
        static IEnumerable<Author> authors;
        static IEnumerable<Book> books;

        static void Main(string[] args)
        {
            InitBooks();
            authors.PrintItems();
            books.PrintItems();

            //var result = new List<object>();
            //foreach (var book in books)
            //{
            //    var author = authors.Single(a => a.ID == book.AuthorID);
            //    var data = new
            //    {
            //        BookTitle = book.Title,
            //        AuthorName = $"{author.LastName}, {author.FirstName}",
            //        Sheets = book.PageCount / 16
            //    };

            //    Console.WriteLine(data.BookTitle);

            //    result.Add(data);
            //}

            var result = 
                from b in books
                join a in authors on b.AuthorID equals a.ID
                select new
                {
                    BookTitle = b.Title,
                    AuthorName = $"{a.LastName}, {a.FirstName}",
                    Sheets = b.PageCount / 16
                };

            Console.WriteLine(JsonConvert.SerializeObject(result));


            //	var authorPages = 
            //		from a in authors
            //		join b in books on a.ID equals b.AuthorID
            //		let ab = new {
            //			a.ID, 
            //			FullName = a.FirstName + " " + a.LastName, 
            //			b.PageCount
            //		}
            //		group ab by ab.FullName into g
            //		select new {
            //			AuthorName = g.Key,
            //			TotalPages = g.Sum(ba => ba.PageCount)
            //		};
            //		
            //	Console.WriteLine(JsonConvert.SerializeObject(authorPages));

            //	var authorPages =
            //		from a in authors
            //		select new {
            //			AuthorName = a.FirstName + " " + a.LastName,
            //			TotalPages = (from b in books
            //							where b.AuthorID == a.ID
            //							select b.PageCount).Sum()
            //		};
            //	Console.WriteLine(JsonConvert.SerializeObject(authorPages));

            var authorPages = from b in books
                         group b.PageCount by b.AuthorID into g
                         select new
                         {
                             //AuthorID = g.Key,
                             Pages = g.Sum(),
                             AuthorName = (from a in authors
                                           where a.ID == g.Key
                                           select a.FirstName + " " + a.LastName).First()
                         };

            Console.WriteLine(JsonConvert.SerializeObject(authorPages));
        }

        static void InitBooks()
        {
            authors = new List<Author>
            {
                new Author
                {
                    ID = 1,
                    FirstName = "Neil",
                    LastName = "Gaiman",
                    BookIds = new List<int> { 1, 2}
                },
                new Author
                {
                    ID = 2,
                    FirstName = "Terry",
                    LastName = "Pratchett",
                    BookIds = new List<int> { 3, 4}
                }
            };
            books = new List<Book>
            {
                new Book
                {
                    ID = 1,
                    Title = "Neverwhere",
                    PageCount = 430,
                    AuthorID = 1,
                },
                new Book
                {
                    ID = 2,
                    Title = "American Gods",
                    PageCount = 860,
                    AuthorID = 1,
                },
                new Book
                {
                    ID = 3,
                    Title = "Sourcerer",
                    PageCount = 222,
                    AuthorID = 2,
                },
                new Book
                {
                    ID = 4,
                    Title = "Small gods",
                    PageCount  =312,
                    AuthorID = 2
                }
            };
        }

        #region Lazyness example
        //var result = GetAllEvenNumbers().Skip(10).Take(5);
        //result.PrintItems();
        //var result = GetAllEvenNumbers().First();
        //Console.WriteLine(result);

        static IEnumerable<int> GetAllEvenNumbers()
        {
            int number = 2;
            while (true)
            {
                Console.WriteLine($"Yielding {number}");
                yield return number;
                number += 2;
            }
        }

        static IEnumerable<int> GetAllEvenNumbersRegular(int limit = 10000)
        {
            int number = 2;
            var result = new List<int>();
            while (limit > number)
            {
                Console.WriteLine($"Adding {number}");
                result.Add(number);
                number += 2;
            }
            return result;
        }
        #endregion

    }
}
