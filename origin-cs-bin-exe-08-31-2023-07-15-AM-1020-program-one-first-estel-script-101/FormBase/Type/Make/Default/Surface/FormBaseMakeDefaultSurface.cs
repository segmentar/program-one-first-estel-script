using Core;

namespace Core
{
    using System;

    public partial class FormBase
    {
        public static FormBase MakeFormBaseDefaultSurface(ControlFlowSchedule controlFlowSchedule, Int32[] positionArray)
        {
            FormBase formBaseResult = default;

            formBaseResult = MakeFormBaseDefault(controlFlowSchedule, positionArray, FormBasePolicy.FormBaseDebugPolicy);

            return formBaseResult; 
        }
    }
}
