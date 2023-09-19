using Core;

namespace Core
{
    using System;

    internal partial class Specialize
    {
        internal static void SetOutputDirectory(String outputDirectory, Boolean hasOutputDirectory)
        {
            ArchitecturePageOneFirst.OutputDirectory = outputDirectory;

            ArchitecturePageOneFirst.HasOutputDirectory = hasOutputDirectory;

            return;
        }
    }
}
