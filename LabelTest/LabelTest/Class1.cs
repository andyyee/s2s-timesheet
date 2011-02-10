using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabelTest
{
    class postIt : System.Windows.Forms.Label
    {
        public String message;
        public void setText(String input)
        {
            message = input;
        }

    }
}
