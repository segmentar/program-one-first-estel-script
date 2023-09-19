using Core;

namespace Core
{
    using System;

    using System.Linq;

    using System.Collections;

    internal partial class Program
    {
        internal static T[] ProgramSettingTupleContainerSurface<T>(String text)
        {
            T[] arrayResult = default;

            var list = ProgramSettingTupleContainer(text);

            IEnumerable enumrable;

            enumrable = list.OfType<T>().Cast<T>().ToArray();

            var reflect = (T[])(enumrable as Array);

            T[] array;

            array = reflect;

            arrayResult = array;

            return arrayResult;
        }
    }
}
