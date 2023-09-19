using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    internal partial class Program
    {
        internal static IList<String> ProgramObservableDirectorySet()
        {
            ICollection<String> collectionResult = default;

            collectionResult = new Collection<String>();

            foreach (String stringItem in Enum.GetNames(typeof(ProgramCode.SpecialDirectory)))
            {
                var path_DIRECTORY_full_name = Path.Combine(Directory.GetCurrentDirectory(), stringItem);

                collectionResult.Add(path_DIRECTORY_full_name);

                continue;
            }

            return new List<String>(collectionResult);
        }
    }
}