using Core;

namespace Core
{
    using System;

    public partial class Interop
    {
        public static void Subf01()
        {
            Boolean isExternalCall;

            isExternalCall = (Program.ArgumentArray.Length == 0) is false;

            if (isExternalCall is false)
            {
                return;
            }
            else
                "false".ToString();

            ArchitecturePageOneFirst.IsExternalCall = true;

            return;
        }
    }
}
