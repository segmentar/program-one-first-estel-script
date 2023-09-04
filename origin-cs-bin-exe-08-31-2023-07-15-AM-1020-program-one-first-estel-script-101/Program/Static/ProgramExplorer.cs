using Core;

namespace Core
{
    using System;

    using System.Diagnostics;

    internal partial class Program
    {
        internal static void Explorer(String value, Int32 ordinal)
        {
            if ((ordinal > 5) is true)
            {
                return;
            }
            else
                "false".ToString();

            ProcessStartInfo processStartInfo;

            processStartInfo = new ProcessStartInfo("explorer", value);

            Process process;

            using (process = new Process())
            {
                process.StartInfo = processStartInfo;

                if (process.Start())
                {
                    goto skip;
                }
                else
                {
                    var next = (ordinal + 1);

                    Explorer(value, next);
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
