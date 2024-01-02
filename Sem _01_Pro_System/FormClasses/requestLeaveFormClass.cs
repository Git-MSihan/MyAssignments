using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyInterface.Calculation;
using MyInterface.generalcode;

namespace MyInterface.FormClasses
{
    internal class requestLeaveFormClass
    {
        TextBox idbox, noOfDaysbox, reasonbox;
        ComboBox empnamebox, leavetypebox;
        DateTimePicker startdatebox, enddatebox;
        DataGridView dgtable;
        requestLeaveForm form;

        public requestLeaveFormClass(requestLeaveForm _form)
        {
            form = _form;
            idbox = form.idTextBox;
            noOfDaysbox = form.noOfLeaveTextBox;
            reasonbox = form.reasonTextBox;
            empnamebox = form.empNameComboBox;
            leavetypebox = form.typeOfLeaveComboBox;
            startdatebox = form.lBeginDateTimePicker;
            enddatebox = form.lEndDateTimePicker;
            dgtable = form.dataGridViewArea;

            dgtable.CellClick += table_cell_click;
        }

        private void table_cell_click(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int RowIndex = e.RowIndex;
                if (RowIndex >= 0)
                {
                    idbox.Text = dgtable.Rows[RowIndex].Cells[2].Value.ToString();
                    empnamebox.SelectedValue = dgtable.Rows[RowIndex].Cells[3].Value.ToString();
                    leavetypebox.SelectedValue = dgtable.Rows[RowIndex].Cells[4].Value.ToString();
                    startdatebox.Text = dgtable.Rows[RowIndex].Cells[5].Value.ToString();
                    enddatebox.Text = dgtable.Rows[RowIndex].Cells[6].Value.ToString();
                    noOfDaysbox.Text = dgtable.Rows[RowIndex].Cells[7].Value.ToString();
                    reasonbox.Text = dgtable.Rows[RowIndex].Cells[8].Value.ToString();
                }
            }
            catch { }
        }

        string LoadTableQuery = $"SELECT emp_personal_details.Employee_Full_Name, type_of_leaves.Leave_Type, request_leave.* FROM emp_personal_details JOIN request_leave ON emp_personal_details.Employee_id = request_leave.Employee_id JOIN type_of_leaves ON type_of_leaves.Leave_Type_id = request_leave.Leave_Types_id";

        public void LoadDataIntoGridView()
        {
            LoadData.loadTable(LoadTableQuery, dgtable);
        }

        public void save()
        {
            try
            {
                if (toolscheck.CheckAllDataInsert(form.Controls, idbox))
                {
                    leave_RequestCalculation.checkLeaveRequestWhileInsert(startdatebox, enddatebox, noOfDaysbox, empnamebox, idbox, dgtable, leavetypebox, reasonbox, form.Controls);
                }
                else
                {
                    MessageBox.Show("Please provide all relevant information.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        public void update()
        {
            try
            {
                if (toolscheck.CheckAllDataInsert(form.Controls, idbox))
                {
                    leave_RequestCalculation.checkLeaveRequestWhileUpdate(startdatebox, enddatebox, noOfDaysbox, empnamebox, idbox, dgtable, leavetypebox, reasonbox, form.Controls);
                }
                else
                {
                    MessageBox.Show("Please provide all relevant information.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void delete()
        {
            string _delete_query = "delete from request_leave where RLeave_id = '" + idbox.Text + "' ";
            CommonCode.delete(_delete_query, LoadTableQuery, dgtable, form.Controls);
        }

        public void clear()
        {
            CommonCode.Clear(form.Controls);
        }

        public void showFKdata()
        {
            string sql_query = "select * from emp_personal_details";
            LoadData.loadFkIntoCompoBox(sql_query, empnamebox, "Employee_id", "Employee_Full_Name");

            string sql_query1 = "select * from type_of_leaves";
            LoadData.loadFkIntoCompoBox(sql_query1, leavetypebox, "Leave_Type_id", "Leave_type");
        }

        public void search_data()
        {
            string search_query = $"SELECT emp_personal_details.Employee_Full_Name, type_of_leaves.Leave_Type, request_leave.* FROM emp_personal_details JOIN request_leave ON emp_personal_details.Employee_id = request_leave.Employee_id JOIN type_of_leaves ON type_of_leaves.Leave_Type_id = request_leave.Leave_Types_id where request_leave.Employee_id = '{empnamebox.SelectedValue}'";
            LoadData.loadTable(search_query, dgtable);
        }
    }
}
