using Core;

namespace Core
{
    using System;

    using System.IO;

    internal partial class Program
    {
        internal static void Render(String name, params Object[] objectArray)
        {
            var dash = Convert.ToChar(45);

            var split = name.Split(new String[] { dash.ToString() }, StringSplitOptions.None);

            var path_NAME_directory = String.Empty;

            foreach (String stringItem in split)
            {
                path_NAME_directory = Path.Combine(path_NAME_directory, stringItem);

                continue;
            }

            path_NAME_directory = path_NAME_directory + ' ' + objectArray.Length;

            var path_DIRECTORY_full_name = Path.Combine(Directory.GetCurrentDirectory(), path_NAME_directory);

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

                var ordinal = (zeroth + 1);

                String stringItem;

                if (objectItem == default)
                {
                    stringItem = "This object just so happened to be a default" + ' ' + '.' + ' ' + ":(";
                }
                else
                {
                    stringItem = objectItem.ToString();
                }

                var path_NAME_file = $"{name}-{ordinal}-{objectArray.Length}";

                var path_FILE_filename = Path.Combine(path_DIRECTORY_full_name, path_NAME_file);

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
