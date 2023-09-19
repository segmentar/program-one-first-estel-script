using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Text;

    internal partial class Program
    {
        internal void SettingSetup()
        {
            var path_FILE_filename = Path.Combine(Directory.GetCurrentDirectory(), ImmutablePageOneFirst.SettingName);

            var path_FILE_filename_with_extension = Path.ChangeExtension(path_FILE_filename, ImmutablePageOneFirst.SettingExtension);

            if (File.Exists(path_FILE_filename_with_extension) is false)
            {
                return;
            }
            else
                "false".ToString();

            var text = File.ReadAllText(path_FILE_filename_with_extension);

            foreach (Tuple<String, String> tuple in ProgramSettingTupleContainerSurface<Tuple<String, String>>(text))
            {
                String name, value;

                name = tuple.Item1;

                value = tuple.Item2;

                var reflect_BOOLEAN = default(Boolean);

                var reflect_INTEGER = default(Int32);

                try
                {
                    reflect_BOOLEAN = Boolean.Parse(value);
                }
                catch (Exception exception)
                {
                    exception.ToString();
                }

                try
                {
                    reflect_INTEGER = Int32.Parse(value);
                }
                catch (Exception exception)
                {
                    exception.ToString();
                }

                switch (name)
                {
                    case nameof(ArchitecturePageOneFirst.InputDirectory):
                        Specialize.SetInputDirectory(value, true);
                        break;

                    case nameof(ArchitecturePageOneFirst.OutputDirectory):
                        Specialize.SetOutputDirectory(value, true);
                        break;

                    case nameof(ArchitecturePageTwoSecond.ExtensionName):
                        ArchitecturePageTwoSecond.ExtensionName = value;
                        break;

                    case nameof(ArchitecturePageTwoSecond.EndianFormat):
                        ArchitecturePageTwoSecond.EndianFormat = reflect_BOOLEAN;
                        break;

                    case nameof(ArchitecturePageTwoSecond.StringCodec):
                        ArchitecturePageTwoSecond.StringCodec = Encoding.GetEncoding(reflect_INTEGER);
                        break;

                    case nameof(ArchitecturePageTwoSecond.ChunkSize):
                        ArchitecturePageTwoSecond.ChunkSize = reflect_INTEGER;
                        break;

                    case nameof(ArchitecturePageTwoSecond.StartBoundary):
                        ArchitecturePageTwoSecond.StartBoundary = reflect_INTEGER;
                        break;

                    default:
                        break;
                }

                continue;
            }

            return;
        }
    }
}
