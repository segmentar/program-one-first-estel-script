using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal static String ForgeWorkingDirectoryName()
        {
            String stringResult = default;

            var name = $"{ProgramImmutable.ProgramName}-{ProgramImmutable.WorkingDirectoryName}-{ProgramImmutable.WorkingDirectoryIdentifier}";

            var lower = name.ToLower();

            var split = lower.Split();

            var join = String.Join('-'.ToString(), split);

            stringResult = join;

            return stringResult;
        }
    }
}
