using Core;

namespace Core
{
    using System;

    public partial class FormBaseSequence
    {
        public static void Debug(Boolean debug)
        {
            if (debug is false)
            {
                return;
            }
            else
                "false".ToString();

            var descriptor = String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(FormBase) + ' ' + "::" + ' ' + nameof(FormBaseSequence) + ' ' + '{',
                String.Empty + '.' + "debug",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(debug) + ':' + ' ' + debug,
                String.Empty + '}'
            });

            Program.Render($"{ProgramCode.ObservableDirectory.Core}-{ProgramCode.ObservableDirectory.Debug}-FormBaseDebug", descriptor);

            return;
        }
    }
}
