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
    public partial class empForm : Form
    {
        empFormClass _empForm = null;

        public empForm()
        {
            InitializeComponent();
            _empForm = new empFormClass(this);
        }

        private void empForm_Load(object sender, EventArgs e)
        {
            _empForm.LoadDataIntoGridView();
            _empForm.showFKdata();
            _empForm.showEmpNameList();
            _empForm.clear();
        }

        private void ClrBtn_Click_1(object sender, EventArgs e)
        {
            _empForm.clear();
        }

        private void saveBtn_Click_1(object sender, EventArgs e)
        {
            _empForm.save();
        }

        private void updateBtn_Click_1(object sender, EventArgs e)
        {
            _empForm.update();
        }

        private void dltBtn_Click(object sender, EventArgs e)
        {
            _empForm.delete();
        }

        private void findBtn_Click_1(object sender, EventArgs e)
        {
            _empForm.search_data();
        }
    }
}
