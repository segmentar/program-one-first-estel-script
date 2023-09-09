using Core;

namespace Core
{
    using System;

    public partial class ControlFlowScheduleSimple
    {
        public ControlFlowSchedule Result { get; set; } = default;

        public ControlFlowScheduleSimple()
        {
            return;
        }

        ~ControlFlowScheduleSimple()
        {
            return;
        }
    }
}

namespace Core
{
    using System;

    using System.IO;

    using System.Text;

    public partial class ControlFlowScheduleSimple
    {
        public unsafe ControlFlowScheduleSimple(String file)
        {
            FileStream fileStream;

            using (fileStream = File.OpenRead(file))
            {
                Byte[] byteArray;

                byteArray = new Byte[fileStream.Length];

                var length = fileStream.Read(byteArray, 0, byteArray.Length);

                fixed (Byte* pointer = byteArray)
                {
                    SByte* pointerLock;

                    pointerLock = (SByte*)pointer;

                    String stringItem;

                    stringItem = new String(pointerLock, 0, length, Encoding.Default);

                    ControlFlowSchedule controlFlowSchedule;

                    controlFlowSchedule = ControlFlowSchedule.MakeControlFlowScheduleDefaultSurface(file, stringItem);

                    this.Result = controlFlowSchedule;
                }

                fileStream.Close();

                fileStream.Dispose();
            }

            return;
        }
    }
}
