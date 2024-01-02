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
    public partial class empLeaveMenuForm : Form
    {
        public empLeaveMenuForm()
        {
            InitializeComponent();
        }

        private void requestLeaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData.loadpanel(new requestLeaveForm(), LoadpanelArea);
        }

        private void typesOfLeaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData.loadpanel(new typesofLeaveForm(), LoadpanelArea);
        }

        private void monthlyHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData.loadpanel(new monthlyHolidayForm(), LoadpanelArea);
        }

        private void empLeaveMenuForm_Load(object sender, EventArgs e)
        {
            requestLeaveToolStripMenuItem_Click(sender, e);
        }
    }
}
