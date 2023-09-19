using Core;

namespace Core
{
    using System;

    using System.Diagnostics;

    internal partial class Program
    {
        internal static void Explorer(String path, Int32 ordinal)
        {
            var boolean_safe__BIGGER_THAN = (ordinal > 5);

            Boolean shouldReturn;

            shouldReturn = boolean_safe__BIGGER_THAN is true;

            if (shouldReturn is true)
            {
                return;
            }
            else
                "false".ToString();

            ProcessStartInfo processStartInfo;

            processStartInfo = new ProcessStartInfo(ImmutablePageOneFirst.ExplorerName, path);

            Process process;

            process = new Process();

            process.StartInfo = processStartInfo;

            using (process)
            {
                if (process.Start())
                {
                    goto skip;
                }
                else
                {
                    var next = (ordinal + 1);

                    Explorer(path, next);
                }

            skip:
                {
                    process.Close();

                    process.Dispose();
                }
            }

            return;
        }

    }
}
