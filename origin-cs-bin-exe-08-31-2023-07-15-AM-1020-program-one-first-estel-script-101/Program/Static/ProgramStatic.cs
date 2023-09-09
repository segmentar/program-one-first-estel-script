using Core;

namespace Core
{
    using System;

    using System.IO;

    internal partial class Program
    {
        internal static String[] ArgumentArray;

        internal static void Main(params String[] array_ARGUMENT)
        {
            ArgumentArray = array_ARGUMENT;

            Bundle();

            return;
        }

        internal static void Procedure()
        {
            ProgramPolicy.ProgramDebugPolicy = true;

            ProgramPolicy.ProgramInfoPolicy = true;

            ControlFlowSchedulePolicy.ControlFlowScheduleDebugPolicy = true;

            ControlFlowSchedulePolicy.ControlFlowScheduleInfoPolicy = true;

            FormPolicy.FormDebugPolicy = true;

            FormPolicy.FormInfoPolicy = true;

            FormBasePolicy.FormBaseDebugPolicy = true;

            FormBasePolicy.FormBaseInfoPolicy = true;

            FormLinePolicy.FormLineDebugPolicy = true;

            FormLinePolicy.FormLineInfoPolicy = true;

            return;
        }

        internal static void Manual()
        {
            Free(ProgramFolderSetSurface(Directory.GetCurrentDirectory()));

            ProgramModule programModule = ProgramModule.ProgramModuleAction();

            return;
        }

        internal static void Bundle()
        {
            try
            {
                Interop.Subf01();

                Interop.Reff02();

                Interop.Charf03();

                Interop.Escf04();

                Interop.Finf05();
            }
            catch (Exception exception)
            {
                String stringitem;

                stringitem = exception.ToString();

                Console.Clear();

                Console.Out.WriteLine(stringitem);

                Console.In.ReadLine();

                Environment.Exit(0);
            }
#if DEBUG
            Procedure();
#endif
            Manual();
#if DEBUG
            Raise();
#endif
            return;
        }

        internal static void Raise()
        {
            if (ProgramPolicy.ProgramInfoPolicy is true)
            {
                Render($"{ProgramCode.ObservableDirectory.Core}-{ProgramCode.ObservableDirectory.Info}-ProgramInfo", ProgramPolicy.ProgramArrayList.ToArray());
            }
            else
                "false".ToString();

            if (ControlFlowSchedulePolicy.ControlFlowScheduleInfoPolicy is true)
            {
                Render($"{ProgramCode.ObservableDirectory.Core}-{ProgramCode.ObservableDirectory.Info}-ControlFlowScheduleInfo", ControlFlowSchedulePolicy.ControlFlowScheduleArrayList.ToArray());
            }
            else
                "false".ToString();

            if (FormPolicy.FormInfoPolicy is true)
            {
                Render($"{ProgramCode.ObservableDirectory.Core}-{ProgramCode.ObservableDirectory.Info}-FormInfo", FormPolicy.FormArrayList.ToArray());
            }
            else
                "false".ToString();

            if (FormBasePolicy.FormBaseInfoPolicy is true)
            {
                Render($"{ProgramCode.ObservableDirectory.Core}-{ProgramCode.ObservableDirectory.Info}-FormBaseInfo", FormBasePolicy.FormBaseArrayList.ToArray());
            }
            else
                "false".ToString();

            if (FormLinePolicy.FormLineInfoPolicy is true)
            {
                Render($"{ProgramCode.ObservableDirectory.Core}-{ProgramCode.ObservableDirectory.Info}-FormLineInfo", FormLinePolicy.FormLineArrayList.ToArray());
            }
            else
                "false".ToString();

            Explorer(Directory.GetCurrentDirectory(), 1);

            return;
        }

        static Program()
        {
            return;
        }
    }
}
