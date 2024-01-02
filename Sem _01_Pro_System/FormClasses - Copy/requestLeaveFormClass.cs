using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                    DateTime starttimetime = DateTime.Parse(startdatebox.Text);

                    string calc_query = $"select ( ( SELECT annually_leves FROM Configure c1 WHERE '{starttimetime}' BETWEEN c1.Annual_Year_Start_Date AND c1.Annual_Year_End_Date) - ( SELECT SUM(No_of_Leaves) FROM request_leave nf WHERE Employee_id = '{empnamebox.SelectedValue}' AND nf.Leave_Begin_Date BETWEEN (SELECT Annual_Year_Start_Date FROM Configure) AND (SELECT Annual_Year_End_Date FROM Configure))) AS LeaveSum";
                    string insert_query1 = $"insert into request_leave ( Employee_id, Leave_Types_id, Leave_Begin_Date, Leave_End_Date, No_of_Leaves, Reason) values ('{empnamebox.SelectedValue.ToString()}', '{leavetypebox.SelectedValue.ToString()}', '{startdatebox.Text}',  '{enddatebox.Text}',  '{noOfDaysbox.Text}', '{reasonbox.Text}')";

                    DataTable dt = LoadData.getDataTableFromGivenSQL(calc_query);

                    if (dt.Rows.Count > 0)
                    {
                        int LValue;
                        if (int.TryParse(dt.Rows[0]["LeaveSum"].ToString(), out LValue))
                        {

                            if(LValue > 0)
                            {
                                int noOfDay = int.Parse(noOfDaysbox.Text);
                                int balance = (LValue - noOfDay);
                                if (balance >= 0)
                                {
                                    if (MessageBox.Show("Leave balance: " + balance.ToString()+ " Sure! Do you want to continue?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        general.save(insert_query1, LoadTableQuery, dgtable, form.Controls, idbox);
                                    }
                                }
                                else
                                {
                                    if (MessageBox.Show("Leave balance: 0 And your accepted leave : " + LValue.ToString() + " Reapplying for additional leaves", "Confirmation Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                                    {
                                        string insert_query2 = $"insert into request_leave ( Employee_id, Leave_Types_id, Leave_Begin_Date, Leave_End_Date, No_of_Leaves, Reason) values ('{empnamebox.SelectedValue.ToString()}', '{leavetypebox.SelectedValue.ToString()}', '{startdatebox.Text}',  '{enddatebox.Text}',  '{LValue}', '{reasonbox.Text}')";
                                        general.save(insert_query2, LoadTableQuery, dgtable, form.Controls, idbox);
                                    }
                                }
                            }
                            else
                            {
                                if (MessageBox.Show("Sure! Would you like to take a leve? Your annual leave has already been taken, so your pay will be decreased.", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                {
                                    string insert_query = $"insert into request_leave ( Employee_id, Leave_Types_id, Leave_Begin_Date, Leave_End_Date, No_of_Leaves, Reason) values ('{empnamebox.SelectedValue.ToString()}', '6', '{startdatebox.Text}',  '{enddatebox.Text}',  '{noOfDaysbox.Text}', '{reasonbox.Text}')";
                                    general.save(insert_query, LoadTableQuery, dgtable, form.Controls, idbox);
                                }
                            }
                        }
                        else
                        {
                            general.save(insert_query1, LoadTableQuery, dgtable, form.Controls, idbox);
                        }
                    }
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
            string update_query = $"update request_leave set Employee_id = '{empnamebox.SelectedValue.ToString()}', Leave_Types_id = '{leavetypebox.SelectedValue.ToString()}', Leave_Begin_Date = '{startdatebox.Text}', Leave_End_Date = '{enddatebox.Text}', No_of_Leaves = '{noOfDaysbox.Text}', Reason = '{reasonbox.Text}' where RLeave_id = '" + idbox.Text + "' ";
            general.update(update_query, LoadTableQuery, dgtable, form.Controls, idbox);
        }

        public void delete()
        {
            string _delete_query = "delete from request_leave where RLeave_id = '" + idbox.Text + "' ";
            general.delete(_delete_query, LoadTableQuery, dgtable, form.Controls);
        }

        public void clear()
        {
            general.Clear(form.Controls);
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
