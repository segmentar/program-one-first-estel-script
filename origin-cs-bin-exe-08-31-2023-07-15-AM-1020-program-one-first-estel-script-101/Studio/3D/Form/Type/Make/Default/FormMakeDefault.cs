using Core;

namespace Core
{
    using System;

    public partial class Form
    {
        public static Form MakeFormDefault(ControlFlowSchedule controlFlowSchedule, Boolean debug)
        {
            Form formResult = default;

            var result = new FormSequence(controlFlowSchedule, debug).Result;

            FormPolicy.FormArrayList.Add(result);

            formResult = result;

            return formResult;
        }
    }
}
