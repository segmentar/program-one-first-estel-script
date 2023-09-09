using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal static String ForgeWorkingDirectoryName()
        {
            String stringResult = default;

            var name = $"{Immutable.ProgramName}-{Immutable.WorkingDirectoryName}-{Immutable.WorkingDirectoryIdentity}";

            var lower = name.ToLower();

            var split = lower.Split();

            var join = String.Join('-'.ToString(), split);

            stringResult = join;

            return stringResult;
        }
    }
}
