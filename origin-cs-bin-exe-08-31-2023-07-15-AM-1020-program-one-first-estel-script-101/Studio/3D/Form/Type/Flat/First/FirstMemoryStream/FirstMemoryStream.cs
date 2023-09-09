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

            endianFormatByteArray = BitConverter.GetBytes(ArchitecturePageTwoSecond.EndianFormat);

            stringCodecByteArray = BitConverter.GetBytes(ArchitecturePageTwoSecond.StringCodec.CodePage);

            chunkSizeByteArray = BitConverter.GetBytes(ArchitecturePageTwoSecond.ChunkSize);

            startBounaryByteArray = BitConverter.GetBytes(ArchitecturePageTwoSecond.StartBoundary);

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
