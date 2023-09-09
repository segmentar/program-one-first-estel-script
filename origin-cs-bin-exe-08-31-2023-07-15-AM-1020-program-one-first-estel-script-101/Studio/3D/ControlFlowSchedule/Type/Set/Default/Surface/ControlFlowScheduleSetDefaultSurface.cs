using Core;

namespace Core
{
    using System;

    public partial class ControlFlowSchedule
    {
        public static ControlFlowSchedule[] ControlFlowScheduleDefaultSetSurface(String[] fileArray, String workingDirectory)
        {
            ControlFlowSchedule[] arrayResult = default;

            var list = ControlFlowScheduleDefaultSet(fileArray, workingDirectory);

            ControlFlowSchedule[] controlFlowScheduleArray;

            controlFlowScheduleArray = new ControlFlowSchedule[list.Count];

            list.CopyTo(controlFlowScheduleArray, 0);

            arrayResult = controlFlowScheduleArray;

            return arrayResult;
        }
    }
}
