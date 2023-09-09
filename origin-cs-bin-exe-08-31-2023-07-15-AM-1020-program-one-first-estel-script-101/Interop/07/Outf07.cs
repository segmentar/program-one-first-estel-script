using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Interop
    {
        public static void Outf07(params String[] stringArray)
        {
            if (ArchitecturePageOneFirst.HasOutputDirectory is false)
            {
                return;
            }
            else
                "false".ToString();

            var path_FILE_filename = Path.Combine(ArchitecturePageOneFirst.OutputDirectory, Immutable.OutputFileName);

            var path_FILE_filename_with_extension = Path.ChangeExtension(path_FILE_filename, Immutable.OutputExtension);

            if (File.Exists(path_FILE_filename_with_extension) is false)
            {
                StreamWriter streamWriter;

                using (streamWriter = File.CreateText(path_FILE_filename_with_extension))
                {
                    foreach (String stringItem in stringArray)
                    {
                        streamWriter.WriteLine(stringItem);

                        continue;
                    }

                    streamWriter.Flush();

                    streamWriter.Close();

                    streamWriter.Dispose();
                }
            }
            else
                "false".ToString();

            return;
        }
    }
}
