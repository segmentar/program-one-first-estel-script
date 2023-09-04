using Core;

namespace Core
{
    using System;

    public partial class ProgramModuleFunctionThird
    {
        public ControlFlowSchedule[] ControlFlowScheduleArray;

        public Form[] FormArray;

        public ProgramModuleFunctionThird(ControlFlowSchedule[] controlFlowScheduleArray, Form[] formArray)
        {
            this.ControlFlowScheduleArray = controlFlowScheduleArray;

            this.FormArray = formArray;

            return;
        }

        ~ProgramModuleFunctionThird()
        {
            return;
        }
    }
}
