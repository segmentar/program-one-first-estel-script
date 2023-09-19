using Core;

namespace Core
{
    using System;

    public partial class ControlFlowScheduleSequence
    {
        public static void Debug(String file, String content, Boolean debug)
        {
            if (debug is false)
            {
                return;
            }
            else
                "false".ToString();

            var descriptor = String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(ControlFlowSchedule) + ' ' + "::" + ' ' + nameof(ControlFlowScheduleSequence) + ' ' + '{',
                String.Empty + '.' + "debug",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(file) + ':' + ' ' + file,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(content) + ':' + ' ' + content,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(debug) + ':' + ' ' + debug,
                String.Empty + '}'
            });

            Program.Render($"{ProgramCode.SpecialDirectory.Core_Debug}-ControlFlowScheduleDebug", 1, descriptor);

            return;
        }
    }
}
