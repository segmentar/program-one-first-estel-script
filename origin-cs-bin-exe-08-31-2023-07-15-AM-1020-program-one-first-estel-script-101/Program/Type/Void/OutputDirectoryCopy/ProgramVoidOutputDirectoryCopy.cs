using Core;

namespace Core
{
    using System;

    using System.IO;

    internal partial class Program
    {
        internal static void ProgramOutputDirectoryCopyVoid(String workingDirectory)
        {
            if (ArchitecturePageOneFirst.HasOutputDirectory is false)
            {
                return;
            }
            else
                "false".ToString();

            foreach (String file in Directory.GetFiles(workingDirectory))
            {
                var path_NAME_file = Path.GetFileName(file);

                var path_FILE_filename_with_extension = Path.Combine(ArchitecturePageOneFirst.OutputDirectory, path_NAME_file);

                File.Copy(file, path_FILE_filename_with_extension, true);

                continue;
            }
            
            return;
        }
    } 
}
