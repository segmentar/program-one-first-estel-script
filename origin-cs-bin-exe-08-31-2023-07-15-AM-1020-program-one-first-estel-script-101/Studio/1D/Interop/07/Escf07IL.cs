using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Interop
    {
        public static void Escf07IL()
        {
            if (ArchitecturePageOneFirst.HasEscapeCharacter is false)
            {
                return;
            }
            else
                "false".ToString();

            ArchitecturePageOneFirst.ArgumentList = new ArrayList(Program.ProgramArgumentEscapeCharacterContainerSurface<String>());

            ArchitecturePageOneFirst.ArgumentList = new ArrayList(Program.ProgramArgumentEscapeFormatContainerSurface<String>());

            return;
        }
    }
}
