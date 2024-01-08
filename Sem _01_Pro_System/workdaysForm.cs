using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyInterface.FormClasses;
using MyInterface.generalcode;

namespace MyInterface
{
    public partial class workdaysForm : Form
    {
        workdaysFormClass _workdaysForm = null;

        public workdaysForm()
        {
            InitializeComponent();
            _workdaysForm = new workdaysFormClass(this);
        }

        private void workdaysForm_Load(object sender, EventArgs e)
        {
            _workdaysForm.LoadDataIntoGridView();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            _workdaysForm.update();
        }

        private void ClrBtn_Click(object sender, EventArgs e)
        {
            _workdaysForm.clear();
        }
    }
}
