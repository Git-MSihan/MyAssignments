using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyInterface.generalcode
{
    internal class showMsgHover
    {
        public static void show_msg_mouseHover(TextBox textBox, string message)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(textBox, message);
        }

    }
}
