using Core;

namespace Core
{
    using System;

    public partial struct ProgramModule
    {
        public static ProgramModule ProgramModuleFunctionThree(ProgramModule module)
        {
            ControlFlowSchedule[] controlFlowScheduleArray;

            controlFlowScheduleArray = ControlFlowSchedule.ControlFlowScheduleDefaultSetSurface(module.Second.FileArray, module.First.WorkingDirectory);

            Form[] formArray;

            formArray = Form.FormDefaultSetSurface(controlFlowScheduleArray, module.First.WorkingDirectory);

            ProgramModuleFunctionThird third;

            third = new ProgramModuleFunctionThird(controlFlowScheduleArray, formArray);

            module.Third = third;

            return module;
        }
    }
}
