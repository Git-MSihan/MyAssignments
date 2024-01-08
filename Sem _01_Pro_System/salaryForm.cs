using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyInterface.generalcode;
using MyInterface.FormClasses;

namespace MyInterface
{
    public partial class salaryForm : Form
    {
        SalaryFormClass _salaryform = null;

        public salaryForm()
        {
            InitializeComponent();
            _salaryform = new SalaryFormClass(this);
        }

        private void salaryForm_Load(object sender, EventArgs e)
        {
            _salaryform.LoadDataIntoGridView();

            _salaryform.showFKdata();

            _salaryform.clear();
        }


        private void saveBtn_Click(object sender, EventArgs e)
        {
            _salaryform.save();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            _salaryform.update();
        }

        private void dltBtn_Click(object sender, EventArgs e)
        {
            _salaryform.delete();
            _salaryform.clear();
        }

        private void ClrBtn_Click(object sender, EventArgs e)
        {
            _salaryform.clear();
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            _salaryform.find_findGroup_data();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            _salaryform.search_data();
        }

        private void PayBtn_Click(object sender, EventArgs e)
        {
            _salaryform.find_paymentGroup_Data();
        }

        private void findGroupBox_Paint(object sender, PaintEventArgs e)
        {
            GroupBox groupBox = sender as GroupBox;
            Color borderColor = Color.Black;
            ControlPaint.DrawBorder(e.Graphics, groupBox.ClientRectangle, borderColor, ButtonBorderStyle.Inset);
        }

        private void dateRangeGroupBox_Paint(object sender, PaintEventArgs e)
        {
            GroupBox groupBox = sender as GroupBox;
            Color borderColor = Color.Black;
            ControlPaint.DrawBorder(e.Graphics, groupBox.ClientRectangle, borderColor, ButtonBorderStyle.Inset);
        }

        private void payValueGroupBox_Paint(object sender, PaintEventArgs e)
        {
            GroupBox groupBox = sender as GroupBox;
            Color borderColor = Color.Black;
            ControlPaint.DrawBorder(e.Graphics, groupBox.ClientRectangle, borderColor, ButtonBorderStyle.Inset);
        }

        private void SelectGroupBox_Paint(object sender, PaintEventArgs e)
        {
            GroupBox groupBox = sender as GroupBox;
            Color borderColor = Color.Black;
            ControlPaint.DrawBorder(e.Graphics, groupBox.ClientRectangle, borderColor, ButtonBorderStyle.Inset);
        }
    }    
}
