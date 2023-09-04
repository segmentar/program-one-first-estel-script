using Core;

namespace Core
{
    using System;

    using System.Collections;

    internal partial class Program
    {
        internal static String[] SafeArray(params Object[] array)
        {
            String[] arrayResult = default;

            var list = new ArrayList();

            foreach (Object objectItem in array)
            {
                String stringItem;

                stringItem = objectItem.ToString();

                Char[] characterArray;

                characterArray = stringItem.ToCharArray();

                var zeroth = -1;

                foreach (Char character in stringItem)
                {
                    zeroth = zeroth + 1;

                    if (Char.IsControl(character) is false)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    var whitespace = Convert.ToChar(32);

                    characterArray[zeroth] = whitespace;

                    continue;
                }

                String stringEntry;

                stringEntry = new String(characterArray);

                list.Add(stringEntry);

                continue;
            }

            var reflect = (String[])(list.ToArray(typeof(String)) as Array);

            arrayResult = reflect;

            return arrayResult;
        }
    }
}
