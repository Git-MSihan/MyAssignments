using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyInterface.Calculation;
using MyInterface.generalcode;

namespace MyInterface.FormClasses
{
    internal class dailyAtteFormClass
    {
        TextBox idbox, workHourbox;
        ComboBox empNamebox;
        DateTimePicker intimebox, outtimebox;
        DataGridView dgtable;
        dailyAtteForm form;

        public dailyAtteFormClass(dailyAtteForm _form)
        {
            form = _form;
            idbox = form.idTextBox;
            workHourbox = form.workedHourseTextBox;
            empNamebox = form.empNComboBox;
            intimebox = form.inTimePicker;
            outtimebox = form.outTimePicker;
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
                    idbox.Text = dgtable.Rows[RowIndex].Cells[1].Value.ToString();
                    empNamebox.SelectedValue = dgtable.Rows[RowIndex].Cells[2].Value.ToString();
                    intimebox.Text = dgtable.Rows[RowIndex].Cells[3].Value.ToString();
                    outtimebox.Text = dgtable.Rows[RowIndex].Cells[4].Value.ToString();
                    workHourbox.Text = dgtable.Rows[RowIndex].Cells[5].Value.ToString();
                }
            }
            catch { }
        }

        string LoadTableQuery = $"SELECT emp_personal_details.Employee_Full_Name, daily_attendance. * FROM emp_personal_details JOIN daily_attendance ON emp_personal_details.Employee_id = daily_attendance.Employee_id";

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
                    if (dailyAttendanceCalculation.DontAccept24Hours(intimebox, outtimebox, workHourbox))
                    {
                        string insert_query = $"insert into daily_attendance (Employee_id, Intime, Out_time, Worked_Hours) values ('{empNamebox.SelectedValue.ToString()}', '{intimebox.Text}', '{outtimebox.Text}', '{workHourbox.Text}')";
                        CommonCode.save(insert_query, LoadTableQuery, dgtable, form.Controls, idbox);
                    }
                }
                else
                {
                    MessageBox.Show("Please provide all relevant information.");
                }
            }
            catch { }
        }

        public void update()
        {
            try
            {
                if (toolscheck.CheckAllDataInsert(form.Controls, idbox))
                {
                    if (dailyAttendanceCalculation.DontAccept24Hours(intimebox, outtimebox, workHourbox))
                    {
                        string update_query = $"update daily_attendance set Employee_id = '{empNamebox.SelectedValue.ToString()}', Intime = '{intimebox.Text}', Out_time = '{outtimebox.Text}' ,Worked_Hours = '{workHourbox.Text}' where Attendance_Id ='" + idbox.Text + "'";
                        CommonCode.update(update_query, LoadTableQuery, dgtable, form.Controls, idbox);
                    }
                }
                else
                {
                    MessageBox.Show("Please provide all relevant information.");
                }
            }
            catch { }
        }

        public void delete()
        {
            string _delete_query = "delete from daily_attendance where Attendance_Id = '" + idbox.Text + "' ";
            CommonCode.delete(_delete_query, LoadTableQuery, dgtable, form.Controls);
        }

        public void clear()
        {
            CommonCode.Clear(form.Controls);
        }

        public void showFKdata()
        {
            string sql_query = "select * from emp_personal_details";
            LoadData.loadFkIntoCompoBox(sql_query, empNamebox, "Employee_id", "Employee_Full_Name");
        }

        public void search_data()
        {
            string search_query = $"SELECT emp_personal_details.Employee_Full_Name, daily_attendance. * FROM emp_personal_details JOIN daily_attendance ON emp_personal_details.Employee_id = daily_attendance.Employee_id WHERE daily_attendance.Employee_id = '{empNamebox.SelectedValue}'";
            LoadData.loadTable(search_query, dgtable);
        }

        public void Calculate_WorkedHourse()
        {
            dailyAttendanceCalculation.findWorkedHourse(intimebox, outtimebox, workHourbox);
        }
    }
}
