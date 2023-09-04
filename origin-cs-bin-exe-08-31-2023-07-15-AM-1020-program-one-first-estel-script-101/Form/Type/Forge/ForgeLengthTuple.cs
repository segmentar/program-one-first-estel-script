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

            headerLength = headerLength + Architecture.ChunkSize;

            headerLength = headerLength + (Architecture.ChunkSize * form.Data.FormBase.HeaderArray.Length);

            contentLength = 0;

            contentLength = contentLength + Architecture.ChunkSize;

            localLineLength = 0;

            localLineLength = localLineLength + Architecture.ChunkSize;

            localLineLength = localLineLength + (Architecture.ChunkSize * form.Data.FormLine.LocalLineArray.Length);

            globalLineLength = 0;

            globalLineLength = globalLineLength + Architecture.ChunkSize;

            globalLineLength = globalLineLength + (Architecture.ChunkSize * form.Data.FormLine.GlobalLineArray.Length);

            Tuple<Int32, Int32, Int32, Int32> lengthTuple;

            lengthTuple = new Tuple<Int32, Int32, Int32, Int32>(headerLength, contentLength, localLineLength, globalLineLength);

            tupleResult = lengthTuple;

            return tupleResult;
        }
    }
}
