using Core;

namespace Core
{
    using System;

    public partial class ControlFlowSchedule
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
                String.Empty + nameof(ControlFlowSchedule) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "compress",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '.' + "compress-raw",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Control) + ':' + ' ' + ". . . . ." + ' ' + $"<2>",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(Flow) + ':' + ' ' + ". . . . ." + ' ' + "<1>",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(Schedule) + ':' + ' ' + ". . . . ." + ' ' + "<1>",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(Control) + ':',
                String.Empty + '.' + nameof(Control.File),
                String.Empty + Control.File,
                String.Empty + '.' + nameof(Control.Content) + ' ' + "<safe>",
                String.Empty + Control.ContentSafe,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(Flow) + ':',
                String.Empty + '.' + nameof(Flow.Position),
                String.Empty + Flow.Position,
                String.Empty,
                String.Empty + '~' + "30" + ' ' + nameof(Schedule) + ':',
                String.Empty + '.' + nameof(Schedule.FormArrayList) + ' ' + $"<{Schedule.FormArrayList.Count}>",
                String.Empty + String.Join('\n'.ToString(), Schedule.FormArrayList.ToArray())
            });
        }
    }
}
