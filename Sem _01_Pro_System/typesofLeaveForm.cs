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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyInterface
{
    public partial class typesofLeaveForm : Form
    {
        typesofLeaveFormClass _typesofLeaveForm = null;

        public typesofLeaveForm()
        {
            InitializeComponent();
            _typesofLeaveForm = new typesofLeaveFormClass(this);
        }

        private void typesofLeaveForm_Load(object sender, EventArgs e)
        {
            _typesofLeaveForm.LoadDataIntoGridView();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            _typesofLeaveForm.save();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            _typesofLeaveForm.update();
        }

        private void dltBtn_Click(object sender, EventArgs e)
        {
            _typesofLeaveForm.delete();
        }

        private void ClrBtn_Click(object sender, EventArgs e)
        {
            _typesofLeaveForm.clear();
        }
    }
}
