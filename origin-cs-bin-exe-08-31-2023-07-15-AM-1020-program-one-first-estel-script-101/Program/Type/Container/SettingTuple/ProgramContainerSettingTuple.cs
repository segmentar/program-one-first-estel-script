using Core;

namespace Core
{
    using System;

    using System.Collections;

    internal partial class Program
    {
        internal static ArrayList ProgramSettingTupleContainer(String text)
        {
            ArrayList listResult = default;

            var list = new ArrayList();

            var line_feed = Convert.ToChar(10);

            var split_U = text.Split(new String[] { line_feed.ToString() }, StringSplitOptions.None);

            foreach (String stringItem in split_U)
            {
                var colon = Convert.ToChar(58);

                var item__DOUBLE_COLON = new String(colon, 2);

                var split_V = stringItem.Split(new String[] { item__DOUBLE_COLON }, StringSplitOptions.RemoveEmptyEntries);

                Boolean hasLengthCheck;

                hasLengthCheck = (split_V.Length > 0) is true;

                if (hasLengthCheck is false)
                {
                    continue;
                }
                else
                    "false".ToString();

                var eoth = (split_V.Length - 1);

                var first = split_V[0];

                var last = split_V[eoth];

                String name, value;

                name = first;

                value = last;

                Tuple<String, String> tuple;

                tuple = new Tuple<String, String>(name, value);

                list.Add(tuple);

                continue;
            }

            listResult = list;

            return listResult;
        }
    }
}
