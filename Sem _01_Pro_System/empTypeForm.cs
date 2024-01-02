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
    public partial class empTypeForm : Form
    {
        empTypeFormClass _empTypeForm = null;

        public empTypeForm()
        {
            InitializeComponent();
            _empTypeForm = new empTypeFormClass(this);
        }

        private void empTypeForm_Load(object sender, EventArgs e)
        {
            _empTypeForm.LoadDataIntoGridView();
            _empTypeForm.clear();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            _empTypeForm.save();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            _empTypeForm.update();
        }

        private void dltBtn_Click(object sender, EventArgs e)
        {
            _empTypeForm.delete();
        }

        private void ClrBtn_Click(object sender, EventArgs e)
        {
            _empTypeForm.clear();
        }
    }
}
