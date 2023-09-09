using Core;

namespace Core
{
    using System;

    public partial struct ProgramModule
    {
        public static ProgramModule ProgramModuleAction()
        {
            ProgramModule module;

            module = ProgramModuleDefault();

            Form.RenderFormArray(module.Third.FormArray);

            Program.ProgramOutputDirectoryCopyVoid(module.First.WorkingDirectory);

            Interop.Outf07(Form.FormFilenameSetSurface(module.Third.FormArray));

            return module;
        } 
    }
}
