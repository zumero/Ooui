using System;
using System.Collections.Generic;
using System.Text;

namespace Ooui.Forms
{
    public class OouiOpenUri
    {
        public Element Element { get; private set; }

        public OouiOpenUri(Uri uri)
        {
            Element = new Script("window.location.href='" + uri.ToString() + @"'");          
        }       
    }
}
