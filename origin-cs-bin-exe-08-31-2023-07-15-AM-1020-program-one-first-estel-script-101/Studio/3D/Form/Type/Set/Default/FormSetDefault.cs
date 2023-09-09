using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Form
    {
        public static IList<Form> FormDefaultSet(ControlFlowSchedule[] controlFlowScheduleArray, String workingDirectory)
        {
            ICollection<Form> collectionResult = default;

            collectionResult = new Collection<Form>();

            foreach (ControlFlowSchedule controlFlowScheduleItem in controlFlowScheduleArray)
            {
                ControlFlowSchedule controlFlowScheduleEntry;

                controlFlowScheduleEntry = ControlFlowSchedule.ProcessControlFlowSchedule(controlFlowScheduleItem, workingDirectory);

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
