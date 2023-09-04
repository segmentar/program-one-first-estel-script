using Core;

namespace Core
{
    using System;

    public partial class Form
    {
        public Form(ControlFlowSchedule controlFlowSchedule, FormBase formBase, FormLine formLine, Int32[] positionArray, Boolean debug)
        {
            FormData data;

            data = new FormData();

            data.ControlFlowSchedule = controlFlowSchedule;

            data.FormBase = formBase;

            data.FormLine = formLine;

            data.PositionArray = positionArray;

            if (debug is true)
            {
                data.IsDebug = true;
            }
            else
                "false".ToString();

            this.Data = data;

            return;
        }
    }
}
