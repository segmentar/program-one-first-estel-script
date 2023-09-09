using Core;

namespace Core
{
    using System;

    public partial class FormBaseSequence
    {
        public FormBase Result { get; set; } = default;

        public FormBaseSequence(ControlFlowSchedule controlFlowSchedule, Int32[] positionArray, Boolean debug)
        {
            Debug(debug);

            String[] headerArray, headerArraySafe;
            
            String content, contentSafe;

            headerArray = FormBase.ForgeHeaderArray(controlFlowSchedule, positionArray);

            headerArraySafe = Program.SafeArray(headerArray);

            content = FormBase.ForgeContent(controlFlowSchedule, positionArray);

            contentSafe = Program.SafeString(content);

            FormBase formBase;

            formBase = new FormBase(headerArray, headerArraySafe, content, contentSafe, debug);

            this.Result = formBase;

            return;
        }

        ~FormBaseSequence()
        {
            return;
        }
    }
}
