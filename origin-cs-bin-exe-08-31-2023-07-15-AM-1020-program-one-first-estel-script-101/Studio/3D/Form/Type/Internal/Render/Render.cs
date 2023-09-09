using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Form
    {
        public String Render()
        {
            String stringResult = default;

            Boolean isRenderFileDefault;

            isRenderFileDefault = (Data.Measure.RenderFile == default) is true;

            if (isRenderFileDefault is true)
            {
                return stringResult;
            }
            else
                "false".ToString();

            if (File.Exists(Data.Measure.RenderFile))
            {
                File.Delete(Data.Measure.RenderFile);
            }
            else
            {
                Tuple<Int32, Int32, Int32, Int32> lengthTuple, addressTuple;

                lengthTuple = ForgeLengthTuple(this);

                addressTuple = ForgeAddressTuple(lengthTuple);

                Byte[] firstByteArray, lastByteArray;

                firstByteArray = FirstByteArray(addressTuple.Item1, addressTuple.Item2, addressTuple.Item3, addressTuple.Item4);

                lastByteArray = LastByteArray(Data.FormBase.HeaderArray, Data.FormBase.Content, Data.FormLine.LocalLineArray, Data.FormLine.GlobalLineArray);
               
                FileStream fileStream;

                using (fileStream = File.Create(Data.Measure.RenderFile))
                {
                    fileStream.Write(firstByteArray, 0, firstByteArray.Length);

                    fileStream.Seek(ArchitecturePageTwoSecond.StartBoundary, SeekOrigin.Begin);

                    fileStream.Write(lastByteArray, 0, lastByteArray.Length);

                    fileStream.Flush();

                    fileStream.Close();

                    fileStream.Dispose();
                }
            }

            return stringResult;
        }
    }
}
