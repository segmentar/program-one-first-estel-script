using Core;

namespace Core
{
    using System;

    public partial class FormBase
    {
        public static String[] ForgeHeaderArray(ControlFlowSchedule controlFlowSchedule, Int32[] positionArray)
        {
            String[] arrayResult = default;

            var difference = (positionArray[0] - controlFlowSchedule.Flow.Position);

            String stringItem;

            stringItem = controlFlowSchedule.Control.Content.Substring(controlFlowSchedule.Flow.Position, difference);

            var split = stringItem.Split(new String[] { "." }, StringSplitOptions.RemoveEmptyEntries);

            arrayResult = split;

            return arrayResult;
        }
    }
}
