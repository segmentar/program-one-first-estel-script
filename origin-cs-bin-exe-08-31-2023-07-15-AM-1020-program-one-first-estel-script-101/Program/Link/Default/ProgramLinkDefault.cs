using Core;

namespace Core
{
    using System;

    using System.Collections;

    internal partial class ProgramDefaultPageOneFirst
    {
        internal static ConsoleColor BackgroundColorDefault;

        internal static ConsoleColor ForegroundColorDefault;

        internal static Boolean IsExternalCallDefault;

        internal static ArrayList ArgumentListDefault;

        internal static Boolean HasEscapeCharacterDefault;

        internal static Char EscapeCharacterDefault;

        internal static Boolean HasOutputDirectoryDefault;

        internal static String OutputDirectoryDefault;

        static ProgramDefaultPageOneFirst()
        {
            BackgroundColorDefault = ConsoleColor.Blue;

            ForegroundColorDefault = ConsoleColor.Yellow;

            IsExternalCallDefault = default(Boolean);

            ArgumentListDefault = default(ArrayList);

            HasEscapeCharacterDefault = default(Boolean);

            EscapeCharacterDefault = default(Char);

            HasOutputDirectoryDefault = default(Boolean);

            OutputDirectoryDefault = default(String);

            return;
        }
    }
}

namespace Core
{
    using System;

    using System.IO;

    using System.Text;

    using System.Reflection;

    internal partial class ProgramDefaultPageTwoSecond
    {
        internal static String ProgramNameDefault;

        internal static String WorkingDirectoryNameDefault;

        internal static String WorkingDirectoryIdentityDefault;

        internal static String OutputFileNameDefault;

        internal static String OutputExtensionDefault;

        internal static Boolean EndianFormatDefault;

        internal static Encoding StringCodecDefault;

        internal static String ExtensionNameDefault;

        internal static Int32 ChunkSizeDefault;

        internal static Int32 StartBoundaryDefault;

        internal static String FullExtensionDefault;

        static ProgramDefaultPageTwoSecond()
        {
            ProgramNameDefault = Assembly.GetEntryAssembly().GetName().Name;

            WorkingDirectoryNameDefault = "Working Directory";

            WorkingDirectoryIdentityDefault = Path.GetRandomFileName();

            OutputFileNameDefault = "Output";

            OutputExtensionDefault = "package";

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