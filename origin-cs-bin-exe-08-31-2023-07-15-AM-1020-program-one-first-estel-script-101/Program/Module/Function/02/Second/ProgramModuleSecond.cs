using Core;

namespace Core
{
    using System;

    public partial class ProgramModuleFunctionSecond
    {
        public String[] FileArray;

        public String[] DirectoryArray;

        public ProgramModuleFunctionSecond(String[] fileArray, String[] directoryArray)
        {
            this.FileArray = fileArray;

            this.DirectoryArray = directoryArray;

            return;
        }

        ~ProgramModuleFunctionSecond()
        {
            return;
        }
    }
}
