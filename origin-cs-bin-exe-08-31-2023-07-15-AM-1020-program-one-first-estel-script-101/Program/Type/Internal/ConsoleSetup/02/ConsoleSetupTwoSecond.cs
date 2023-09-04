using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal void ConsoleSetupTwoSecond()
        {
            do
            {
                Console.Clear();

                Console.Out.WriteLine(ConsoleDescriptor());

                ConsoleReposition(false);

                var line = Console.In.ReadLine();

                ConsoleSplit(line);

                if (ConsoleEscape(line) is true)
                {
                    ConsoleReposition(true);

                    Console.Clear();

                    break;
                }
                else
                    "false".ToString();

                continue;

            } while (true);

            return;
        }
    }
}
