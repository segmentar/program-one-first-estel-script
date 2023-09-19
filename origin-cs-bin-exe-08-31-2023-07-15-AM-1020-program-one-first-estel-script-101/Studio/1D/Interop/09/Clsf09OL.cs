using Core;

namespace Core
{
    using System;

    using System.Diagnostics;

    public partial class  Interop
    {
        public static void Clsf09OL(Int32 ordinal, Char escapeCharacter, params String[] array_ARGUMENT)
        {
            var whitespace = Convert.ToChar(32);

            var boolea_safe__MORE_THAN = (ordinal > 5);

            Boolean shouldReturn;

            shouldReturn = boolea_safe__MORE_THAN is true;

            if (shouldReturn is true)
            {
                return;
            }
            else
                "false".ToString();

            ProcessStartInfo processStartInfo;

            processStartInfo = new ProcessStartInfo();

            processStartInfo.FileName = Process.GetCurrentProcess().MainModule.FileName;

            processStartInfo.Arguments = escapeCharacter.ToString() + ' ' + String.Join(whitespace.ToString(), array_ARGUMENT);

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

                    Clsf09OL(next, escapeCharacter, array_ARGUMENT);
                }

                skip:
                {
                    process.Close();

                    process.Dispose();
                }
            }

            Environment.Exit(0);

            return;
        }
    }
}