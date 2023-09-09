using Core;

namespace Core
{
    using System;

    internal static class Immutable
    {
        internal static readonly String ProgramName;

        internal static readonly String WorkingDirectoryName;

        internal static readonly String WorkingDirectoryIdentity;

        internal static readonly String OutputFileName;

        internal static readonly String OutputExtension;

        static Immutable()
        {
            ProgramName = ProgramDefaultPageTwoSecond.ProgramNameDefault;

            WorkingDirectoryName = ProgramDefaultPageTwoSecond.WorkingDirectoryNameDefault;

            WorkingDirectoryIdentity = ProgramDefaultPageTwoSecond.WorkingDirectoryIdentityDefault;

            OutputFileName = ProgramDefaultPageTwoSecond.OutputFileNameDefault;

            OutputExtension = ProgramDefaultPageTwoSecond.OutputExtensionDefault;

            return;
        }
    }
}
