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

            foreach (String directory in directoryArray)
            {
                foreach (String name in Enum.GetNames(typeof(ProgramCode.SpecialDirectory)))
                {
                    Tuple<String, String> tuple;

                    tuple = new Tuple<String, String>(directory, name);

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
