using Core;

namespace Core
{
    using System;

    internal partial class Specialize
    {
        internal static void SetInputDirectory(String inputDirectory, Boolean hasInputDirectory)
        {
            ArchitecturePageOneFirst.InputDirectory = inputDirectory;

            ArchitecturePageOneFirst.HasInputDirectory = hasInputDirectory;

            return;
        }
    }
}
