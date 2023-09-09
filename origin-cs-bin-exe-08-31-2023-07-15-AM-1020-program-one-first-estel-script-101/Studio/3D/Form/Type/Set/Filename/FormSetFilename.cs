using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Form
    {
        public static IList<String> FormFilenameSet(Form[] formArray)
        {
            ICollection<String> collectionResult = default;

            collectionResult = new Collection<String>();

            foreach (Form form in formArray)
            {
                String stringItem;

                stringItem = form.Data.Measure.RenderFile;

                collectionResult.Add(stringItem);

                continue;
            }

            return new List<String>(collectionResult);
        }
    }
}
