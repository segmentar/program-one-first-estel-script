using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Interop
    {
        public static void Reff04IL()
        {
            ArrayList arrayList;

            arrayList = new ArrayList(Program.ArgumentArray);

            ArchitecturePageOneFirst.ArgumentList = arrayList;

            return;
        }
    }
}
