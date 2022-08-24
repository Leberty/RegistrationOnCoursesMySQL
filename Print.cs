using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationOnCourses
{
    public class Print
    {
        private string head;

        public Print(string head) => this.head = head;

        public void PrintHead()
        {
            int centerX = (Console.WindowWidth / 2) - (head.Length / 2);
            int y = 5;
            Console.SetCursorPosition(centerX, y);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("***************************");
            Console.SetCursorPosition(centerX, ++y);
            Console.WriteLine(head);
            Console.SetCursorPosition(centerX, ++y);
            Console.WriteLine("                           ");
            Console.SetCursorPosition(centerX, ++y);
            Console.WriteLine("***************************");
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
