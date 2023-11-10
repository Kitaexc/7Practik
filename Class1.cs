using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertor_0_0
{
    internal class Variants
    {
        public int MinPosition;
        public int MaxPosition;
        public int Vibor()
        {
            Console.CursorVisible = false;
            int position = 1;
            ConsoleKeyInfo key;

            do
            {
                Console.SetCursorPosition(0, position);
                Console.WriteLine("=>");

                key = Console.ReadKey();

                Console.SetCursorPosition(0, position);
                Console.WriteLine("  ");

                if (key.Key == ConsoleKey.UpArrow && position != MinPosition)
                    position--;
                else if (key.Key == ConsoleKey.DownArrow && position != MaxPosition)
                    position++;
            }
            while (key.Key != ConsoleKey.Enter);

            return position;
        }
    }
}
