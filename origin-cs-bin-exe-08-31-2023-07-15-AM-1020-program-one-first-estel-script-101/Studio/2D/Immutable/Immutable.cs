using Core;

namespace Core
{
    using System;

    internal static class ImmutablePageOneFirst
    {
        internal static readonly String SettingName;

        internal static readonly String SettingExtension;

        internal static readonly String Title;

        internal static readonly ConsoleColor BackgroundColor;

        internal static readonly ConsoleColor ForegroundColor;

        internal static readonly String ProgramName;

        internal static readonly String WorkingDirectoryName;

        internal static readonly String WorkingDirectoryIdentity;

        internal static readonly String ExplorerName;

        internal static readonly String OutputFileName;

        internal static readonly String OutputExtension;

        internal static readonly String SpecialError;

        static ImmutablePageOneFirst()
        {
            SettingName = ProgramDefaultArchitecturePageOneFirst.SettingNameDefault;

            SettingExtension = ProgramDefaultArchitecturePageOneFirst.SettingExtensionDefault;

            Title = ProgramDefaultImmutablePageOneFirst.TitleDefault;

            BackgroundColor = ProgramDefaultImmutablePageOneFirst.BackgroundColorDefault;

            ForegroundColor = ProgramDefaultImmutablePageOneFirst.ForegroundColorDefault;

            ProgramName = ProgramDefaultImmutablePageOneFirst.ProgramNameDefault;

            WorkingDirectoryName = ProgramDefaultImmutablePageOneFirst.WorkingDirectoryNameDefault;

            WorkingDirectoryIdentity = ProgramDefaultImmutablePageOneFirst.WorkingDirectoryIdentityDefault;

            ExplorerName = ProgramDefaultImmutablePageOneFirst.ExplorerNameDefault;

            OutputFileName = ProgramDefaultImmutablePageOneFirst.OutputFileNameDefault;

            OutputExtension = ProgramDefaultImmutablePageOneFirst.OutputExtensionDefault;

            SpecialError = ProgramDefaultImmutablePageOneFirst.SpecialErrorDefault;

            return;
        }
    }
}
