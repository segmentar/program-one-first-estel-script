using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        private String ConsoleDescriptor()
        {
            String stringResult = default;

            var size_BIT = (8 * 1) + (5 * 32);

            var size_BYTE = (size_BIT / 8);

            ApplyFullExtensionVoid();

            stringResult = String.Join('\n'.ToString(), new String[] {

                String.Empty,
                String.Empty + '\t' + $"This is `{ProgramImmutable.ProgramName}`" + ' ' + '.',
                String.Empty,
                String.Empty + '\t' + 'O' + ':' + ' ' + "Enter name and value to modify variable" + ' ' + '.',
                String.Empty,
                String.Empty + '\t' + 'o' + ':' + ' ' + $"Size of data header is {size_BIT} bit(s) or {size_BYTE} byte(s)" + ' ' + '.',
                String.Empty,
                String.Empty + '\t' + 'o' + ':' + ' ' + "Enter `escape` to run and exit" + ' ' + '.',
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + nameof(Architecture.ExtensionName) + ':' + ' ' + Architecture.ExtensionName,
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + "endian-unsigned-integer-bit-8" + ' ' + nameof(Architecture.EndianFormat) + ':' + ' ' + Architecture.EndianFormat,
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + "endian-unsigned-integer-bit-32" + ' ' + nameof(Architecture.StringCodec) + ':' + ' ' + Architecture.StringCodec,
                String.Empty, 
                String.Empty + '\t' + '~' + ' ' + "endian-unsigned-integer-bit-32" + ' ' + nameof(Architecture.ChunkSize) + ':' + ' ' + Architecture.ChunkSize,
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + "endian-unsigned-integer-bit-32" + ' ' + nameof(Architecture.StartBoundary) + ':' + ' ' + Architecture.StartBoundary,
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + "endian-unsigned-integer-bit-32" + ' ' + "local-line-array-address" + ':' + ' ' + "<automatic>",
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + "endian-unsigned-integer-bit-32" + ' ' + "global-line-array-address" + ':' + ' ' + "<automatic>",
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + nameof(Architecture.FullExtension) + ':' + ' ' + Architecture.FullExtension,
                String.Empty,
                String.Empty + '\t' + "Prompt" + ':' + ' ',
                String.Empty
            });

            return stringResult;
        }
    }
}
