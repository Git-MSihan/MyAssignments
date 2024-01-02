using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyInterface.generalcode;

namespace MyInterface
{
    public partial class salMenuForm : Form
    {
        public salMenuForm()
        {
            InitializeComponent();
        }

        private void salaryCalculationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData.loadpanel(new salaryForm(), LoadpanelArea);
        }

        private void salMenuForm_Load(object sender, EventArgs e)
        {
            salaryCalculationToolStripMenuItem_Click(sender, e);
        }
    }
}
