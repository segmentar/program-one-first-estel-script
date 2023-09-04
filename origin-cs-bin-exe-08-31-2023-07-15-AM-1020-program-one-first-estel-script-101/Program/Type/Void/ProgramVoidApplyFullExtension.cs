using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal static void ApplyFullExtensionVoid()
        {
            String stringItem;

            stringItem = $"{Architecture.ExtensionName}_{Architecture.EndianFormat}_{Architecture.StringCodec.CodePage}_{Architecture.ChunkSize}_{Architecture.StartBoundary}";

            Architecture.FullExtension = stringItem;

            return;
        }
    }
}
