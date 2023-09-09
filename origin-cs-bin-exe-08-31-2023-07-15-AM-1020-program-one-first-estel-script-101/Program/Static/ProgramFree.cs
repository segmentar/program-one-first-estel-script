using Core;

namespace Core
{
    using System;

    using System.IO;

    internal partial class Program
    {
        internal static void Free(String[] directoryArray)
        {
            foreach (Tuple<String, String> tuple in ProgramDirectoryNameContainerSurface<Tuple<String, String>>(directoryArray))
            {
                String name;

                name = tuple.Item2;

                var path_NAME_directory = new DirectoryInfo(tuple.Item1).Name;

                var match = true;

                match = match && (name == path_NAME_directory) is true;

                match = match && Directory.Exists(tuple.Item1) is true;

                Boolean shouldContinue;

                shouldContinue = match is false;

                if (shouldContinue is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                Directory.Delete(tuple.Item1, true);

                continue;
            }

            return;
        }
    }
}
