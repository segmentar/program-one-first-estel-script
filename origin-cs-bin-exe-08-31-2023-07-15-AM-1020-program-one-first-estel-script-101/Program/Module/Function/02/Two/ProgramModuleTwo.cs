using Core;

namespace Core
{
    using System;

    public partial struct ProgramModule
    {
        public static ProgramModule ProgramModuleFunctionTwo(ProgramModule module)
        {
            var tuple = module.Program.ObserveTuple__FILE_DIRECTORY(module.First.CurrentDirectory);

            String[] fileArray, directoryArray;

            fileArray = tuple.Item1;

            directoryArray = tuple.Item2;

            ProgramModuleFunctionSecond second;

            second = new ProgramModuleFunctionSecond(fileArray, directoryArray);

            module.Second = second;

            return module;
        }
    }
}
