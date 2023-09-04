using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Form
    {
        public static IList<Form> FormDefaultSet(ControlFlowSchedule[] controlFlowScheduleArray)
        {
            ICollection<Form> collectionResult = default;

            collectionResult = new Collection<Form>();

            foreach (ControlFlowSchedule controlFlowScheduleItem in controlFlowScheduleArray)
            {
                ControlFlowSchedule controlFlowScheduleEntry;

                controlFlowScheduleEntry = ControlFlowSchedule.ProcessControlFlowSchedule(controlFlowScheduleItem);

                foreach (Form form in controlFlowScheduleEntry.Schedule.FormArrayList)
                {
                    collectionResult.Add(form);

                    continue;
                }

                continue;
            }

            return new List<Form>(collectionResult);
        }
    }
}
