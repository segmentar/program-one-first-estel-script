using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal static Boolean ConsoleEscape(String value)
        {
            Boolean booleanResult = default;

            var lower = value.ToLower();

            Boolean boolean;

            boolean = (lower == "escape") is true;

            booleanResult = boolean;

            return booleanResult;
        }
    }
}
