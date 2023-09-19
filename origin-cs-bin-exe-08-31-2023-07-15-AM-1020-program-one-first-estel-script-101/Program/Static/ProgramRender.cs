using Core;

namespace Core
{
    using System;

    using System.IO;

    internal partial class Program
    {
        internal static void Render(String name, params Object[] objectArray)
        {
            name = RenderSpecialName(name);

            var path_DIRECTORY_full_name = Path.Combine(Directory.GetCurrentDirectory(), RenderDirectoryName(name, objectArray.Length));

            if (Directory.Exists(path_DIRECTORY_full_name) is false)
            {
                DirectoryInfo directoryInfo;

                directoryInfo = Directory.CreateDirectory(path_DIRECTORY_full_name);

                path_DIRECTORY_full_name = directoryInfo.FullName;
            }
            else
                "false".ToString();

            var zeroth = -1;

            foreach (Object objectItem in objectArray)
            {
                zeroth = zeroth + 1;

                String stringItem;

                var boolean_contagious_DEFAULT_is = (objectItem == default);

                Boolean isDefaultCheck;

                isDefaultCheck = boolean_contagious_DEFAULT_is is true;

                if (isDefaultCheck)
                {
                    stringItem = ImmutablePageOneFirst.SpecialError;
                }
                else
                {
                    stringItem = objectItem.ToString();
                }

                var ordinal = (zeroth + 1);

                var path_FILE_filename = Path.Combine(path_DIRECTORY_full_name, RenderFileName(name, ordinal, objectArray.Length));

                var path_FILE_filename_with_extension = Path.ChangeExtension(path_FILE_filename, "txt");

                if (File.Exists(path_FILE_filename_with_extension) is false)
                {
                    StreamWriter streamWriter;

                    using (streamWriter = File.CreateText(path_FILE_filename_with_extension))
                    {
                        streamWriter.Write(stringItem);

                        streamWriter.Flush();

                        streamWriter.Close();

                        streamWriter.Dispose();
                    }
                }
                else
                    "false".ToString();

                continue;
            }

            return;
        }

    }
}
