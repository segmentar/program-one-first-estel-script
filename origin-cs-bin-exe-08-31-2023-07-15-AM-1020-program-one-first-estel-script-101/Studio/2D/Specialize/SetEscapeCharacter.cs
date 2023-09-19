using Core;

namespace Core
{
    using System;

    internal partial class Specialize
    {
        internal static void SetEscapeCharacter(Char escapeCharacter, Boolean hasEscapeCharacter)
        {
            ArchitecturePageOneFirst.EscapeCharacter = escapeCharacter;

            ArchitecturePageOneFirst.HasEscapeCharacter = hasEscapeCharacter;

            return;
        }
    }
}
