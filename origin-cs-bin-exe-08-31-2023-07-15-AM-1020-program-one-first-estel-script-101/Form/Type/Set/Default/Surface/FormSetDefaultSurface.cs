using Core;

namespace Core
{
    using System;

    public partial class Form
    {
        public static Form[] FormDefaultSetSurface(ControlFlowSchedule[] controlFlowScheduleArray)
        {
            Form[] arrayResult = default;

            var list = FormDefaultSet(controlFlowScheduleArray);

            Form[] formArray;

            formArray = new Form[list.Count];

            list.CopyTo(formArray, 0);

            arrayResult = formArray;

            return arrayResult;
        }
    }
}
