﻿using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal static String SafeString(Object objectItem)
        {
            String stringResult = default;

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

            stringResult = stringEntry;

            return stringResult;
        }
    }
}
