using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _05.BookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Library library = ReadAllBooks(n);
            List<Book> books = library.Books;

            Dictionary<string, DateTime> myDic = new Dictionary<string, DateTime>();
            string inputDate = Console.ReadLine();
            DateTime Date = DateTime.ParseExact(inputDate, "d.M.yyyy", CultureInfo.InvariantCulture);

            foreach (var item in books)
            {
                if (!myDic.ContainsKey(item.Title))
                {
                    myDic.Add(item.Title, item.ReleaseDate);
                }
                else
                {
                    myDic[item.Title] = item.ReleaseDate;
                }
            }
            foreach (var item in myDic.Where(x => x.Value > Date).OrderBy(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine("{0} -> {1:d.MM.yyyy}", item.Key, item.Value);
            }

        }
        static Book ReadBook(string[] args)
        {
            Book book = new Book();
            
            book.Title = args[0];
            book.ReleaseDate = DateTime.ParseExact(args[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            return book;
        }
        static Library ReadAllBooks(int n)
        {
            Library lib = new Library();
            lib.Books = new List<Book>();
            for (int i = 0; i < n; i++)
            {
                string[] arguments = Console.ReadLine().Split(' ').ToArray();
                Book book = ReadBook(arguments);
                lib.Books.Add(book);
            }
            return lib;
        }

    }
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }


    }
    public class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }

    }
}
