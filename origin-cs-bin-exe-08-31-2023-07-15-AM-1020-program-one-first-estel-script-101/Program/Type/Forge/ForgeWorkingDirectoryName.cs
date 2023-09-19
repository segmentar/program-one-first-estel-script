using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal static String ForgeWorkingDirectoryName()
        {
            String stringResult = default;

            var name = $"{ImmutablePageOneFirst.ProgramName}-{ImmutablePageOneFirst.WorkingDirectoryName}-{ImmutablePageOneFirst.WorkingDirectoryIdentity}";

            var lower = name.ToLower();

            var split = lower.Split();

            var join = String.Join('-'.ToString(), split);

            stringResult = join;

            return stringResult;
        }
    }
}
