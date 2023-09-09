using Core;

namespace Core
{
    using System;

    using System.Text;

    public partial class Interop
    {
        public static void Finf05()
        {
            foreach (Tuple<String, String> tuple in Program.ProgramArgumentColonContainerSurface<Tuple<String, String>>())
            {
                String stringItem;

                stringItem = tuple.Item2;

                var reflect_BOOLEAN = default(Boolean);

                var reflect_INTEGER = default(Int32);

                try
                {
                    reflect_BOOLEAN = Boolean.Parse(stringItem);

                }
                catch (Exception exception)
                {
                    exception.ToString();
                }

                try
                {
                    reflect_INTEGER = Int32.Parse(stringItem);
                }
                catch (Exception exception)
                {
                    exception.ToString();
                }

                switch (tuple.Item1)
                {
                    case nameof(ArchitecturePageOneFirst.OutputDirectory):
                        ArchitecturePageOneFirst.OutputDirectory = stringItem;
                        ArchitecturePageOneFirst.HasOutputDirectory = true;
                        break;

                    case nameof(ArchitecturePageTwoSecond.ExtensionName):
                        ArchitecturePageTwoSecond.ExtensionName = stringItem;
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
