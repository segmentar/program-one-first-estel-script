using Core;

namespace Core
{
    using System;

    public partial class ControlFlowSchedule
    {
        public static String ForgeContentSafe(String value)
        {
            String stringResult = default;

            Char[] characterArray;

            characterArray = value.ToCharArray();

            var zeroth = -1;

            foreach (Char character in characterArray)
            {
                zeroth = zeroth + 1;

                if (Char.IsControl(character) is false)
                {
                    continue;
                }
                else
                    "false".ToString();

                var whitespace = (Char)32;

                characterArray[zeroth] = whitespace;

                continue;
            }

            var result = new String(characterArray);

            stringResult = result;

            return stringResult;
        }
    }
}
