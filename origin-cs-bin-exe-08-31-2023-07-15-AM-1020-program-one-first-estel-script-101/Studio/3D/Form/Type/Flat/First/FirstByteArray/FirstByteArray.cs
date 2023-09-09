using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Form
    {
        public static Byte[] FirstByteArray(Int32 headerAddress, Int32 contentAddress, Int32 localLineAddress, Int32 globalLineAddress)
        {
            Byte[] arrayResult = default;

            MemoryStream memoryStream;

            using (memoryStream = FirstMemoryStream(headerAddress, contentAddress, localLineAddress, globalLineAddress))
            {
                arrayResult = memoryStream.ToArray();

                memoryStream.Close();

                memoryStream.Dispose();
            }

            return arrayResult;
        }
    }
}
