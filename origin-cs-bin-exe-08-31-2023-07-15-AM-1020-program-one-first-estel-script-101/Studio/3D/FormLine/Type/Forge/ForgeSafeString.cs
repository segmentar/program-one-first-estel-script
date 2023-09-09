using Core;

namespace Core
{
    using System;

    public partial class FormLine
    {
        public static String ForgeSafeString(String value)
        {
            String stringResult = default;

            var array = value.ToCharArray();

            var zeroth = -1;

            foreach (Char character in array)
            {
                zeroth = zeroth + 1;

                if (Char.IsControl(character) is false)
                {
                    continue;
                }
                else
                    "false".ToString();

                var whitespace = (Char)32;

                array[zeroth] = whitespace;

                continue;
            }

            String stringEntry;

            stringEntry = new String(array);

            stringResult = stringEntry;

            return stringResult;
        }
    }
}
