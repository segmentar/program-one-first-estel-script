using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal static String[] ProgramDirectorySetSurface(String directory)
        {
            String[] arrayResult = default;

            var list = ProgramDirectorySet(directory);

            String[] stringArray;

            stringArray = new String[list.Count];

            list.CopyTo(stringArray, 0);

            arrayResult = stringArray;

            return arrayResult;
        }
    }
}
