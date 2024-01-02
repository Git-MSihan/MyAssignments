using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyInterface.FormClasses;
using MyInterface.generalcode;

namespace MyInterface
{
    public partial class homeForm : Form
    {
        dashboardClass _homeForm = null;
        public homeForm()
        {
            InitializeComponent();
            _homeForm = new dashboardClass(this);
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            _homeForm.login();
        }

        private void Loginpagebtn_Click(object sender, EventArgs e)
        {
            _homeForm.Loginpage();
        }

        private void shopasCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _homeForm.showpassword();
        }

        private void EmpBtn_Click(object sender, EventArgs e)
        {
            _homeForm.employeebtn();
        }

        private void salBtn_Click(object sender, EventArgs e)
        {
            _homeForm.salarybtn();
        }

        private void setBtn_Click(object sender, EventArgs e)
        {
            _homeForm.settingbtn();
        }

        private void empLeavBtn_Click(object sender, EventArgs e)
        {
            _homeForm.leavesbtn();
        }

        private void dailattBtn_Click(object sender, EventArgs e)
        {
            _homeForm.attendencebtn();
        }
    }
}
