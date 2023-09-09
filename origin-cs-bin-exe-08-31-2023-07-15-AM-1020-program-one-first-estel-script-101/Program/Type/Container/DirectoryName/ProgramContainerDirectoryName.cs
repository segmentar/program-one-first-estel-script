using Core;

namespace Core
{
    using System;

    using System.Collections;

    internal partial class Program
    {
        internal static ArrayList ProgramDirectoryNameContainer(String[] directoryArray)
        {
            ArrayList arrayListResult = default;

            var list = new ArrayList();

            foreach (String stringItem in directoryArray)
            {
                foreach (var item_STRING in Enum.GetNames(typeof(ProgramCode.ObservableDirectory)))
                {
                    Tuple<String, String> tuple;

                    tuple = new Tuple<String, String>(stringItem, item_STRING);

                    list.Add(tuple);

                    continue;
                }

                continue;
            }

            arrayListResult = list;

            return arrayListResult;
        }
    }
}
