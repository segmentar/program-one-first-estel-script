using Core;

namespace Core
{
    using System;

    public partial class FormLine
    {
        public FormLine(String[] localLineArray, String[] globalLineArray, Boolean debug)
        {
            this.LocalLineArray = localLineArray;

            this.GlobalLineArray = globalLineArray;

            if (debug is true)
            {
                this.IsDebug = true;
            }
            else
                "false".ToString();

            return;
        }
    }
}
