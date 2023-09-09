using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal static String[] SafeArray(params Object[] array)
        {
            String[] arrayResult = default;

            var length = array.Length;

            String[] stringArray;

            stringArray = new String[length];

            var indexer = 0;

            do
            {
                Boolean shouldBreak;

                shouldBreak = (indexer == length) is true;

                if (shouldBreak is true)
                {
                    break;
                }
                else
                    "false".ToString();

                stringArray[indexer] = SafeString(array[indexer]);

                indexer = indexer + 1;

            } while (true);

            arrayResult = stringArray;

            return arrayResult;
        }
    }
}
