using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        private String ConsoleDescriptor()
        {
            String stringResult = default;

            var size_BIT = (8 * 1) + (7 * 32);

            var size_BYTE = (size_BIT / 8);

            ProgramApplyFullExtensionVoid();

            stringResult = String.Join('\n'.ToString(), new String[] {

                String.Empty,
                String.Empty + '\t' + 'O' + ':' +  $"This is `{ProgramDefaultPageTwoSecond.ProgramNameDefault}`" + ' ' + '.',
                String.Empty,
                String.Empty + '\t' + 'o' + ':' + ' ' + "Enter name and value to modify variable" + ' ' + '.',
                String.Empty,
                String.Empty + '\t' + 'o' + ':' + ' ' + $"Size of data header is {size_BIT} bit(s) or {size_BYTE} byte(s)" + ' ' + '.',
                String.Empty,
                String.Empty + '\t' + 'o' + ':' + ' ' + "Enter `escape` to run and exit" + ' ' + '.',
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + nameof(ArchitecturePageOneFirst.OutputDirectory) + ':' + ' ' + ArchitecturePageOneFirst.OutputDirectory,
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + nameof(ArchitecturePageTwoSecond.ExtensionName) + ':' + ' ' + ArchitecturePageTwoSecond.ExtensionName,
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + "endian-unsigned-integer-bit-8" + ' ' + nameof(ArchitecturePageTwoSecond.EndianFormat) + ':' + ' ' + ArchitecturePageTwoSecond.EndianFormat,
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + "endian-unsigned-integer-bit-32" + ' ' + nameof(ArchitecturePageTwoSecond.StringCodec) + ':' + ' ' + ArchitecturePageTwoSecond.StringCodec,
                String.Empty, 
                String.Empty + '\t' + '~' + ' ' + "endian-unsigned-integer-bit-32" + ' ' + nameof(ArchitecturePageTwoSecond.ChunkSize) + ':' + ' ' + ArchitecturePageTwoSecond.ChunkSize,
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + "endian-unsigned-integer-bit-32" + ' ' + nameof(ArchitecturePageTwoSecond.StartBoundary) + ':' + ' ' + ArchitecturePageTwoSecond.StartBoundary,
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + "endian-unsigned-integer-bit-32" + ' ' + "header-address" + ':' + ' ' + "<automatic>",
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + "endian-unsigned-integer-bit-32" + ' ' + "content-address" + ':' + ' ' + "<automatic>",
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + "endian-unsigned-integer-bit-32" + ' ' + "local-line-array-address" + ':' + ' ' + "<automatic>",
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + "endian-unsigned-integer-bit-32" + ' ' + "global-line-array-address" + ':' + ' ' + "<automatic>",
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + nameof(ArchitecturePageTwoSecond.FullExtension) + ':' + ' ' + ArchitecturePageTwoSecond.FullExtension,
                String.Empty,
                String.Empty + '\t' + "Prompt" + ':' + ' ',
                String.Empty
            });

            return stringResult;
        }
    }
}
