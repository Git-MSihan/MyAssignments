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
    public partial class monthlyHolidayForm : Form
    {
        monthlyHolidayFormClass _monthlyHolidayForm = null;

        public monthlyHolidayForm()
        {
            InitializeComponent();
            _monthlyHolidayForm = new monthlyHolidayFormClass(this);
        }

        private void monthlyHolidayForm_Load(object sender, EventArgs e)
        {
            _monthlyHolidayForm.LoadDataIntoGridView();
            _monthlyHolidayForm.clear();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            _monthlyHolidayForm.save();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            _monthlyHolidayForm.update();
        }

        private void dltBtn_Click(object sender, EventArgs e)
        {
            _monthlyHolidayForm.delete();
        }

        private void ClrBtn_Click(object sender, EventArgs e)
        {
            _monthlyHolidayForm.clear();
        }
    }
}
