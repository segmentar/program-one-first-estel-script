using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal void ConsoleSetupOneFirst()
        {
            ConsoleReposition(true);

            Console.Title = ProgramImmutable.ProgramName;

            Console.BackgroundColor = ConsoleColor.Blue;

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Clear();

            return;
        }
    }
}
