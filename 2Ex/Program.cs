using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите название книги: ");
            string title = Console.ReadLine();

            Console.Write("Введите имя автора: ");
            string author = Console.ReadLine();

            Console.Write("Введите содержание книги: ");
            string content = Console.ReadLine();

            Book book = new Book(title, author, content);
            Console.WriteLine("\nИнформация о книге:\n");
            book.Show();

            Console.ReadKey();
        }
    }
}
