using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        private void ConsoleSetupOneFirst()
        {
            Console.Title = ProgramDefaultPageTwoSecond.ProgramNameDefault;

            Console.BackgroundColor = ConsoleColor.Blue;

            Console.ForegroundColor = ConsoleColor.Yellow;

            ConsoleReposition(true, true, true);

            return;
        }
    }
}
