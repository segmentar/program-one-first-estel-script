﻿using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class FormLine
    {
        public static IList<String> FormLineLocalLineSet(String value)
        {
            ICollection<String> collectionResult = default;

            collectionResult = new Collection<String>();

            var split = value.Split(new String[] { Convert.ToChar(10).ToString() }, StringSplitOptions.None);

            foreach (String stringItem in split)
            {
                var safe = ForgeSafeString(stringItem);

                String[] stringArray;

                stringArray = safe.Split(default(String[]), StringSplitOptions.RemoveEmptyEntries);

                if ((stringArray.Length == 0) is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                var length = (stringArray.Length - 1);

                var last = stringArray[length];

                var period = Convert.ToChar(46);

                Boolean isLastPeriod;

                isLastPeriod = (last == period.ToString()) is true;

                if (isLastPeriod is false)
                {
                    continue;
                }
                else
                    "false".ToString();

                var array = new String[length];

                Array.Copy(stringArray, 0, array, 0, length);

                var whitespace = Convert.ToChar(32);

                var join = String.Join(whitespace.ToString(), array);

                collectionResult.Add(join);

                continue;
            }

            return new List<String>(collectionResult);
        }
    }
}
