using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial struct ProgramModule
    {
        public static ProgramModule ProgramModuleAction(Boolean free, Boolean render, Boolean copy, Boolean output, Boolean explorer)
        {
            ProgramModule module;

            if (free is true)
            {
                Program.Free(Program.ProgramFolderSetSurface(Directory.GetCurrentDirectory()));
            }
            else
                "false".ToString();

            module = ProgramModuleDefault();

            if (render is true)
            {
                Form.RenderFormArray(module.Third.FormArray);
            }
            else
                "false".ToString();

            if (copy is true)
            {
                Program.ProgramOutputDirectoryCopyVoid(module.First.WorkingDirectory);
            }
            else
                "false".ToString();

            if (output is true)
            {
                Interop.Outf10OL(Form.FormFilenameSetSurface(module.Third.FormArray));
            }
            else
                "false".ToString();

            if (explorer is true)
            {
                Program.Explorer(Directory.GetCurrentDirectory(), 1);
            }
            else
                "false".ToString();

            return module;
        } 
    }
}
