using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal void ConsoleReposition(Boolean reset)
        {
            if (reset)
            {
                Console.CursorLeft = 0;

                Console.CursorTop = 0;

                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
            }
            else
            {
                Console.CursorLeft = 16;

                Console.CursorTop = 25;

                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
            }

            return;
        }
    }
}
