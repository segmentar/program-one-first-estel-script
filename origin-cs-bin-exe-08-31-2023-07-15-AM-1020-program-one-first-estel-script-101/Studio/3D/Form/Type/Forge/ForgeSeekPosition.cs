using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Form
    {
        public static Int32 ForgeSeekPositionAdvance(Stream stream, Int32 ordinal)
        {
            Int32 integerResult = default;

            var indexer = (ordinal - 1);

            var chunk = (ArchitecturePageTwoSecond.ChunkSize * indexer);

            stream.Seek(chunk, SeekOrigin.Begin);

            ordinal = ordinal + 1;

            integerResult = ordinal;

            return integerResult;
        }
    }
}
