using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Form
    {
        public static MemoryStream FirstMemoryStream(Int32 headerAddress, Int32 contentAddress, Int32 localLineAddress, Int32 globalLineAddress)
        {
            MemoryStream memoryStreamResult = default;

            Byte[] endianFormatByteArray, stringCodecByteArray, chunkSizeByteArray, startBounaryByteArray;

            endianFormatByteArray = BitConverter.GetBytes(Architecture.EndianFormat);

            stringCodecByteArray = BitConverter.GetBytes(Architecture.StringCodec.CodePage);

            chunkSizeByteArray = BitConverter.GetBytes(Architecture.ChunkSize);

            startBounaryByteArray = BitConverter.GetBytes(Architecture.StartBoundary);

            MemoryStream memoryStream;

            memoryStream = new MemoryStream();

            memoryStream.Write(endianFormatByteArray, 0, endianFormatByteArray.Length);

            memoryStream.Write(stringCodecByteArray, 0, stringCodecByteArray.Length);

            memoryStream.Write(chunkSizeByteArray, 0, chunkSizeByteArray.Length);

            memoryStream.Write(startBounaryByteArray, 0, startBounaryByteArray.Length);

            FirstBinaryWriter(memoryStream, headerAddress, contentAddress, localLineAddress, globalLineAddress);

            memoryStreamResult = memoryStream;

            return memoryStreamResult;
        }
    }
}
