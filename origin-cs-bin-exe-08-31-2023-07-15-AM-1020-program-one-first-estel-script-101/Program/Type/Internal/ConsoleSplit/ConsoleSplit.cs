using Core;

namespace Core
{
    using System;

    using System.Text;

    internal partial class Program
    {
        internal void ConsoleSplit(String value)
        {
            var split = value.Split();

            if ((split.Length == 2) is true)
            {
                var first = split[0];

                var second = split[1];

                Boolean
                    isExtensionName,
                    isEndianFormat,
                    isStringCodec,
                    isChunkSize,
                    isStartBoundary
                    ;

                isExtensionName = (first == nameof(Architecture.ExtensionName)) is true;

                isEndianFormat = (first == nameof(Architecture.EndianFormat)) is true;

                isStringCodec = (first == nameof(Architecture.StringCodec)) is true;

                isChunkSize = (first == nameof(Architecture.ChunkSize)) is true;

                isStartBoundary = (first == nameof(Architecture.StartBoundary)) is true;

                if (isExtensionName is true)
                {
                    Architecture.ExtensionName = second;
                }
                else
                    "false".ToString();

                if (isEndianFormat is true)
                {
                    Architecture.EndianFormat = Boolean.Parse(second);
                }
                else
                    "false".ToString();

                if (isStringCodec is true)
                {
                    Architecture.StringCodec = Encoding.GetEncoding(second);
                }
                else
                    "false".ToString();

                if (isChunkSize is true)
                {
                    Int32 integer;

                    integer  = Int32.Parse(second);

                    Architecture.ChunkSize = integer;
                }
                else
                    "false".ToString();

                if (isStartBoundary is true)
                {
                    Int32 integer;

                    integer = Int32.Parse(second);

                    Architecture.StartBoundary = integer;
                }
                else
                    "false".ToString();
            }
            else
                "false".ToString();

            return;
        }
    }
}
