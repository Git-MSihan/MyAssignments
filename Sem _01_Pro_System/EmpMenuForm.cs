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
    public partial class EmpMenuForm : Form
    {
        public EmpMenuForm()
        {
            InitializeComponent();
        }

        private void emloyeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData.loadpanel(new empForm(), LoadpanelArea);
        }

        private void emloyeeTypesDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData.loadpanel(new empTypeForm(), LoadpanelArea);
        }

        private void EmpMenuForm_Load(object sender, EventArgs e)
        {
            emloyeeDetailsToolStripMenuItem_Click(sender, e);
        }
    }
}
