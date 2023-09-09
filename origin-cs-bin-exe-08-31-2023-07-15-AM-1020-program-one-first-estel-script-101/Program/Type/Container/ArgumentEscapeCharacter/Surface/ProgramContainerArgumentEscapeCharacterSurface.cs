using Core;

namespace Core
{
    using System;

    using System.Linq;

    using System.Collections;

    internal partial class Program
    {
        internal static T[] ProgramArgumentEscapeCharacterContainerSurface<T>()
        {
            T[] arrayResult = default;

            var list = ProgramArgumentEscapeCharacterContainer();

            IEnumerable enumerable;

            enumerable = list.OfType<T>().Cast<T>().ToArray();

            var reflect = (T[])(enumerable as Array);

            arrayResult = reflect;

            return arrayResult;
        }
    }
}
