using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OfficeManager
{
    class postIt : System.Windows.Forms.RichTextBox
    {
        public String message;
        public void setText(String input)
        {
            message = input;
        }
    }
}
