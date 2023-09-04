using Core;

namespace Core
{
    using System;

    using System.Text;

    internal static class Architecture
    {
        internal static String ExtensionName = ProgramImmutable.ExtensionNameDefault;

        internal static Boolean EndianFormat = ProgramImmutable.EndianFormatDefault;

        internal static Encoding StringCodec = ProgramImmutable.StringCodecDefault;

        internal static Int32 ChunkSize = 64;//ProgramImmutable.ChunkSizeDefault;

        internal static Int32 StartBoundary = ProgramImmutable.StartBoundaryDefault;

        internal static String FullExtension = ProgramImmutable.FullExtensionDefault;
    }
}
