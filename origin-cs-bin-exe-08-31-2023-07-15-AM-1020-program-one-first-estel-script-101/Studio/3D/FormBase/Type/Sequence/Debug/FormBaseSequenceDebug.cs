using Core;

namespace Core
{
    using System;

    public partial class FormBaseSequence
    {
        public static void Debug(ControlFlowSchedule controlFlowSchedule, Int32[] positionArray, Boolean debug)
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
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(controlFlowSchedule) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(positionArray) + ':' + ' ' + $"<{positionArray.Length}>",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(debug) + ':' + ' ' + debug,
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(controlFlowSchedule) + ':',
                String.Empty + controlFlowSchedule,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(positionArray) + ':',
                String.Empty + String.Join('\n'.ToString(), positionArray)
            });

            Program.Render($"{ProgramCode.SpecialDirectory.Core_Debug}-FormBaseDebug", descriptor);

            return;
        }
    }
}
