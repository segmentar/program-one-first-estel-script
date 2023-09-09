using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal void ConsoleReposition(Boolean reset, Boolean hide, Boolean clear)
        {
            if (reset)
            {
                Console.CursorLeft = 0;

                Console.CursorTop = 0;

                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
            }
            else
            {
                Int32 left, top, size;

                left = 16;

                top = 31;

                size = (left * top);

                Int32 bufferSize, windowSize;

                bufferSize = (Console.BufferWidth * Console.BufferHeight);

                windowSize = (Console.WindowWidth * Console.WindowHeight);

                var boolean_EXCEED_INVALID_is = false;

                boolean_EXCEED_INVALID_is = boolean_EXCEED_INVALID_is || (left < 0) is true;

                boolean_EXCEED_INVALID_is = boolean_EXCEED_INVALID_is || (top < 0) is true;

                boolean_EXCEED_INVALID_is = boolean_EXCEED_INVALID_is || (size < 0) is true;

                var boolean_EXCEED_BUFFER_is = false;

                boolean_EXCEED_BUFFER_is = boolean_EXCEED_BUFFER_is || (size >= bufferSize) is true;

                boolean_EXCEED_BUFFER_is = boolean_EXCEED_BUFFER_is || (left >= Console.BufferWidth) is true;

                boolean_EXCEED_BUFFER_is = boolean_EXCEED_BUFFER_is || (top >= Console.BufferHeight) is true;

                var boolean_EXCEED_WINDOW_is = false;

                boolean_EXCEED_WINDOW_is = boolean_EXCEED_WINDOW_is || (size >= windowSize) is true;

                boolean_EXCEED_WINDOW_is = boolean_EXCEED_WINDOW_is || (left >= Console.WindowWidth) is true;

                boolean_EXCEED_WINDOW_is = boolean_EXCEED_WINDOW_is || (top >= Console.WindowHeight) is true;

                Boolean isExceed;

                isExceed = false;

                isExceed = isExceed || boolean_EXCEED_INVALID_is is true;

                isExceed = isExceed || boolean_EXCEED_BUFFER_is is true;

                isExceed = isExceed || boolean_EXCEED_WINDOW_is is true;

                if (isExceed)
                {
                    Console.BackgroundColor = ConsoleColor.Red;

                    Console.ForegroundColor = ConsoleColor.DarkRed;

                    Console.Clear();

                    return;
                }
                else
                {
                    Console.BackgroundColor = ArchitecturePageOneFirst.BackgroundColor;

                    Console.ForegroundColor = ArchitecturePageOneFirst.ForegroundColor;
                }

                Console.CursorLeft = left;

                Console.CursorTop = top;

                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
            }

            if (hide)
            {
                Console.CursorVisible = false;
            }
            else
            {
                Console.CursorVisible = true;
            }

            if (clear is true)
            {
                Console.Clear();
            }
            else
                "false".ToString();

            return;
        }
    }
}
