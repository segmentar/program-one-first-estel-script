using Core;

namespace Core
{
    using System;

    public partial class FormLineSequence
    {
        public FormLine Result { get; set; } = default;

        public FormLineSequence(String content, Boolean debug)
        {
            Debug(content, debug);

            String[] localLineArray, globalLineArray;

            localLineArray = FormLine.FormLineLocalLineSetSurface(content);

            globalLineArray = FormLine.FormLineGlobalLineSetSurface(content);

            FormLine formLine;

            formLine = new FormLine(localLineArray, globalLineArray, debug);

            this.Result = formLine;

            return;
        }

        ~FormLineSequence()
        {
            return;
        }
    }
}
