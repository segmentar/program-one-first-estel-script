using Core;

namespace Core
{
    using System;

    public partial class Control
    {
        public String File;

        public String Content;

        public String ContentSafe;

        public Control(String file, String content, String contentSafe)
        {
            this.File = file;

            this.Content = content;

            this.ContentSafe = contentSafe;

            return;
        }

        ~Control()
        {
            return;
        }
    }
}
