using Core;

namespace Core
{
    using System;

    public partial class FormLine
    {
        public static String[] FormLineLocalLineSetSurface(String value)
        {
            String[] arrayResult = default;

            var list = FormLineLocalLineSet(value);

            String[] stringArray;

            stringArray = new String[list.Count];

            list.CopyTo(stringArray, 0);

            arrayResult = stringArray;

            return arrayResult;
        }
    }
}
