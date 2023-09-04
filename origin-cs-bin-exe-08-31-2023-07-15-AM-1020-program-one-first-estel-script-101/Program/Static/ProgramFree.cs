using Core;

namespace Core
{
    using System;

    using System.IO;

    internal partial class Program
    {
        internal static void Free()
        {
            foreach (String stringItem in ProgramObservableDirectorySetSurface())
            {
                if (Directory.Exists(stringItem) is false)
                {
                    continue;
                }
                else
                    "false".ToString();

                Directory.Delete(stringItem, true);

                continue;
            }

            return;
        }
    }
}
