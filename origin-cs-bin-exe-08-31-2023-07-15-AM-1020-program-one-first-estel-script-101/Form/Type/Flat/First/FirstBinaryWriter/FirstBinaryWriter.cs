using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Form
    {
        public static void FirstBinaryWriter(MemoryStream memoryStream, Int32 headerAddress, Int32 contentAddress, Int32 localLineAddress, Int32 globalLineAddress)
        {
            BinaryWriter binaryWriter;

            using (binaryWriter = new BinaryWriter(memoryStream))
            {
                binaryWriter.Write(headerAddress);

                binaryWriter.Write(contentAddress);

                binaryWriter.Write(localLineAddress);

                binaryWriter.Write(globalLineAddress);

                binaryWriter.Close();

                binaryWriter.Dispose();
            }

            return;
        }
    }
}
