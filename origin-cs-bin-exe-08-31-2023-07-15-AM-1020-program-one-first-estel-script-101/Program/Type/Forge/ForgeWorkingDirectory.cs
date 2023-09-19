using Core;

namespace Core
{
    using System;

    using System.IO;

    internal partial class Program
    {
        internal static String ForgeWorkingDirectory(String currentDirectory, Boolean shouldCreate)
        {
            String stringResult = default;

            var path_NAME = ForgeWorkingDirectoryName();

            var path_DIRECTORY_full_name = Path.Combine(currentDirectory, path_NAME);

            var boolean_match_CREATE_should = true;

            boolean_match_CREATE_should = boolean_match_CREATE_should && shouldCreate is true;

            boolean_match_CREATE_should = boolean_match_CREATE_should && Directory.Exists(path_DIRECTORY_full_name) is false;

            Boolean shouldCreateCheck;

            shouldCreateCheck = boolean_match_CREATE_should is true;

            if (shouldCreateCheck is true)
            {
                DirectoryInfo directoryInfo;

                directoryInfo = Directory.CreateDirectory(path_DIRECTORY_full_name);

                path_DIRECTORY_full_name = directoryInfo.FullName;
            }
            else
                "false".ToString();

            var result = path_DIRECTORY_full_name;

            stringResult = result;

            return stringResult;
        }
    }
}
