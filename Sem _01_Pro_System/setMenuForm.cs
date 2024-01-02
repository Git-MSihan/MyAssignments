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
    public partial class setMenuForm : Form
    {
        public setMenuForm()
        {
            InitializeComponent();
        }

        private void workDaysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData.loadpanel(new workdaysForm(), LoadpanelArea);
        }

        private void adminDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData.loadpanel(new AdminForm(), LoadpanelArea);
        }

        private void configureDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData.loadpanel(new ConfigureForm(), LoadpanelArea);
        }

        private void setMenuForm_Load(object sender, EventArgs e)
        {
            workDaysToolStripMenuItem_Click(sender, e);
        }
    }
}
