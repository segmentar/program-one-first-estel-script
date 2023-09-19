using Core;

namespace Core
{
    using System;

    using System.Text;

    internal partial class Program
    {
        private void ConsoleSetupThreeThird(String lower, String[] split, Boolean hasLength)
        {
            var boolean__MORE_OR_EQUAL_THAN = (split.Length >= 2) is true;

            var boolean__EQUAL_THAN = (split.Length == 2) is true;

            if (boolean__MORE_OR_EQUAL_THAN is true)
            {
                var first = split[0];

                var second = split[1];

                Boolean isExternalCall;

                isExternalCall = true;

                isExternalCall = isExternalCall && hasLength is true;

                isExternalCall = isExternalCall && (first == "call") is true;

                isExternalCall = isExternalCall && (second.Length == 1) is true;

                if (isExternalCall is true)
                {
                    var length = (split.Length - 2);

                    String[] stringArray;

                    stringArray = new String[length];

                    Array.Copy(split, 2, stringArray, 0, length);

                    Char character;

                    character = second[0];

                    Interop.Clsf09OL(1, character, stringArray);
                }
                else
                    "false".ToString();
            }
            else
                "false".ToString();

            if (boolean__EQUAL_THAN is true)
            {
                var first = split[0];

                var second = split[1];

                String name, value;

                name = first;

                value = second;

                var reflect_BOOLEAN = default(Boolean);

                var reflect_INTEGER = default(Int32);

                try
                {
                    reflect_BOOLEAN = Boolean.Parse(value);

                } catch (Exception exception)
                {
                    exception.ToString();
                }

                try
                {
                    reflect_INTEGER = Int32.Parse(value);
                }
                catch (Exception exception)
                {
                    exception.ToString();
                }

                switch (name)
                {
                    case nameof(ArchitecturePageOneFirst.InputDirectory):
                        Specialize.SetInputDirectory(value, true);
                        break;

                    case nameof(ArchitecturePageOneFirst.OutputDirectory):
                        Specialize.SetOutputDirectory(value, true);
                        break;

                    case nameof(ArchitecturePageTwoSecond.ExtensionName):
                        ArchitecturePageTwoSecond.ExtensionName = value;
                        break;

                    case nameof(ArchitecturePageTwoSecond.EndianFormat):
                        ArchitecturePageTwoSecond.EndianFormat = reflect_BOOLEAN;
                        break;

                    case nameof(ArchitecturePageTwoSecond.StringCodec):
                        ArchitecturePageTwoSecond.StringCodec = Encoding.GetEncoding(reflect_INTEGER);
                        break;

                    case nameof(ArchitecturePageTwoSecond.ChunkSize):
                        ArchitecturePageTwoSecond.ChunkSize = reflect_INTEGER;
                        break;

                    case nameof(ArchitecturePageTwoSecond.StartBoundary):
                        ArchitecturePageTwoSecond.StartBoundary = reflect_INTEGER;
                        break;

                    default:
                        break;
                }
            }
            else
                "false".ToString();

            return;
        }
    }
}
