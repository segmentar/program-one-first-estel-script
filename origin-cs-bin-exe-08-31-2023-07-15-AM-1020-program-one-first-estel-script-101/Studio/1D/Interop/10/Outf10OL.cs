using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Interop
    {
        public static void Outf10OL(params String[] array_FILENAME)
        {
            if (ArchitecturePageOneFirst.HasOutputDirectory is false)
            {
                return;
            }
            else
                "false".ToString();

            var path_FILE_filename = Path.Combine(ArchitecturePageOneFirst.OutputDirectory, ImmutablePageOneFirst.OutputFileName);

            var path_FILE_filename_with_extension = Path.ChangeExtension(path_FILE_filename, ImmutablePageOneFirst.OutputExtension);

            if (File.Exists(path_FILE_filename_with_extension) is false)
            {
                StreamWriter streamWriter;

                using (streamWriter = File.CreateText(path_FILE_filename_with_extension))
                {
                    foreach (var item_FILENAME in array_FILENAME)
                    {
                        streamWriter.WriteLine(item_FILENAME);

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
