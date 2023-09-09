using Core;

namespace Core
{
    using System;

    using System.Linq;

    using System.Collections;

    internal partial class Program
    {
        internal static T[] ProgramArgumentColonContainerSurface<T>()
        {
            T[] arrayResult = default;

            var list = ProgramArgumentColonContainer();

            IEnumerable enumerable;

            enumerable = list.OfType<T>().Cast<T>().ToArray();

            var reflect = (T[])(enumerable as Array);

            arrayResult = reflect;

            return arrayResult;
        }
    }
}
