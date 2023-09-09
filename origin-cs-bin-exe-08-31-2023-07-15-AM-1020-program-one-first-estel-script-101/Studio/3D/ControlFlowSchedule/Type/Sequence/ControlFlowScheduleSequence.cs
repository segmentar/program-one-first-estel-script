using Core;

namespace Core
{
    using System;

    public partial class ControlFlowScheduleSequence
    {
        public ControlFlowSchedule Result { get; set; } = default;

        public ControlFlowScheduleSequence(String file, String content, Boolean debug)
        {
            Debug(file, content, debug);

            String contentSafe;

            contentSafe = Program.SafeString(content);

            var tuple = ControlFlowSchedule.ForgeControlFlowScheduleTuple(file, content, contentSafe);

            ControlFlowSchedule controlFlowSchedule;

            controlFlowSchedule = new ControlFlowSchedule(tuple.Item1, tuple.Item2, tuple.Item3);

            this.Result = controlFlowSchedule;

            return;
        }

        ~ControlFlowScheduleSequence()
        {
            return;
        }
    }
}
