using Core;

namespace Core
{
    using System;

    using System.Linq;

    using System.Collections;

    internal partial class Program
    {
        internal static T[] ProgramDirectoryNameContainerSurface<T>(String[] directoryArray)
        {
            T[] arrayResult = default;

            var list = ProgramDirectoryNameContainer(directoryArray);

            IEnumerable enumerable;

            enumerable = list.OfType<T>().Cast<T>().ToArray();

            var reflect = (T[])(enumerable as Array);

            arrayResult = reflect;

            return arrayResult;
        }
    }
}
