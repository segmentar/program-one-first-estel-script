using Core;

namespace Core
{
    using System;

    using System.Text;

    public partial class Interop
    {
        public static void Finf08IL()
        {
            foreach (Tuple<String, String> tuple in Program.ProgramColonNameValueContainerSurface<Tuple<String, String>>())
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
