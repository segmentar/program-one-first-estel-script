using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal static String[] ProgramFileSetSurface(String[] directoryArray)
        {
            String[] arrayResult = default;

            var list = ProgramFileSet(directoryArray);

            String[] stringArray;

            stringArray = new String[list.Count];

            list.CopyTo(stringArray, 0);

            arrayResult = stringArray;

            return arrayResult;
        }
    }
}
