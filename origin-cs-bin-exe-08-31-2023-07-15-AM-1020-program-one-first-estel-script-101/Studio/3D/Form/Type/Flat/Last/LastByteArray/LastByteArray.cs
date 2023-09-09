using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Form
    {
        public static Byte[] LastByteArray(String[] headerArray, String content, String[] localLineArray, String[] globalLineArray)
        {
            Byte[] arrayResult = default;

            MemoryStream memoryStream;

            using (memoryStream = LastMemoryStream(headerArray, content, localLineArray, globalLineArray))
            {
                arrayResult = memoryStream.ToArray();

                memoryStream.Close();

                memoryStream.Dispose();
            }

            return arrayResult;
        }
    }
}
