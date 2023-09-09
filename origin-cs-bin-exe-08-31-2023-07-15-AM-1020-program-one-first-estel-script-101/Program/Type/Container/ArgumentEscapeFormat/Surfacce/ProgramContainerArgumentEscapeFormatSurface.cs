using Core;

namespace Core
{
    using System;

    using System.Linq;

    using System.Collections;

    internal partial class Program
    {
        internal static T[] ProgramArgumentEscapeFormatContainerSurface<T>()
        {
            T[] arrayResult = default;

            var list = ProgramArgumentEscapeFormatContainer();

            IEnumerable enumerable;

            enumerable = list.OfType<T>().Cast<T>().ToArray();

            var reflect = (T[])(enumerable as Array);

            arrayResult = reflect;

            return arrayResult;
        }
    }
}
