using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyInterface.generalcode
{
    internal class toolscheck
    {
        public static bool CheckAllDataInsert(Control.ControlCollection controls, TextBox PKbox)
        {
             try
             {
                 foreach (Control control in controls ) //control all tools
                 {
                     if (control is TextBox textBox)
                     {
                         if (textBox.Text.Trim() == "" && textBox != PKbox)
                         {
                             return false;
                         }
                     }
                     else if (control is ComboBox comboBox)
                     {
                         if (comboBox.Text.Trim() == "")
                         {
                             return false;
                         }
                     }
                 }
                 return true;
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
                 return false;
             }
        }

    }
}

