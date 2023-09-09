using Core;

namespace Core
{
    using System;

    public partial class ControlFlowSchedule
    {
        public static Tuple<Control, Flow, Schedule> ForgeControlFlowScheduleTuple(String file, String content, String contentSafe)
        {
            Tuple<Control, Flow, Schedule> tupleResult = default;

            Control control;

            Flow flow;

            Schedule schedule;

            control = new Control(file, content, contentSafe);

            flow = new Flow();

            schedule = new Schedule();

            Tuple<Control, Flow, Schedule> tuple;

            tuple = new Tuple<Control, Flow, Schedule>(control, flow, schedule);

            tupleResult = tuple;

            return tupleResult;
        }
    }
}
