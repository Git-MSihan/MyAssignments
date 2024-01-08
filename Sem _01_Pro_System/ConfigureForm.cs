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
    public partial class ConfigureForm : Form
    {
        ConfigureFormClass _ConfigureForm = null;

        public ConfigureForm()
        {
            InitializeComponent();
            _ConfigureForm = new ConfigureFormClass(this);
        }

        private void ConfigureForm_Load(object sender, EventArgs e)
        {
            _ConfigureForm.LoadDataIntoGridView();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            _ConfigureForm.save();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            _ConfigureForm.update();
        }

        private void ClrBtn_Click(object sender, EventArgs e)
        {
            _ConfigureForm.clear();
        }

        private void taxRateTextBox_MouseHover(object sender, EventArgs e)
        {
            _ConfigureForm.hoverMsg();
        }
    }
}
