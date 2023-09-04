using Core;

namespace Core
{
    using System;

    public partial class Control
    {
        public String File;

        public String Content;

        public String ContentSafe;

        public String RenderFile;

        public Control(String file, String content, String contentSafe, String renderFile)
        {
            this.File = file;

            this.Content = content;

            this.ContentSafe = contentSafe;

            this.RenderFile = renderFile;

            return;
        }

        ~Control()
        {
            return;
        }
    }
}
