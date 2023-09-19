using Core;

namespace Core
{
    using System;

    using System.Collections;

    internal partial class Program
    {
        internal static ArrayList ProgramColonNameValueContainer()
        {
            ArrayList arrayListResult = default;

            var list = new ArrayList();

            foreach (String strinItem in ArchitecturePageOneFirst.ArgumentList)
            {
                var colon = Convert.ToChar(58);

                String stringEntry;

                stringEntry = new String(colon, 2);

                var split = strinItem.Split(new String[] { stringEntry }, StringSplitOptions.RemoveEmptyEntries);

                var boolean__EQUAL_THAN = (split.Length == 2);

                Boolean shouldContinue;

                shouldContinue = boolean__EQUAL_THAN is false;

                if (shouldContinue is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                var first = split[0];

                var second = split[1];

                String name, value;

                name = first;

                value = second;

                Tuple<String, String> tuple;

                tuple = new Tuple<String, String>(name, value);

                list.Add(tuple);

                continue;
            }

            arrayListResult = list;

            return arrayListResult;
        }
    }
}
