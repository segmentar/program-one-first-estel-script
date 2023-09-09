using Core;

namespace Core
{
    using System;

    using System.Collections;

    internal partial class Program
    {
        internal static ArrayList ProgramArgumentEscapeCharacterContainer()
        {
            ArrayList arrayListResult = default;

            var list = new ArrayList();

            var enumerator = ArgumentArray.GetEnumerator();

            do
            {
                Boolean shouldBreak;

                shouldBreak = enumerator.MoveNext() is false;

                if (shouldBreak is true)
                {
                    break;
                }
                else
                    "false".ToString();

                var reflect = enumerator.Current as String;

                var roth = (reflect.Length - 1);

                var last = reflect[roth];

                var match_ESCAPE_CHARACTER_has = true;

                match_ESCAPE_CHARACTER_has = match_ESCAPE_CHARACTER_has && (reflect.Length == 1) is false;

                match_ESCAPE_CHARACTER_has = match_ESCAPE_CHARACTER_has && (last == ArchitecturePageOneFirst.EscapeCharacter) is true;

                Boolean hasEscapeCharacter;

                hasEscapeCharacter = match_ESCAPE_CHARACTER_has is true;

                String stringItem;

                if (hasEscapeCharacter)
                {
                    if (enumerator.MoveNext())
                    {
                        var item_STRING = enumerator.Current as String;

                        stringItem = (reflect + item_STRING);
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    stringItem = reflect;
                }

                list.Add(stringItem);

                continue;

            } while (true);

            arrayListResult = list;

            return arrayListResult;
        }
    }
}