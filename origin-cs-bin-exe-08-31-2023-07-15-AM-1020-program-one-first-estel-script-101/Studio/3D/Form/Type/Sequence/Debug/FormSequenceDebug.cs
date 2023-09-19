using Core;

namespace Core
{
    using System;

    public partial class FormSequence
    {
        public static void Debug(ControlFlowSchedule controlFlowSchedule, Boolean debug)
        {
            if (debug is false)
            {
                return;
            }
            else
                "false".ToString();

            var descriptor = String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(Form) + ' ' + "::" + ' ' + nameof(FormSequence) + ' ' + '{',
                String.Empty + '.' + "debug",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(controlFlowSchedule) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(debug) + ':' + ' ' + debug,
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(controlFlowSchedule) + ':',
                String.Empty + controlFlowSchedule
            });

            Program.Render($"{ProgramCode.SpecialDirectory.Core_Debug}-FormDebug", descriptor);

            return;
        }
    }
}
