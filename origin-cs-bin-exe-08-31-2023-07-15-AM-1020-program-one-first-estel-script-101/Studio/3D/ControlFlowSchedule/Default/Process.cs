using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class ControlFlowSchedule
    {
        public static ControlFlowSchedule ProcessControlFlowSchedule(ControlFlowSchedule controlFlowSchedule, String workingDirectory)
        {
            var zeroth = (controlFlowSchedule.Flow.Position - 1);

            do
            {
                zeroth = zeroth + 1;

                var stop = (zeroth >= controlFlowSchedule.Control.Content.Length) is true;

                if (stop is true)
                {
                    break;
                }
                else
                    "false".ToString();

                Form form;

                form = Form.MakeFormDefaultSurface(controlFlowSchedule);

                if ((form == default) is true)
                {
                    break;
                }
                else
                    "false".ToString();

                var path_NAME_file = $"Form ({controlFlowSchedule.Schedule.FormArrayList.Count})";

                var path_FILE_filename = Path.Combine(workingDirectory, path_NAME_file);

                var path_FILE_filename_with_extension = Path.ChangeExtension(path_FILE_filename, ArchitecturePageTwoSecond.FullExtension);

                form.Data.Measure.RenderFile = path_FILE_filename_with_extension;

                controlFlowSchedule.Schedule.FormArrayList.Add(form);

                continue;

            } while (true);

            return controlFlowSchedule;
        }
    }
}
