using System;
using System.Collections.Generic;
using System.Text;

namespace Ooui
{
    public class Script : Element
    {
        public Script()
           : base("script")
        {
        }
        public Script(string text)
          : this()
        {
            Text = text;
        }
    }
}
