using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyInterface.generalcode;
using System.Windows.Forms;

namespace MyInterface.Calculation
{
    internal class leave_RequestCalculation
    {
        public static void checkLeaveRequestWhileInsert(DateTimePicker _startdatebox, DateTimePicker _enddatebox, TextBox _noOfDaysbox, ComboBox _empnamebox, TextBox _idbox, DataGridView _dgtable, ComboBox _leavetypebox, TextBox _reasonbox, Control.ControlCollection controls)
        {
            string LoadTableQuery = $"SELECT emp_personal_details.Employee_Full_Name, type_of_leaves.Leave_Type, request_leave.* FROM emp_personal_details JOIN request_leave ON emp_personal_details.Employee_id = request_leave.Employee_id JOIN type_of_leaves ON type_of_leaves.Leave_Type_id = request_leave.Leave_Types_id";

            try
            {
                DateTime starttimetime = DateTime.Parse(_startdatebox.Text);

                string calc_query = $"select ( ( SELECT annually_leves FROM Configure c1 WHERE '{_startdatebox.Text}' BETWEEN c1.Annual_Year_Start_Date AND c1.Annual_Year_End_Date) - ( SELECT SUM(No_of_Leaves) FROM request_leave nf WHERE Employee_id = '{_empnamebox.SelectedValue}' AND nf.Leave_Begin_Date BETWEEN (SELECT MIN(Annual_Year_Start_Date) FROM Configure) AND (SELECT MAX(Annual_Year_End_Date) FROM Configure)  and nf.Leave_Types_id != '6')) AS AnnualLeaveBalance";
                string insert_query1 = $"insert into request_leave ( Employee_id, Leave_Types_id, Leave_Begin_Date, Leave_End_Date, No_of_Leaves, Reason) values ('{_empnamebox.SelectedValue.ToString()}', '{_leavetypebox.SelectedValue.ToString()}', '{_startdatebox.Text}',  '{_enddatebox.Text}',  '{_noOfDaysbox.Text}', '{_reasonbox.Text}')";

                DataTable dt = LoadData.getDataTableFromGivenSQL(calc_query);

                if (dt.Rows.Count > 0)
                {
                    int LValue;
                    if (int.TryParse(dt.Rows[0]["AnnualLeaveBalance"].ToString(), out LValue))
                    {

                        if (LValue > 0)
                        {
                            int noOfDay = int.Parse(_noOfDaysbox.Text);
                            int balance = (LValue - noOfDay);
                            if (balance >= 0)
                            {
                                if (MessageBox.Show("Leave balance: " + balance.ToString() + " Sure! Do you want to continue?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    CommonCode.save(insert_query1, LoadTableQuery, _dgtable, controls, _idbox);
                                }
                            }
                            else
                            {
                                if (MessageBox.Show("Leave balance: " + LValue.ToString() + " So your accepted leave : " + LValue.ToString() + " Reapplying for additional leaves", "Confirmation Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                                {
                                    string insert_query2 = $"insert into request_leave ( Employee_id, Leave_Types_id, Leave_Begin_Date, Leave_End_Date, No_of_Leaves, Reason) values ('{_empnamebox.SelectedValue.ToString()}', '{_leavetypebox.SelectedValue.ToString()}', '{_startdatebox.Text}',  '{_enddatebox.Text}',  '{LValue}', '{_reasonbox.Text}')";
                                    CommonCode.save(insert_query2, LoadTableQuery, _dgtable, controls, _idbox);
                                    MessageBox.Show("please update the date to your accepted " + LValue.ToString() + " days leave");
                                }
                            }
                        }
                        else
                        {
                            if (MessageBox.Show("Sure! Would you like to take a leve? Your annual leave has already been taken, so your pay will be decreased.", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                string insert_query3 = $"insert into request_leave ( Employee_id, Leave_Types_id, Leave_Begin_Date, Leave_End_Date, No_of_Leaves, Reason) values ('{_empnamebox.SelectedValue.ToString()}', '6', '{_startdatebox.Text}',  '{_enddatebox.Text}',  '{_noOfDaysbox.Text}', '{_reasonbox.Text}')";
                                CommonCode.save(insert_query3, LoadTableQuery, _dgtable, controls, _idbox);
                            }
                        }
                    }
                    else
                    {
                        CommonCode.save(insert_query1, LoadTableQuery, _dgtable, controls, _idbox);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        public static void checkLeaveRequestWhileUpdate(DateTimePicker _startdatebox, DateTimePicker _enddatebox, TextBox _noOfDaysbox, ComboBox _empnamebox, TextBox _idbox, DataGridView _dgtable, ComboBox _leavetypebox, TextBox _reasonbox, Control.ControlCollection controls)
        {
            string LoadTableQuery = $"SELECT emp_personal_details.Employee_Full_Name, type_of_leaves.Leave_Type, request_leave.* FROM emp_personal_details JOIN request_leave ON emp_personal_details.Employee_id = request_leave.Employee_id JOIN type_of_leaves ON type_of_leaves.Leave_Type_id = request_leave.Leave_Types_id";

            DateTime starttimetime = DateTime.Parse(_startdatebox.Text);

            string calc_query = $"select((SELECT annually_leves FROM Configure c1 WHERE '{_startdatebox.Text}' BETWEEN c1.Annual_Year_Start_Date AND c1.Annual_Year_End_Date) - (SELECT SUM(No_of_Leaves) FROM request_leave nf WHERE Employee_id = '{_empnamebox.SelectedValue}' AND nf.Leave_Begin_Date BETWEEN(SELECT MIN(Annual_Year_Start_Date) FROM Configure) AND(SELECT MAX(Annual_Year_End_Date) FROM Configure) and nf.RLeave_id != '{_idbox.Text}'  and nf.Leave_Types_id != '6')) AS AnnualLeaveBalance";

            string update_query = $"update request_leave set Employee_id = '{_empnamebox.SelectedValue.ToString()}', Leave_Types_id = '{_leavetypebox.SelectedValue.ToString()}', Leave_Begin_Date = '{_startdatebox.Text}', Leave_End_Date = '{_enddatebox.Text}', No_of_Leaves = '{_noOfDaysbox.Text}', Reason = '{_reasonbox.Text}' where RLeave_id = '" + _idbox.Text + "' ";

            DataTable dt = LoadData.getDataTableFromGivenSQL(calc_query);

            if (dt.Rows.Count > 0)
            {
                int LValue;
                if (int.TryParse(dt.Rows[0]["AnnualLeaveBalance"].ToString(), out LValue))
                {

                    if (LValue >= 0)
                    {
                        int noOfDay = int.Parse(_noOfDaysbox.Text);
                        int balance = (LValue - noOfDay);
                        if (balance >= 0)
                        {
                            if (MessageBox.Show("Leave balance: " + balance.ToString() + " Sure! Do you want to continue?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                CommonCode.update(update_query, LoadTableQuery, _dgtable, controls, _idbox);
                            }
                        }
                        else
                        {
                            if (MessageBox.Show("Leave balance: 0 And your accepted leave : " + LValue.ToString() + " Reapplying for additional leaves", "Confirmation Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                            {
                                string update_query2 = $"update request_leave set Employee_id = '{_empnamebox.SelectedValue.ToString()}', Leave_Types_id = '{_leavetypebox.SelectedValue.ToString()}', Leave_Begin_Date = '{_startdatebox.Text}', Leave_End_Date = '{_enddatebox.Text}', No_of_Leaves = '{LValue}', Reason = '{_reasonbox.Text}' where RLeave_id = '" + _idbox.Text + "' ";
                                CommonCode.update(update_query2, LoadTableQuery, _dgtable, controls, _idbox);
                                MessageBox.Show("please update the date to your accepted " + LValue.ToString() + " days leave");
                            }
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Sure! Would you like to take a leve? Your annual leave has already been taken, so your pay will be decreased.", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            string update_query3 = $"update request_leave set Employee_id = '{_empnamebox.SelectedValue.ToString()}', Leave_Types_id = '6', Leave_Begin_Date = '{_startdatebox.Text}', Leave_End_Date = '{_enddatebox.Text}', No_of_Leaves = '{_noOfDaysbox.Text}', Reason = '{_reasonbox.Text}' where RLeave_id = '" + _idbox.Text + "' ";
                            CommonCode.update(update_query3, LoadTableQuery, _dgtable, controls, _idbox);
                        }
                    }
                }
                else
                {
                    CommonCode.update(update_query, LoadTableQuery, _dgtable, controls, _idbox);
                }
            }

        }
    }
}
