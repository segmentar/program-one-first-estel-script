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
        internal static IList<String> ProgramDirectorySet(String directory)
        {
            ICollection<String> collectionResult = default;

            collectionResult = new Collection<String>();

            String directoryItem;

            foreach (var item_DIRECTORY in Directory.GetDirectories(directory))
            {
                directoryItem = item_DIRECTORY;

                collectionResult.Add(directoryItem);

                foreach (var item__DIRECTORY_DIRECTORY in Directory.GetDirectories(directoryItem))
                {
                    directoryItem = item__DIRECTORY_DIRECTORY;

                    collectionResult.Add(directoryItem);

                    continue;
                }

                continue;
            }

            return new List<String>(collectionResult);
        }
    }
}
