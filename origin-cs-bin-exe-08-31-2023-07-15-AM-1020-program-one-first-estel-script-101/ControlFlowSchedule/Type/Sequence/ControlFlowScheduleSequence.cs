using Core;

namespace Core
{
    using System;

    public partial class ControlFlowScheduleSequence
    {
        public ControlFlowSchedule Result { get; set; } = default;

        public ControlFlowScheduleSequence(String file, String content, String renderFile, Boolean debug)
        {
            Debug(file, content, debug);

            String contentSafe;

            contentSafe = ControlFlowSchedule.ForgeContentSafe(content);

            Control control;

            Flow flow;

            Schedule schedule;

            control = new Control(file, content, contentSafe, renderFile);

            flow = new Flow();

            schedule = new Schedule();

            ControlFlowSchedule controlFlowSchedule;

            controlFlowSchedule = new ControlFlowSchedule(control, flow, schedule);

            this.Result = controlFlowSchedule;

            return;
        }

        ~ControlFlowScheduleSequence()
        {
            return;
        }
    }
}
