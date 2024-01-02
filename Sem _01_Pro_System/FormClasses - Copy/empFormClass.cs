using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyInterface.generalcode;

namespace MyInterface.FormClasses
{
    internal class empFormClass
    {
        TextBox idbox, fullnamebox, addressbox, nicbox, phonenobox,emailbox, salarybox, allowancebox, otratebox;
        ComboBox genderbox, emptypebox;
        DateTimePicker joindatebox, dobbox;
        DataGridView dgtable;
        empForm form;


        public empFormClass(empForm _form)
        {
            form = _form;
            idbox = form.idTextBox;
            fullnamebox = form.EmpNameTextBox;
            addressbox = form.AddTextBox;
            nicbox = form.NICTextBox;
            phonenobox = form.PhoneNoTextBox;
            emailbox = form.EmailTextBox;
            salarybox = form.empSalaryTextBox;
            allowancebox = form.allowanceTextBox;
            otratebox = form.OTRateTextBox;
            genderbox = form.GenderComboBox;
            emptypebox = form.EmpTypeComboBox;
            joindatebox = form.JoinDate;
            dobbox = form.DOB;
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
                    idbox.Text = dgtable.Rows[RowIndex].Cells[0].Value.ToString();
                    fullnamebox.Text = dgtable.Rows[RowIndex].Cells[1].Value.ToString();
                    nicbox.Text = dgtable.Rows[RowIndex].Cells[2].Value.ToString();
                    genderbox.Text = dgtable.Rows[RowIndex].Cells[3].Value.ToString();
                    dobbox.Text = dgtable.Rows[RowIndex].Cells[4].Value.ToString();
                    addressbox.Text = dgtable.Rows[RowIndex].Cells[5].Value.ToString();
                    phonenobox.Text = dgtable.Rows[RowIndex].Cells[6].Value.ToString();
                    emailbox.Text = dgtable.Rows[RowIndex].Cells[7].Value.ToString();
                    joindatebox.Text = dgtable.Rows[RowIndex].Cells[8].Value.ToString();
                    emptypebox.SelectedValue = dgtable.Rows[RowIndex].Cells[9].Value.ToString();
                    salarybox.Text = dgtable.Rows[RowIndex].Cells[10].Value.ToString();
                    otratebox.Text = dgtable.Rows[RowIndex].Cells[11].Value.ToString();
                    allowancebox.Text = dgtable.Rows[RowIndex].Cells[12].Value.ToString();
                }
            }
            catch { }
        }

        string LoadTableQuery = $"SELECT * FROM emp_personal_details JOIN Employee_Types ON emp_personal_details.Employee_Type = Employee_Types.Employee_Type_id";

        public void LoadDataIntoGridView()
        {
            LoadData.loadTable(LoadTableQuery, dgtable);
        }

        public void save()
        {
            string _insert_query = $"insert into emp_personal_details (Employee_Full_Name , Employee_NIC, Employee_Gender, Date_of_Birth, Employee_Address, Employee_Phone_No, Employee_Email, Join_Date, Employee_Type, Employee_Salary, OT_Rate_Hourly, Allowance, Admin_id ) values ('{fullnamebox.Text}', '{nicbox.Text}' , '{genderbox.Text}' , '{dobbox.Text}' , '{addressbox.Text}',  '{phonenobox.Text}', '{emailbox.Text}', '{joindatebox.Text}','{emptypebox.SelectedValue?.ToString()}','{salarybox.Text}', '{otratebox.Text}', '{allowancebox.Text}', 1 )";
            general.save(_insert_query, LoadTableQuery, dgtable, form.Controls, idbox);
        }

        public void update()
        {

            String _update_query = $"update emp_personal_details set Employee_Full_Name = '{fullnamebox.Text}', Em_NIC = '{nicbox.Text}', Employee_Gender = '{genderbox.Text}', Date_of_Birth = '{dobbox.Text}', Employee_Address = '{addressbox.Text}', Employee_Phone_No = '{phonenobox.Text}', Employee_Email = '{emailbox.Text}', Join_Date = '{joindatebox.Text}', Employee_Type = '{emptypebox.SelectedValue.ToString()}',Employee_Salary = '{salarybox.Text}', OT_Rate_hourly = '{otratebox.Text}', Allowance = '{allowancebox.Text}',  Admin_id ='1' where Employee_id = '" + idbox.Text + "'";
            general.update(_update_query, LoadTableQuery, dgtable, form.Controls, idbox);
        }

        public void delete()
        {
            string _delet_query = "delete from emp_personal_details where Employee_id = '" + idbox.Text + "' ";
            general.delete(_delet_query, LoadTableQuery, dgtable, form.Controls);
        }

        public void clear()
        {
            general.Clear(form.Controls);
        }

        public void showFKdata()
        {
            LoadData.loadFkIntoCompoBox($"select * from Employee_Types", emptypebox, "Employee_Type_id", "Employee_Type");
        }

        public void search_data()
        {
            string search_query = $"SELECT * FROM emp_personal_details JOIN Employee_Types ON emp_personal_details.Employee_Type = Employee_Types.Employee_Type_id WHERE Employee_id = '{fullnamebox.Text}'";
            LoadData.loadTable(search_query, dgtable);
        }
    }
}