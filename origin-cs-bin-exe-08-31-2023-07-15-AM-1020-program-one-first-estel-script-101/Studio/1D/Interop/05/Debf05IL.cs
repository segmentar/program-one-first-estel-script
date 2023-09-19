using Core;

namespace Core
{
    using System;

    public partial class Interop
    {
        public static void Debf05IL()
        {
            if (ArchitecturePageOneFirst.ArgumentList.Contains("display-argument") is false)
            {
                return;
            }
            else
                "false".ToString();

            var comma = Convert.ToChar(44);

            var descriptor = String.Join(comma.ToString(), ArchitecturePageOneFirst.ArgumentList.ToArray());

            Console.Clear();

            Console.Out.WriteLine($"{nameof(ArchitecturePageOneFirst.ArgumentList)}: <{descriptor}>");

            Console.In.ReadLine();

            return;
        }
    }
}
