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

namespace MyInterface
{
    public partial class AdminForm : Form
    {
        AdminFormClass _adminForm = null;

        public AdminForm()
        {
            InitializeComponent();
            _adminForm = new AdminFormClass(this);
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            _adminForm.LoadDataIntoGridView();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            _adminForm.save();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            _adminForm.update();
        }

        private void ClrBtn_Click(object sender, EventArgs e)
        {
            _adminForm.clear();
        }

        private void dltBtn_Click(object sender, EventArgs e)
        {
            _adminForm.delete();
        }
    }
}
