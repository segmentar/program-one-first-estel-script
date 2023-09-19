using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal static String RenderFileName(String name, Int32 ordinal, Int32 length)
        {
            String stringResult = default;   

            var path_NAME_file = $"{name}-{ordinal}-{length}";

            var result = path_NAME_file;

            stringResult = result;

            return stringResult;
        }
    }
}
