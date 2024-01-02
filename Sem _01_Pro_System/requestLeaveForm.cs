using System;
using System.Data;
using System.Windows.Forms;
using MyInterface.FormClasses;
using MyInterface.generalcode;

namespace MyInterface
{
    public partial class requestLeaveForm : Form
    {
        requestLeaveFormClass _requestLeaveForm = null;

        public requestLeaveForm()
        {
            InitializeComponent();
            _requestLeaveForm = new requestLeaveFormClass(this);
        }

        private void requestLeaveForm_Load(object sender, EventArgs e)
        {
            _requestLeaveForm.LoadDataIntoGridView();
            _requestLeaveForm.showFKdata();
            _requestLeaveForm.clear();

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            _requestLeaveForm.update();
        }

        private void dltBtn_Click(object sender, EventArgs e)
        {
            _requestLeaveForm.delete();
        }

        private void ClrBtn_Click(object sender, EventArgs e)
        {
            _requestLeaveForm.clear();
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            _requestLeaveForm.search_data();
        }

        private void ReqBtn_Click(object sender, EventArgs e)
        {
            _requestLeaveForm.save();
        }
    }
}
