using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                    DateTime intime = DateTime.Parse(intimebox.Text);
                    DateTime outTime = DateTime.Parse(outtimebox.Text);

                    DateTime fixedTime = intime.AddDays(1);

                    if (outTime >= fixedTime)
                    {
                        MessageBox.Show("You cannot work continuously for 24 hours.");
                    }
                    else
                    {
                        int Hours = (outTime - intime).Hours;
                        workHourbox.Text = Hours.ToString();
                        string insert_query = $"insert into daily_attendance (Employee_id , Intime, Out_time, Worked_Hours) values ('{empNamebox.SelectedValue.ToString()}', '{intimebox.Text}' , '{outtimebox.Text}', '{workHourbox.Text}')";
                        general.save(insert_query, LoadTableQuery, dgtable, form.Controls, idbox);
                    }
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
                    DateTime intime = DateTime.Parse(intimebox.Text);
                    DateTime outTime = DateTime.Parse(outtimebox.Text);

                    DateTime fixedTime = intime.AddDays(1);

                    if (outTime >= fixedTime)
                    {
                        MessageBox.Show("You cannot work continuously for 24 hours.");
                    }
                    else
                    {
                        int Hours = (outTime - intime).Hours;
                        workHourbox.Text = Hours.ToString();
                        string update_query = $"update daily_attendance set Employee_id = '{empNamebox.SelectedValue.ToString()}', Intime = '{intimebox.Text}', Out_time = '{outtimebox.Text}' ,Worked_Hours = '{workHourbox.Text}' where Attendance_Id ='" + idbox.Text + "'";
                        general.update(update_query, LoadTableQuery, dgtable, form.Controls, idbox);
                    }
                }
            }
            catch { }
        }

        public void delete()
        {
            string _delete_query = "delete from daily_attendance where Attendance_Id = '" + idbox.Text + "' ";
            general.delete(_delete_query, LoadTableQuery, dgtable, form.Controls);
        }

        public void clear()
        {
            general.Clear(form.Controls);
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
            try
            {
                DateTime intime = DateTime.Parse(intimebox.Text);
                DateTime outTime = DateTime.Parse(outtimebox.Text);
                int Hours = (outTime - intime).Hours;
                workHourbox.Text = Hours.ToString();
            }
            catch { }
        }
    }
}
