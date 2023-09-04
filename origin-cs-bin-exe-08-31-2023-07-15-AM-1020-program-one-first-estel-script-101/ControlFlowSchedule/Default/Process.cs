using Core;

namespace Core
{
    using System;

    public partial class ControlFlowSchedule
    {
        public static ControlFlowSchedule ProcessControlFlowSchedule(ControlFlowSchedule controlFlowSchedule)
        {
            var zeroth = (controlFlowSchedule.Flow.Position - 1);

            do
            {
                zeroth = zeroth + 1;

                var stop = (zeroth >= controlFlowSchedule.Control.Content.Length) is true;

                if (stop is true)
                {
                    break;
                }
                else
                    "false".ToString();

                Form form;

                form = Form.MakeFormDefaultSurface(controlFlowSchedule);

                if ((form == default) is true)
                {
                    break;
                }
                else
                    "false".ToString();

                controlFlowSchedule.Schedule.FormArrayList.Add(form);

                continue;

            } while (true);

            return controlFlowSchedule;
        }
    }
}
