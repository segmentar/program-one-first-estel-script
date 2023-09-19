using Core;

namespace Core
{
    using System;

    public partial class Interop
    {
        public static void Chrf06IL()
        {
            var first = Program.ArgumentArray[0];

            var safe_boolean__EQUAL_THAN = (first.Length == 1);

            Boolean isLengthCheck, shouldReturn;

            isLengthCheck = safe_boolean__EQUAL_THAN is true;

            shouldReturn = isLengthCheck is false;

            if (shouldReturn is true)
            {
                return;
            }
            else
                "false".ToString();

            Char character;

            character = first[0];

            Specialize.SetEscapeCharacter(character, true);

            return;
        }
    }
}
