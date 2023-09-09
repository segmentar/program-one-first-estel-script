using Core;

namespace Core
{
    using System;

    public partial class Form
    {
        public static Tuple<Int32, Int32, Int32, Int32> ForgeLengthTuple(Form form)
        {
            Tuple<Int32, Int32, Int32, Int32> tupleResult = default;

            Int32 headerLength, contentLength, localLineLength, globalLineLength;

            headerLength = 0;

            headerLength = headerLength + ArchitecturePageTwoSecond.ChunkSize;

            headerLength = headerLength + (ArchitecturePageTwoSecond.ChunkSize * form.Data.FormBase.HeaderArray.Length);

            contentLength = 0;

            contentLength = contentLength + ArchitecturePageTwoSecond.ChunkSize;

            localLineLength = 0;

            localLineLength = localLineLength + ArchitecturePageTwoSecond.ChunkSize;

            localLineLength = localLineLength + (ArchitecturePageTwoSecond.ChunkSize * form.Data.FormLine.LocalLineArray.Length);

            globalLineLength = 0;

            globalLineLength = globalLineLength + ArchitecturePageTwoSecond.ChunkSize;

            globalLineLength = globalLineLength + (ArchitecturePageTwoSecond.ChunkSize * form.Data.FormLine.GlobalLineArray.Length);

            Tuple<Int32, Int32, Int32, Int32> lengthTuple;

            lengthTuple = new Tuple<Int32, Int32, Int32, Int32>(headerLength, contentLength, localLineLength, globalLineLength);

            tupleResult = lengthTuple;

            return tupleResult;
        }
    }
}
