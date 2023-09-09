using Core;

namespace Core
{
    using System;

    public partial class FormBase
    {
        public FormBase(String[] headerArray, String[] headerArraySafe, String content, String contentSafe, Boolean debug)
        {
            this.HeaderArray = headerArray;

            this.HeaderArraySafe = headerArraySafe;

            this.Content = content;

            this.ContentSafe = contentSafe;

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
