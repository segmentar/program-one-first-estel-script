using Core;

namespace Core
{
    using System;

    public partial class Interop
    {
        public static void Lenf01IL()
        {
            var safe_boolean__MORE_THAN = (Program.ArgumentArray.Length > 0);

            Boolean hasLengthCheck, shouldReturn;

            hasLengthCheck = safe_boolean__MORE_THAN is true;

            shouldReturn = hasLengthCheck is false;

            if (shouldReturn is true)
            {
                return;
            }
            else
                "false".ToString();

            ArchitecturePageOneFirst.HasArgumentLength = true;

            return;
        }
    }
}
