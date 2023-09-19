using Core;

namespace Core
{
    using System;

    public partial struct ProgramModule
    {
        public static ProgramModule ProgramModuleFunctionTwo(ProgramModule module)
        {
            Tuple<String[], String[]> observableTuple;

            if (ArchitecturePageOneFirst.HasInputDirectory)
            {
                observableTuple = Program.ForgeObserveTuple__FILE_DIRECTORY(ArchitecturePageOneFirst.InputDirectory);
            }
            else
            {
                observableTuple = Program.ForgeObserveTuple__FILE_DIRECTORY(module.First.CurrentDirectory);
            }

            String[] fileArray, directoryArray;

            fileArray = observableTuple.Item1;

            directoryArray = observableTuple.Item2;

            ProgramModuleFunctionSecond second;

            second = new ProgramModuleFunctionSecond(fileArray, directoryArray);

            module.Second = second;

            return module;
        }
    }
}
