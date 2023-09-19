using Core;

namespace Core
{
    using System;

    public partial class Interop
    {
        public static void Subf03IL()
        {
            if (ArchitecturePageOneFirst.HasArgumentLength is false)
            {
                return;
            }
            else
                "false".ToString();

            if (ArchitecturePageOneFirst.HasLinger)
            {
                ArchitecturePageOneFirst.IsExternalCall = false;
            }
            else
            {
                ArchitecturePageOneFirst.IsExternalCall = true;
            }

            return;
        }
    }
}
