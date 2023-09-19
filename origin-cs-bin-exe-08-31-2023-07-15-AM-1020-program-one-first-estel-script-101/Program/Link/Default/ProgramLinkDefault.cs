using Core;

namespace Core
{
    using System;

    using System.Collections;

    internal partial class ProgramDefaultArchitecturePageOneFirst
    {
        internal static Boolean HasArgumentLengthDefault;

        internal static Boolean HasLingerDefault;

        internal static Boolean IsExternalCallDefault;

        internal static ArrayList ArgumentListDefault;

        internal static Boolean HasEscapeCharacterDefault;

        internal static Char EscapeCharacterDefault;

        internal static Boolean HasInputDirectoryDefault;

        internal static Boolean HasOutputDirectoryDefault;

        internal static String InputDirectoryDefault;

        internal static String OutputDirectoryDefault;

        internal static String SettingNameDefault;

        internal static String SettingExtensionDefault;

        static ProgramDefaultArchitecturePageOneFirst()
        {
            HasArgumentLengthDefault = default(Boolean);

            HasLingerDefault = default(Boolean);

            IsExternalCallDefault = default(Boolean);

            ArgumentListDefault = default(ArrayList);

            HasEscapeCharacterDefault = default(Boolean);

            EscapeCharacterDefault = default(Char);

            HasInputDirectoryDefault = default(Boolean);

            HasOutputDirectoryDefault = default(Boolean);

            InputDirectoryDefault = default(String);

            OutputDirectoryDefault = default(String);

            SettingNameDefault = "Setting";

            SettingExtensionDefault = "txt";

            return;
        }
    }
}

namespace Core
{
    using System;

    using System.Text;

    internal partial class ProgramDefaultArchitecturePageTwoSecond
    {
        internal static Boolean EndianFormatDefault;

        internal static Encoding StringCodecDefault;

        internal static String ExtensionNameDefault;

        internal static Int32 ChunkSizeDefault;

        internal static Int32 StartBoundaryDefault;

        internal static String FullExtensionDefault;

        static ProgramDefaultArchitecturePageTwoSecond()
        {
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

namespace Core
{
    using System;

    using System.IO;

    using System.Reflection;

    internal static class ProgramDefaultImmutablePageOneFirst
    {
        internal static String TitleDefault;

        internal static ConsoleColor BackgroundColorDefault;

        internal static ConsoleColor ForegroundColorDefault;

        internal static String ProgramNameDefault;

        internal static String WorkingDirectoryNameDefault;

        internal static String WorkingDirectoryIdentityDefault;

        internal static String ExplorerNameDefault;

        internal static String OutputFileNameDefault;

        internal static String OutputExtensionDefault;

        internal static String SpecialErrorDefault;

        static ProgramDefaultImmutablePageOneFirst()
        {
            TitleDefault = Assembly.GetEntryAssembly().GetName().Name;

            BackgroundColorDefault = ConsoleColor.Blue;

            ForegroundColorDefault = ConsoleColor.Yellow;

            ProgramNameDefault = Assembly.GetEntryAssembly().GetName().Name;

            WorkingDirectoryNameDefault = "Working Directory";

            WorkingDirectoryIdentityDefault = Path.GetRandomFileName();

            ExplorerNameDefault = "Explorer";

            OutputFileNameDefault = "Output";

            OutputExtensionDefault = "package";

            SpecialErrorDefault = "This object just so happened to be a default" + ' ' + '.' + ' ' + ":(";

            return;
        }
    }
}