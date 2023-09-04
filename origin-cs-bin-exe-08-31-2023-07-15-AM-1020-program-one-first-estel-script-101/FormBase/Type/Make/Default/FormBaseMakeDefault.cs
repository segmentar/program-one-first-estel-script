using Core;

namespace Core
{
    using System;

    public partial class FormBase
    {
        public static FormBase MakeFormBaseDefault(ControlFlowSchedule controlFlowSchedule, Int32[] positionArray, Boolean debug)
        {
            FormBase formBaseResult = default;

            var result = new FormBaseSequence(controlFlowSchedule, positionArray, debug).Result;

            formBaseResult = result;

            return formBaseResult; 
        }
    }
}
