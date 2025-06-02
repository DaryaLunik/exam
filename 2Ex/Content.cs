using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Ex
{
    internal class Content
    {
        private string body;

        public Content(string body)
        {
            this.Body = body;
        }

        public string Body { get => body; set => body = value; }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Содержание: " + Body);
            Console.ResetColor();
        }
    }
}
