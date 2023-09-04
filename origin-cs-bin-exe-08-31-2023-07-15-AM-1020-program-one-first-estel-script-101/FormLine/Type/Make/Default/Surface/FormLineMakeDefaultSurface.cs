using Core;

namespace Core
{
    using System;

    public partial class FormLine
    {
        public static FormLine MakeFormLineDefaultSurface(String content)
        {
            FormLine formLineResult = default;

            formLineResult = MakeFormLineDefault(content, FormPolicy.FormDebugPolicy);

            return formLineResult;
        }
    }
}
