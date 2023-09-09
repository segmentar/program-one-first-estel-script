using Core;

namespace Core
{
    using System;

    using System.Collections;

    internal static class ArchitecturePageOneFirst
    {
        internal static ConsoleColor BackgroundColor;

        internal static ConsoleColor ForegroundColor;

        internal static Boolean IsExternalCall;

        internal static ArrayList ArgumentList;

        internal static Boolean HasEscapeCharacter;

        internal static Char EscapeCharacter;

        internal static Boolean HasOutputDirectory;

        internal static String OutputDirectory;

        static ArchitecturePageOneFirst()
        {
            BackgroundColor = ProgramDefaultPageOneFirst.BackgroundColorDefault;

            ForegroundColor = ProgramDefaultPageOneFirst.ForegroundColorDefault;

            IsExternalCall = ProgramDefaultPageOneFirst.IsExternalCallDefault;

            ArgumentList = ProgramDefaultPageOneFirst.ArgumentListDefault;

            HasEscapeCharacter = ProgramDefaultPageOneFirst.HasEscapeCharacterDefault;

            EscapeCharacter = ProgramDefaultPageOneFirst.EscapeCharacterDefault;

            HasOutputDirectory = ProgramDefaultPageOneFirst.HasOutputDirectoryDefault;

            OutputDirectory = ProgramDefaultPageOneFirst.OutputDirectoryDefault;

            return;
        }
    }
}

namespace Core
{
    using System;

    using System.Text;

    internal static class ArchitecturePageTwoSecond
    {
        internal static String ExtensionName;

        internal static Boolean EndianFormat;

        internal static Encoding StringCodec;

        internal static Int32 ChunkSize;

        internal static Int32 StartBoundary;

        internal static String FullExtension;

        static ArchitecturePageTwoSecond()
        {
            ExtensionName = ProgramDefaultPageTwoSecond.ExtensionNameDefault;

            EndianFormat = ProgramDefaultPageTwoSecond.EndianFormatDefault;

            StringCodec = ProgramDefaultPageTwoSecond.StringCodecDefault;

            ChunkSize = ProgramDefaultPageTwoSecond.ChunkSizeDefault;

            StartBoundary = ProgramDefaultPageTwoSecond.StartBoundaryDefault;

            FullExtension = ProgramDefaultPageTwoSecond.FullExtensionDefault;

            return;
        }
    }
}

