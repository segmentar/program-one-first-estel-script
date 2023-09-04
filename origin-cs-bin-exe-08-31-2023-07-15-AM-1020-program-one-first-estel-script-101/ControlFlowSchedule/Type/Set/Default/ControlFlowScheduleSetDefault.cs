using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ControlFlowSchedule
    {
        public static IList<ControlFlowSchedule> ControlFlowScheduleDefaultSet(String[] fileArray, String workingDirectory)
        {
            ICollection<ControlFlowSchedule> collectionResult = default;

            collectionResult = new Collection<ControlFlowSchedule>();

            foreach (String file in fileArray)
            {
                var path_NAME__RENDER = Path.GetFileNameWithoutExtension(file);

                var path_FILE_filename__RENDER = Path.Combine(workingDirectory, path_NAME__RENDER);

                var path_FILE_filename_with_extension__RENDER = Path.ChangeExtension(path_FILE_filename__RENDER, Architecture.FullExtension);

                ControlFlowScheduleSimple controlFlowScheduleSimple;

                controlFlowScheduleSimple = new ControlFlowScheduleSimple(file, path_FILE_filename_with_extension__RENDER);

                collectionResult.Add(controlFlowScheduleSimple.Result);

                continue;
            }

            return new List<ControlFlowSchedule>(collectionResult);
        }
    }
}
