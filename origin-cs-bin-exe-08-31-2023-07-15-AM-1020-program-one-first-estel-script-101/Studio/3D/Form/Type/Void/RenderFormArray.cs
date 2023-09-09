using Core;

namespace Core
{
    using System;

    public partial class Form
    {
        public static void RenderFormArray(Form[] formArray)
        {
            foreach (Form form in formArray)
            {
                form.Render();

                continue;
            }

            return;
        }
    }
}
