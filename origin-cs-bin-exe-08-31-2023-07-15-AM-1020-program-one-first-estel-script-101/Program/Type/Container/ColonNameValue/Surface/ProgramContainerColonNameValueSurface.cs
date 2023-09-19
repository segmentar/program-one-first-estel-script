using Core;

namespace Core
{
    using System;

    using System.Linq;

    using System.Collections;

    internal partial class Program
    {
        internal static T[] ProgramColonNameValueContainerSurface<T>()
        {
            T[] arrayResult = default;

            var list = ProgramColonNameValueContainer();

            IEnumerable enumerable;

            enumerable = list.OfType<T>().Cast<T>().ToArray();

            var reflect = (T[])(enumerable as Array);

            T[] array;

            array = reflect;

            arrayResult = array;

            return arrayResult;
        }
    }
}
