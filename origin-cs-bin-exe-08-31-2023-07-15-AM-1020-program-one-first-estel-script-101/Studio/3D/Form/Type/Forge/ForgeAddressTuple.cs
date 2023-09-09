using Core;

namespace Core
{
    using System;

    public partial class Form
    {
        public static Tuple<Int32, Int32, Int32, Int32> ForgeAddressTuple(Tuple<Int32, Int32, Int32, Int32> lengthTuple)
        {
            Tuple<Int32, Int32, Int32, Int32> tupleResult = default;

            Int32 headerAddress, contentAddress, localLineAddress, globalLineAddress;

            headerAddress = ArchitecturePageTwoSecond.StartBoundary;

            contentAddress = ArchitecturePageTwoSecond.StartBoundary + lengthTuple.Item1;

            localLineAddress = ArchitecturePageTwoSecond.StartBoundary + lengthTuple.Item1 + lengthTuple.Item2;
             
            globalLineAddress = ArchitecturePageTwoSecond.StartBoundary + lengthTuple.Item1 + lengthTuple.Item2 + lengthTuple.Item3;

            Tuple<Int32, Int32, Int32, Int32> tuple;

            tuple = new Tuple<Int32, Int32, Int32, Int32>(headerAddress, contentAddress, localLineAddress, globalLineAddress);

            tupleResult = tuple;

            return tupleResult;
        }
    }
}
