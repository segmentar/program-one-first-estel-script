using Core;

namespace Core
{
    using System;

    using System.Collections;

    internal static class ArchitecturePageOneFirst
    {
        internal static Boolean HasArgumentLength;

        internal static Boolean HasLinger;

        internal static Boolean IsExternalCall;

        internal static ArrayList ArgumentList;

        internal static Boolean HasEscapeCharacter;

        internal static Char EscapeCharacter;

        internal static Boolean HasInputDirectory;

        internal static Boolean HasOutputDirectory;

        internal static String InputDirectory;

        internal static String OutputDirectory;

        static ArchitecturePageOneFirst()
        {
            HasArgumentLength = ProgramDefaultArchitecturePageOneFirst.HasArgumentLengthDefault;

            HasLinger = ProgramDefaultArchitecturePageOneFirst.HasLingerDefault;

            IsExternalCall = ProgramDefaultArchitecturePageOneFirst.IsExternalCallDefault;

            ArgumentList = ProgramDefaultArchitecturePageOneFirst.ArgumentListDefault;

            HasEscapeCharacter = ProgramDefaultArchitecturePageOneFirst.HasEscapeCharacterDefault;

            EscapeCharacter = ProgramDefaultArchitecturePageOneFirst.EscapeCharacterDefault;

            HasInputDirectory = ProgramDefaultArchitecturePageOneFirst.HasInputDirectoryDefault;

            HasOutputDirectory = ProgramDefaultArchitecturePageOneFirst.HasOutputDirectoryDefault;

            InputDirectory = ProgramDefaultArchitecturePageOneFirst.InputDirectoryDefault;

            OutputDirectory = ProgramDefaultArchitecturePageOneFirst.OutputDirectoryDefault;

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
            ExtensionName = ProgramDefaultArchitecturePageTwoSecond.ExtensionNameDefault;

            EndianFormat = ProgramDefaultArchitecturePageTwoSecond.EndianFormatDefault;

            StringCodec = ProgramDefaultArchitecturePageTwoSecond.StringCodecDefault;

            ChunkSize = ProgramDefaultArchitecturePageTwoSecond.ChunkSizeDefault;

            StartBoundary = ProgramDefaultArchitecturePageTwoSecond.StartBoundaryDefault;

            FullExtension = ProgramDefaultArchitecturePageTwoSecond.FullExtensionDefault;

            return;
        }
    }
}

