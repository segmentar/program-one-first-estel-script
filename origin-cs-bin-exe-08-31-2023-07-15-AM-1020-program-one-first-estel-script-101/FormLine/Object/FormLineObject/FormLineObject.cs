using Core;

namespace Core
{
    using System;

    public partial class FormLine
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(FormLine) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "compress",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '.' + "compress-raw",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(LocalLineArray) + ':' + ' ' + ". . ." + ' ' + $"<{LocalLineArray.Length}>",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(GlobalLineArray) + ':' + ' ' + ". . ." + ' ' + $"<{GlobalLineArray.Length}>",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + nameof(LocalLineArray) + ':',
                String.Empty + String.Join('\n'.ToString(), LocalLineArray),
                String.Empty,
                String.Empty + '~' + nameof(GlobalLineArray) + ':',
                String.Empty + String.Join('\n'.ToString(), GlobalLineArray)
            });
        }
    }
}
