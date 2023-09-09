using Core;

namespace Core
{
    using System;

    public partial class Form
    {
        public static Form MakeFormDefaultSurface(ControlFlowSchedule controlFlowSchedule)
        {
            Form formResult = default;

            formResult = MakeFormDefault(controlFlowSchedule, FormPolicy.FormDebugPolicy);

            return formResult;
        }
    }
}
