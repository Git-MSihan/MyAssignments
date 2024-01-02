using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyInterface.generalcode
{
    internal class find_logined_andminid
    {
        TextBox adminIdBox;
        homeForm form;


        public find_logined_andminid(homeForm _form)
        {
            form = _form;
            adminIdBox = form.loginedAdminIdTextBox;
        }


        public static void find_id(TextBox adminIdBox)
        {
            adminIdBox.Text = adminIdBox.Text;
        }
    }
}
