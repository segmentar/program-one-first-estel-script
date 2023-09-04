using Core;

namespace Core
{
    using System;

    public partial struct ProgramModule
    {
        public static ProgramModule ProgramModuleFunctionOne(ProgramModule module)
        {
            var tuple = module.Program.CurrentSetup__FILE_DIRECTORY();

            String workingDirectory;

            workingDirectory = Program.ForgeWorkingDirectory(tuple.Item2);

            ProgramModuleFunctionFirst first;

            first = new ProgramModuleFunctionFirst(tuple.Item1, tuple.Item2, workingDirectory);

            module.First = first;

            return module;
        }
    }
}
