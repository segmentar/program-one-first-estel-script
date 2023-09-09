using Core;

namespace Core
{
    using System;

    public partial class FormLine
    {
        public static FormLine MakeFormLineDefault(String content, Boolean debug)
        {
            FormLine formLineResult = default;

            var result = new FormLineSequence(content, debug).Result;

            FormLinePolicy.FormLineArrayList.Add(result);

            formLineResult = result;

            return formLineResult;
        }
    }
}
