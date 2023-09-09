using Core;

namespace Core
{
    using System;

    public partial class Interop
    {
        public static void Charf03()
        {
            var boolean__EQUAL_OR_MORE_THAN = (Program.ArgumentArray.Length >= 1);

            Boolean isLengthArrayCheck;

            isLengthArrayCheck = boolean__EQUAL_OR_MORE_THAN is true;

            if (isLengthArrayCheck is false)
            {
                return;
            }
            else
                "false".ToString();

            var first = Program.ArgumentArray[0];

            var boolean__EQUAL_THAN = (first.Length == 1);

            Boolean isLengthStringCheck;

            isLengthStringCheck = boolean__EQUAL_THAN is true;

            if (isLengthStringCheck is false)
            {
                return;
            }
            else
                "false".ToString();

            Char character;

            character = first[0];

            ArchitecturePageOneFirst.EscapeCharacter = character;

            ArchitecturePageOneFirst.HasEscapeCharacter = true;

            return;
        }
    }
}
