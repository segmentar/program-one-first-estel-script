using Core;

namespace Core
{
    using System;

    using System.Collections;

    internal partial class Program
    {
        internal static ArrayList ProgramArgumentEscapeFormatContainer()
        {
            ArrayList arrayListResult = default;

            var list = new ArrayList();

            foreach (String stringItem in ArchitecturePageOneFirst.ArgumentList)
            {
                Char[] characterArray;

                characterArray = stringItem.ToCharArray();

                var zeroth = -1;

                foreach (Char character in characterArray)
                {
                    zeroth = zeroth + 1;

                    Boolean shouldContinue;

                    shouldContinue = (character == ArchitecturePageOneFirst.EscapeCharacter) is false;

                    if (shouldContinue is true)
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

            arrayListResult = list;

            return arrayListResult;
        }
    }
}
