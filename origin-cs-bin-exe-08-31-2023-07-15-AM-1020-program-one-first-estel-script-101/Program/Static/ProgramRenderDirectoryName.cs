using Core;

namespace Core
{
    using System;

    using System.IO;

    internal partial class Program
    {
        internal static String RenderDirectoryName(String name, Int32 length)
        {
            String stringResult = default;

            var dash = Convert.ToChar(45);

            var split = name.Split(new String[] { dash.ToString() }, StringSplitOptions.None);

            var path_NAME_directory = String.Empty;

            foreach (String stringItem in split)
            {
                path_NAME_directory = Path.Combine(path_NAME_directory, stringItem);

                continue;
            }

            path_NAME_directory = path_NAME_directory + ' ' + length;

            var result = path_NAME_directory;

            stringResult = result;

            return stringResult;
        }
    }
}
