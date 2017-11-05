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

            Dictionary<string, double> myDic = new Dictionary<string, double>();
            
            foreach (var item in books)
            {
                if (!myDic.ContainsKey(item.Author))
                {
                    myDic[item.Author] = 0;
                }
                myDic[item.Author] += item.Price;
            }
            foreach (var item in myDic.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine("{0} -> {1:F2}", item.Key, item.Value);
            }

        }
        static Book ReadBook(string[] args)
        {
            Book book = new Book();

            book.Author = args[1];
            book.Price = double.Parse(args[5]);
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
