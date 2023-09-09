using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal static String RenderDefaultName()
        {
            String stringResult = default;

            stringResult = "This object just so happened to be a default" + ' ' + '.' + ' ' + ":(";

            return stringResult;
        }
    }
}
