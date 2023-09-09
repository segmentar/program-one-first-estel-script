using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal static void ProgramApplyFullExtensionVoid()
        {
            String stringItem;

            stringItem = $"{ArchitecturePageTwoSecond.ExtensionName}_{ArchitecturePageTwoSecond.EndianFormat}_{ArchitecturePageTwoSecond.StringCodec.CodePage}_{ArchitecturePageTwoSecond.ChunkSize}_{ArchitecturePageTwoSecond.StartBoundary}";

            ArchitecturePageTwoSecond.FullExtension = stringItem;

            return;
        }
    }
}
