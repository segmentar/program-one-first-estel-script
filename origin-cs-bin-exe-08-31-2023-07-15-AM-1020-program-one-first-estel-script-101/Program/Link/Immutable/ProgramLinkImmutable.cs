using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Text;

    using System.Reflection;

    internal partial class ProgramImmutable
    {
        internal static readonly String ProgramName;

        internal static readonly String WorkingDirectoryName;

        internal static readonly String WorkingDirectoryIdentifier;

        internal static readonly Boolean EndianFormatDefault;

        internal static readonly Encoding StringCodecDefault;

        internal static readonly String ExtensionNameDefault;

        internal static readonly Int32 ChunkSizeDefault;

        internal static readonly Int32 StartBoundaryDefault;

        internal static readonly String FullExtensionDefault;

        static ProgramImmutable()
        {
            ProgramName = Assembly.GetEntryAssembly().GetName().Name;

            WorkingDirectoryName = "Working Directory";

            WorkingDirectoryIdentifier = Path.GetRandomFileName();

            EndianFormatDefault = BitConverter.IsLittleEndian;

            StringCodecDefault = Encoding.Default;

            ExtensionNameDefault = "Example";

            ChunkSizeDefault = 512;

            StartBoundaryDefault = 128;

            FullExtensionDefault = String.Empty;

            return;
        }
    }
}
