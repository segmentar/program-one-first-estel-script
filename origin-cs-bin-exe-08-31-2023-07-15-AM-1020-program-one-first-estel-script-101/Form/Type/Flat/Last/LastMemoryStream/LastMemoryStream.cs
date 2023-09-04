using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Form
    {
        public static MemoryStream LastMemoryStream(String[] headerArray, String content, String[] localLineArray, String[] globalLineArray)
        {
            MemoryStream memoryStreamResult = default;

            MemoryStream memoryStream;

            memoryStream = new MemoryStream();

            LastBinaryWriter(memoryStream, headerArray, content, localLineArray, globalLineArray);

            memoryStreamResult = memoryStream;

            return memoryStreamResult;
        }
    }
}
