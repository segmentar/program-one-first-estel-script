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
                String directory, name;

                directory = tuple.Item1;

                name = tuple.Item2;

                var path_NAME_directory = new DirectoryInfo(directory).Name;

                var boolean_safe_DIRECTORY_is = true;

                boolean_safe_DIRECTORY_is = boolean_safe_DIRECTORY_is && (name == path_NAME_directory) is true;

                boolean_safe_DIRECTORY_is = boolean_safe_DIRECTORY_is && Directory.Exists(tuple.Item1) is true;

                Boolean isDirectoryCheck, shouldContinue;

                isDirectoryCheck = boolean_safe_DIRECTORY_is is true;

                shouldContinue = isDirectoryCheck is false;

                if (shouldContinue is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                Directory.Delete(directory, true);

                continue;
            }

            return;
        }
    }
}
