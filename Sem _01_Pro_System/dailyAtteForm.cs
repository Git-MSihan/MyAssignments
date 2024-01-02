using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    public partial class dailyAtteForm : Form
    {
        dailyAtteFormClass _dailyAtteForm = null;

        public dailyAtteForm()
        {
            InitializeComponent();
            _dailyAtteForm = new dailyAtteFormClass(this);
        }

        private void dailyAtteForm_Load(object sender, EventArgs e)
        {
            _dailyAtteForm.LoadDataIntoGridView();
            _dailyAtteForm.showFKdata();
            _dailyAtteForm.clear();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            _dailyAtteForm.save();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            _dailyAtteForm.update();
        }

        private void dltBtn_Click(object sender, EventArgs e)
        {
            _dailyAtteForm.delete();
        }

        private void ClrBtn_Click(object sender, EventArgs e)
        {
            _dailyAtteForm.clear();
        }

        private void inTimePicker_ValueChanged(object sender, EventArgs e)
        {
            _dailyAtteForm.Calculate_WorkedHourse();
        }

        private void outTimePicker_ValueChanged(object sender, EventArgs e)
        {
            _dailyAtteForm.Calculate_WorkedHourse();
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            _dailyAtteForm.search_data();
        }
    }
}
