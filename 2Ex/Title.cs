using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Ex
{
    internal class Title
    {
        private string text;

        public Title(string text)
        {
            this.Text = text;
        }

        public string Text { get => text; set => text = value; }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Название книги: " + Text);
            Console.ResetColor();
        }
    }
}
