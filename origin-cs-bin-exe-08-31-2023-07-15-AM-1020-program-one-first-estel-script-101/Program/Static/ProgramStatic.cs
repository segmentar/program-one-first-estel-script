using Core;

namespace Core
{
    using System;

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
            try
            {
                Interop.Lenf01IL();

                Interop.Linf02IL();

                Interop.Subf03IL();

                if (ArchitecturePageOneFirst.HasLinger is true)
                {
                    Interop.Reff04IL();

                    Interop.Debf05IL();

                    Interop.Chrf06IL();

                    Interop.Escf07IL();

                    Interop.Finf08IL();
                }
                else
                    "false".ToString();
            }
            catch (Exception exception)
            {
                exception.ToString();

                Console.Clear();

                Console.Out.WriteLine(exception);

                Console.In.ReadLine();
            }

            ProgramModule programModule = ProgramModule.ProgramModuleAction(true, true, true, true, true);

            return;
        }

        internal static void Bundle()
        {
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
                Render($"{ProgramCode.SpecialDirectory.Core_Info}-ProgramInfo", ProgramPolicy.ProgramArrayList.ToArray());
            }
            else
                "false".ToString();

            if (ControlFlowSchedulePolicy.ControlFlowScheduleInfoPolicy is true)
            {
                Render($"{ProgramCode.SpecialDirectory.Core_Info}-ControlFlowScheduleInfo", ControlFlowSchedulePolicy.ControlFlowScheduleArrayList.ToArray());
            }
            else
                "false".ToString();

            if (FormPolicy.FormInfoPolicy is true)
            {
                Render($"{ProgramCode.SpecialDirectory.Core_Info}-FormInfo", FormPolicy.FormArrayList.ToArray());
            }
            else
                "false".ToString();

            if (FormBasePolicy.FormBaseInfoPolicy is true)
            {
                Render($"{ProgramCode.SpecialDirectory.Core_Info}-FormBaseInfo", FormBasePolicy.FormBaseArrayList.ToArray());
            }
            else
                "false".ToString();

            if (FormLinePolicy.FormLineInfoPolicy is true)
            {
                Render($"{ProgramCode.SpecialDirectory.Core_Info}-FormLineInfo", FormLinePolicy.FormLineArrayList.ToArray());
            }
            else
                "false".ToString();

            return;
        }

        static Program()
        {
            return;
        }
    }
}
