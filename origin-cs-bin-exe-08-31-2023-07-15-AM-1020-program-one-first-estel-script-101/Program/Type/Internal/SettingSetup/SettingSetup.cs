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
            var path_FILE_filename = Path.Combine(Directory.GetCurrentDirectory(), "Setting");

            var path_FILE_filename_with_extension = Path.ChangeExtension(path_FILE_filename, "txt");

            if (File.Exists(path_FILE_filename_with_extension) is false)
            {
                return;
            }
            else
                "false".ToString();

            var text = File.ReadAllText(path_FILE_filename_with_extension);

            var linefeed = Convert.ToChar(10);

            var split_U = text.Split(new String[] { linefeed.ToString() }, StringSplitOptions.None);

            foreach (String stringItem in split_U)
            {
                var split_V = stringItem.Split();

                Boolean hasLength;

                hasLength = (split_V.Length > 0) is true;

                if (hasLength is false)
                {
                    continue;
                }
                else
                    "false".ToString();

                var eoth = (split_V.Length - 1);

                var first = split_V[0];

                var last = split_V[eoth];

                Boolean 
                    isExtension,
                    isEndianFormat,
                    isStringCodec,
                    isChunkSize,
                    isStartBoundary
                    ;

                isExtension = (first == nameof(ArchitecturePageTwoSecond.ExtensionName)) is true;

                isEndianFormat = (first == nameof(ArchitecturePageTwoSecond.EndianFormat)) is true;

                isStringCodec = (first == nameof(ArchitecturePageTwoSecond.StringCodec)) is true;

                isChunkSize = (first == nameof(ArchitecturePageTwoSecond.ChunkSize)) is true;

                isStartBoundary = (first == nameof(ArchitecturePageTwoSecond.StartBoundary)) is true;

                if (isExtension is true)
                {
                    ArchitecturePageTwoSecond.ExtensionName = last;
                }
                else
                    "false".ToString();

                if (isEndianFormat is true)
                {
                    Boolean boolean;

                    boolean = Boolean.Parse(last);

                    ArchitecturePageTwoSecond.EndianFormat = boolean;
                }
                else
                    "false".ToString();

                if (isStringCodec is true)
                {
                    Int32 integer;

                    integer = Int32.Parse(last);

                    ArchitecturePageTwoSecond.StringCodec = Encoding.GetEncoding(integer);
                }
                else
                    "false".ToString();

                if (isChunkSize is true)
                {
                    Int32 integer;

                    integer = Int32.Parse(last);

                    ArchitecturePageTwoSecond.ChunkSize = integer;
                }
                else
                    "false".ToString();

                if (isStartBoundary is true)
                {
                    Int32 integer;

                    integer = Int32.Parse(last);

                    ArchitecturePageTwoSecond.StartBoundary = integer;
                }
                else
                    "false".ToString();

                continue;
            }

            return;
        }
    }
}
