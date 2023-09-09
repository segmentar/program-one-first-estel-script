using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        private void ConsoleSetupTwoSecond()
        {
            do
            {
                Console.Clear();

                Console.Out.WriteLine(ConsoleDescriptor());

                ConsoleReposition(false, false, false);

                var line = Console.In.ReadLine();

                var lower = line.ToLower();

                var split = line.Split();

                Boolean hasLength;

                hasLength = (split.Length > 0) is true;

                ConsoleSetupThreeThird(lower, split, hasLength);

                Boolean isEscape;

                isEscape = (lower is "escape") is true;

                if (isEscape is true)
                {
                    ConsoleReposition(true, true, true);

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
