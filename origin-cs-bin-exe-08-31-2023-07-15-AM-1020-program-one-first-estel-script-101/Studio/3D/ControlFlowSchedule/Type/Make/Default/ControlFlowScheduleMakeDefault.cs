using Core;

namespace Core
{
    using System;

    public partial class ControlFlowSchedule
    {
        public static ControlFlowSchedule MakeControlFlowScheduleDefault(String file, String content, Boolean debug)
        {
            ControlFlowSchedule controlFlowScheduleResult = default;

            var result = new ControlFlowScheduleSequence(file, content, debug).Result;

            ControlFlowSchedulePolicy.ControlFlowScheduleArrayList.Add(result);

            controlFlowScheduleResult = result;

            return controlFlowScheduleResult;
        }
    }
}
