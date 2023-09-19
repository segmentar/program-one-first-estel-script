using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        private String ConsoleDescriptor()
        {
            String stringResult = default;

            var size_BIT__HEADER_DATA = (8 * 1) + (3 * 32);

            var size_BIT__HEADER_ADDRESS = (4 * 32);

            var size_BIT = (size_BIT__HEADER_DATA + size_BIT__HEADER_ADDRESS);

            var size_BYTE = (size_BIT / 8);

            ProgramApplyFullExtensionVoid();

            stringResult = String.Join('\n'.ToString(), new String[] {

                String.Empty,
                String.Empty + '\t' + $"This is `{ImmutablePageOneFirst.ProgramName}`" + ' ' + '.',
                String.Empty,
                String.Empty + '\t' + 'o' + ':' + ' ' + "Enter name and value to modify variable" + ' ' + '.',
                String.Empty,
                String.Empty + '\t' + 'o' + ':' + ' ' + $"Size of data header is {size_BIT} bit(s) or {size_BYTE} byte(s)" + ' ' + '.',
                String.Empty,
                String.Empty + '\t' + 'x' + ':' + ' ' + "Enter `escape` to run and exit" + ' ' + '.',
                String.Empty,
                String.Empty + '\t' + 'O' + ' ' + nameof(ArchitecturePageOneFirst.EscapeCharacter) + ':' + ' ' + ArchitecturePageOneFirst.EscapeCharacter,
                String.Empty,
                String.Empty + '\t' + 'O' + ' ' + nameof(ArchitecturePageOneFirst.HasEscapeCharacter) + ':' + ' ' + ArchitecturePageOneFirst.HasEscapeCharacter,
                String.Empty,
                String.Empty + '\t' + 'O' + ' ' + nameof(ArchitecturePageOneFirst.HasInputDirectory) + ':' + ' ' + ArchitecturePageOneFirst.HasInputDirectory,
                String.Empty,
                String.Empty + '\t' + 'O' + ' ' + nameof(ArchitecturePageOneFirst.HasOutputDirectory) + ':' + ' ' + ArchitecturePageOneFirst.HasOutputDirectory,
                String.Empty,
                String.Empty + '\t' + 'O' + ' ' + nameof(ArchitecturePageOneFirst.InputDirectory) + ':' + ' ' + ArchitecturePageOneFirst.InputDirectory,
                String.Empty,
                String.Empty + '\t' + 'O' + ' ' + nameof(ArchitecturePageOneFirst.OutputDirectory) + ':' + ' ' + ArchitecturePageOneFirst.OutputDirectory,
                String.Empty,
                String.Empty + '\t' + 'O' + ' ' + nameof(ArchitecturePageTwoSecond.ExtensionName) + ':' + ' ' + ArchitecturePageTwoSecond.ExtensionName,
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + '*' + "endian-unsigned-integer-bit-8" + ' ' + "endian-format" + '^' + ' ' + nameof(ArchitecturePageTwoSecond.EndianFormat) + ':' + ' ' + ArchitecturePageTwoSecond.EndianFormat,
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + '*' + "endian-unsigned-integer-bit-32" + ' ' + "string-codec" + '^' + ' ' + nameof(ArchitecturePageTwoSecond.StringCodec) + ':' + ' ' + ArchitecturePageTwoSecond.StringCodec,
                String.Empty, 
                String.Empty + '\t' + '~' + ' ' + '*' + "endian-unsigned-integer-bit-32" + ' ' + "chunk-size" + '^' + ' ' + nameof(ArchitecturePageTwoSecond.ChunkSize) + ':' + ' ' + ArchitecturePageTwoSecond.ChunkSize,
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + '*' + "endian-unsigned-integer-bit-32" + ' ' + "start-boundary" + '^' + ' ' + nameof(ArchitecturePageTwoSecond.StartBoundary) + ':' + ' ' + ArchitecturePageTwoSecond.StartBoundary,
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + '*' +  "endian-unsigned-integer-bit-32" + ' ' + "header-address" + '^' + ' ' + "<automatic>",
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + '*' + "endian-unsigned-integer-bit-32" + ' ' + "content-address" + '^' + ' ' + "<automatic>",
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + '*' + "endian-unsigned-integer-bit-32" + ' ' + "local-line-array-address^" + '^' + ' ' + "<automatic>",
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + '*' + "endian-unsigned-integer-bit-32" + ' ' + "global-line-array-address" + '^' + ' ' + "<automatic>",
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
