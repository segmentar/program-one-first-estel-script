using Core;

namespace Core
{
    using System;

    public partial class FormBase
    {
        public static String ForgeContent(ControlFlowSchedule controlFlowSchedule, Int32[] positionArray)
        {
            String stringResult = default;

            var start = (positionArray[0] + ','.ToString().Length);

            var difference = (positionArray[1] - start);

            var sub = controlFlowSchedule.Control.Content.Substring(start, difference);

            stringResult = sub;

            return stringResult;
        }
    }
}
