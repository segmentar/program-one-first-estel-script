using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal Tuple<String[], String[]> ObserveTuple__FILE_DIRECTORY(String directory)
        {
            Tuple<String[], String[]> tupleResult = default;

            var array_DIRECTORY = ProgramDirectorySetSurface(directory);

            var array_FILE = ProgramFileSetSurface(array_DIRECTORY);

            Tuple<String[], String[]> observeTuple;

            observeTuple = new Tuple<String[], String[]>(array_FILE, array_DIRECTORY);

            tupleResult = observeTuple;

            return tupleResult;
        }
    }
}
