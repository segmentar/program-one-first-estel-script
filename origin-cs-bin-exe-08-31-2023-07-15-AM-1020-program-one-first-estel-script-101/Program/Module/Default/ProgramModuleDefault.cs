using Core;

namespace Core
{
    using System;

    public partial struct ProgramModule
    {
        public static ProgramModule ProgramModuleDefault()
        {
            Program program;

            program = Program.MakeProgramDefaultSurface();

            if (ArchitecturePageOneFirst.IsExternalCall is false)
            {
                program.SettingSetup();

                program.ConsoleSetup();
            }
            else
                "false".ToString();

            ProgramModule module;

            module = new ProgramModule();

            module.Program = program;

            module = ProgramModuleFunctionOne(module);

            module = ProgramModuleFunctionTwo(module);

            module = ProgramModuleFunctionThree(module);

            return module;
        }
    }
}
