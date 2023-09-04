using Core;

namespace Core
{
    using System;

    public partial struct FormData
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
                String.Empty + nameof(Form) + ' ' + "::" + ' ' + nameof(FormData) + ' ' + '{',
                String.Empty + '.' + "data",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(FormBase) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(FormLine) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(PositionArray) + ':' + ' ' + ". . ." + ' ' + $"[{PositionArray.Length}]",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(FormBase) + ':',
                String.Empty + FormBase,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(FormLine) + ':',
                String.Empty + FormLine,
                String.Empty,
                String.Empty + '~' + "30" + ' ' + nameof(PositionArray) + ':',
                String.Empty + String.Join('\n'.ToString(), PositionArray)
            });
        }
    }
}
