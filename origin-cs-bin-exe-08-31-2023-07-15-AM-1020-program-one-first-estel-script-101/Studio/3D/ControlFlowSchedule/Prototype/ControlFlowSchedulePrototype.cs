using Core;

namespace Core
{
    using System;

    public partial class ControlFlowSchedule
    {
        public ControlFlowSchedule(Control control, Flow flow, Schedule schedule)
        {
            this.Control = control;

            this.Flow = flow;

            this.Schedule = schedule;

            return;
        }
    }
}
