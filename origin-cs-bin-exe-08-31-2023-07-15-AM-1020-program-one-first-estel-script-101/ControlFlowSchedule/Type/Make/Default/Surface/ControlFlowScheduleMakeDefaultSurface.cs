using Core;

namespace Core
{
    using System;

    public partial class ControlFlowSchedule
    {
        public static ControlFlowSchedule MakeControlFlowScheduleDefaultSurface(String file, String content, String renderFile)
        {
            ControlFlowSchedule controlFlowScheduleResult = default;

            controlFlowScheduleResult = MakeControlFlowScheduleDefault(file, content, renderFile, ControlFlowSchedulePolicy.ControlFlowScheduleDebugPolicy);

            return controlFlowScheduleResult;
        }
    }
}
