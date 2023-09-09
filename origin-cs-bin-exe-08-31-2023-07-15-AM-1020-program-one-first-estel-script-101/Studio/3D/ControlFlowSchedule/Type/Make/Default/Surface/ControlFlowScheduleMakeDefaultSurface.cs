using Core;

namespace Core
{
    using System;

    public partial class ControlFlowSchedule
    {
        public static ControlFlowSchedule MakeControlFlowScheduleDefaultSurface(String file, String content)
        {
            ControlFlowSchedule controlFlowScheduleResult = default;

            controlFlowScheduleResult = MakeControlFlowScheduleDefault(file, content, ControlFlowSchedulePolicy.ControlFlowScheduleDebugPolicy);

            return controlFlowScheduleResult;
        }
    }
}
