using Core;

namespace Core
{
    using System;

    public partial class FormBase
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(FormBase) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "compress",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '.' + "compress-raw",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(HeaderArray) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(HeaderArraySafe) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(Content) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(ContentSafe) + ':' + ' ' + $"<safe><<{ContentSafe}>>",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + "<safe>" + ' ' + nameof(HeaderArraySafe) + ':',
                String.Empty + String.Join('\n'.ToString(), HeaderArraySafe),
            });
        }
    }
}
