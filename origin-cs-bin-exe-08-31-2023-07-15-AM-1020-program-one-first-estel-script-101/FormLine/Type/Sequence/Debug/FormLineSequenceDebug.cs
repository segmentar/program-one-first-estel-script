using Core;

namespace Core
{
    using System;

    public partial class FormLineSequence
    {
        public static void Debug(String content, Boolean debug)
        {
            if (debug is false)
            {
                return;
            }
            else
                "false".ToString();

            var descriptor = String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(FormLine) + ' ' + "::" + ' ' + nameof(FormLineSequence) + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(content) + ':' + ' ' + content,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(debug) + ':' + ' ' + debug,
                String.Empty + '}'
            });

            Program.Render($"{ProgramCode.ObservableDirectory.Core}-{ProgramCode.ObservableDirectory.Debug}-FormLineDebug", 1, descriptor);

            return;
        }
    }
}
