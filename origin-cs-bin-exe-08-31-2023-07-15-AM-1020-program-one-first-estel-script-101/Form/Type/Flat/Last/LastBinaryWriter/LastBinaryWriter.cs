using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Form
    {
        public static void LastBinaryWriter(MemoryStream memoryStream, String[] headerArray, String content, String[] localLineArray, String[] globalLineArray)
        {
            BinaryWriter binaryWriter;

            var position = 1;

            using (binaryWriter = new BinaryWriter(memoryStream))
            {
                var array_HEADER = headerArray;

                var array_LOCAL_LINE = localLineArray;

                var array_GLOBAL_LINE = globalLineArray;

                var length_HEADER = Convert.ToInt32(array_HEADER.Length);

                var length_LOCAL_LINE = Convert.ToInt32(localLineArray.Length);

                var length_GLOBAL_LINE = Convert.ToInt32(globalLineArray.Length);

                goto section_HEADER;

                section_HEADER:
                {
                    var seek_ONE_FIRST = ForgeSeekPositionAdvance(binaryWriter.BaseStream, position);

                    position = seek_ONE_FIRST;

                    binaryWriter.Write(length_HEADER);

                    foreach (String stringItem in array_HEADER)
                    {
                        var seek_TWO_SECOND = ForgeSeekPositionAdvance(binaryWriter.BaseStream, position);

                        position = seek_TWO_SECOND;

                        binaryWriter.Write(Architecture.StringCodec.GetBytes(stringItem));

                        continue;
                    }
                }

                goto section_CONTENT;

                section_CONTENT:
                {
                    var seek_THREE_THIRD = ForgeSeekPositionAdvance(binaryWriter.BaseStream, position);

                    position = seek_THREE_THIRD;

                    binaryWriter.Write(Architecture.StringCodec.GetBytes(content));
                }

                goto section_LOCAL_LINE;

                section_LOCAL_LINE:
                {
                    var seek_FOUR_FOURTH = ForgeSeekPositionAdvance(binaryWriter.BaseStream, position);

                    position = seek_FOUR_FOURTH;

                    binaryWriter.Write(length_LOCAL_LINE);

                    foreach (String stringItem in array_LOCAL_LINE)
                    {
                        var seek_FIVE_FIFTH = ForgeSeekPositionAdvance(binaryWriter.BaseStream, position);

                        position = seek_FIVE_FIFTH;

                        binaryWriter.Write(Architecture.StringCodec.GetBytes(stringItem));

                        continue;
                    }
                }

                goto section_GLOBAL_LINE;

                section_GLOBAL_LINE:
                {
                    var seek_SIX_SIXTH = ForgeSeekPositionAdvance(binaryWriter.BaseStream, position);

                    position = seek_SIX_SIXTH;

                    binaryWriter.Write(length_GLOBAL_LINE);

                    foreach (String stringItem in array_GLOBAL_LINE)
                    {
                        var seek_SEVEN_SEVENTH = ForgeSeekPositionAdvance(binaryWriter.BaseStream, position);

                        position = seek_SEVEN_SEVENTH;

                        binaryWriter.Write(Architecture.StringCodec.GetBytes(stringItem));

                        continue;
                    }
                }

                binaryWriter.Close();

                binaryWriter.Dispose();
            }

            return;
        }
    }
}
