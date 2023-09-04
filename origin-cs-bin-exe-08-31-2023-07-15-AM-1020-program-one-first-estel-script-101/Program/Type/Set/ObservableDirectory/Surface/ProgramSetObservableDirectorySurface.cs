using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal static String[] ProgramObservableDirectorySetSurface()
        {
            String[] arrayResult = default;

            var list = ProgramObservableDirectorySet();

            String[] stringArray;

            stringArray = new String[list.Count];

            list.CopyTo(stringArray, 0);

            arrayResult = stringArray;

            return arrayResult;
        }
    }
}