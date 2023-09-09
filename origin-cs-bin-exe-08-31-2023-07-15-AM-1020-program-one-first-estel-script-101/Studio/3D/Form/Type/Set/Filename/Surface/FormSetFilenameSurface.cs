using Core;

namespace Core
{
    using System;

    public partial class Form
    {
        public static String[] FormFilenameSetSurface(Form[] formArray)
        {
            String[] arrayResult = default;

            var list = FormFilenameSet(formArray);

            String[] stringArray;

            stringArray = new String[list.Count];

            list.CopyTo(stringArray, 0);

            arrayResult = stringArray;

            return arrayResult;
        }
    }
}
