using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Ex
{
    internal class Author
    {
        private string name;

        public Author(string name)
        {
            this.Name = name;
        }

        public string Name { get => name; set => name = value; }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Автор: " + Name);
            Console.ResetColor();
        }
    }
}
