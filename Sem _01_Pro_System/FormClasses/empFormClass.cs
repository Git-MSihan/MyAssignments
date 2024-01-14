using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyInterface.generalcode;

namespace MyInterface.FormClasses
{
    internal class empFormClass
    {
        TextBox idbox, addressbox, nicbox, phonenobox,emailbox, salarybox, allowancebox, otratebox;
        ComboBox genderbox, emptypebox, fullnamebox;
        DateTimePicker joindatebox, dobbox;
        MaskedTextBox adminidbox;
        DataGridView dgtable;
        empForm form;


        public empFormClass(empForm _form)
        {
            form = _form;
            idbox = form.idTextBox;
            fullnamebox = form.EmpNameComboBox;
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
            adminidbox = form.AdminIdMaskedTextBox;

            dgtable.CellClick += table_cell_click;
        }

        private void table_cell_click(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex;

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
            adminidbox.Text = dgtable.Rows[RowIndex].Cells[13].Value.ToString();

           /* try
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
                    adminidbox.Text = dgtable.Rows[RowIndex].Cells[13].Value.ToString();
                }
            }
            catch { }*/
        }

        string LoadTableQuery = $"SELECT * FROM emp_personal_details";

        public void LoadDataIntoGridView()
        {
            LoadData.loadTable(LoadTableQuery, dgtable);
        }

        public void save()
        {
            if (toolscheck.CheckAllDataInsert(form.Controls, idbox))
            {
                string _insert_query = $"insert into emp_personal_details (Employee_Full_Name , Employee_NIC, Employee_Gender, Date_of_Birth, Employee_Address, Employee_Phone_No, Employee_Email, Join_Date, Employee_Type_id, Employee_Salary, OT_Rate_Hourly, Allowance, Admin_id ) values ('{fullnamebox.Text}', '{nicbox.Text}' , '{genderbox.Text}' , '{dobbox.Text}' , '{addressbox.Text}',  '{phonenobox.Text}', '{emailbox.Text}', '{joindatebox.Text}','{emptypebox.SelectedValue?.ToString()}','{salarybox.Text}', '{otratebox.Text}', '{allowancebox.Text}', '{ LoginAuth.loggedUser.Id }' )";
                CommonCode.save(_insert_query, LoadTableQuery, dgtable, form.Controls, idbox);
            }
            else
            {
                MessageBox.Show("Please provide all relevant information.");
            }
        }

        public void update()
        {
            if (toolscheck.CheckAllDataInsert(form.Controls, idbox))
            {
                String _update_query = $"update emp_personal_details set Employee_Full_Name = '{fullnamebox.Text}', Employee_NIC = '{nicbox.Text}', Employee_Gender = '{genderbox.Text}', Date_of_Birth = '{dobbox.Text}', Employee_Address = '{addressbox.Text}', Employee_Phone_No = '{phonenobox.Text}', Employee_Email = '{emailbox.Text}', Join_Date = '{joindatebox.Text}', Employee_Type_id = '{emptypebox.SelectedValue.ToString()}',Employee_Salary = '{salarybox.Text}', OT_Rate_hourly = '{otratebox.Text}', Allowance = '{allowancebox.Text}',  Admin_id ='{LoginAuth.loggedUser.Id}' where Employee_id = '" + idbox.Text + "'";
                CommonCode.update(_update_query, LoadTableQuery, dgtable, form.Controls, idbox);
            }
            else
            {
                MessageBox.Show("Please provide all relevant information.");
            }
        }

        public void delete()
        {
            string _delet_query = "delete from emp_personal_details where Employee_id = '" + idbox.Text + "' ";
            CommonCode.delete(_delet_query, LoadTableQuery, dgtable, form.Controls);
        }

        public void clear()
        {
            CommonCode.Clear(form.Controls);
        }

        public void showFKdata()
        {
            LoadData.loadFkIntoCompoBox($"select * from Employee_Types_Details", emptypebox, "Employee_Type_id", "Employee_Type");
        }

        public void showEmpNameList()
        {
            LoadData.loadFkIntoCompoBox(LoadTableQuery, fullnamebox, "Employee_Full_Name", "Employee_Full_Name");
        }

        public void search_data()
        {
            string search_query = $"SELECT * FROM emp_personal_details WHERE Employee_Full_Name = '{fullnamebox.Text}'";
            DataTable dt = LoadData.getDataTableFromGivenSQL(search_query);
            if (dt.Rows.Count > 0)
            {
                idbox.Text = dt.Rows[0]["Employee_id"].ToString();
                fullnamebox.Text = dt.Rows[0]["Employee_Full_Name"].ToString();
                nicbox.Text = dt.Rows[0]["Employee_NIC"].ToString();
                genderbox.Text = dt.Rows[0]["Employee_Gender"].ToString();
                dobbox.Text = dt.Rows[0]["Date_of_Birth"].ToString();
                addressbox.Text = dt.Rows[0]["Employee_Address"].ToString();
                phonenobox.Text = dt.Rows[0]["Employee_Phone_No"].ToString();
                emailbox.Text = dt.Rows[0]["Employee_Email"].ToString();
                joindatebox.Text = dt.Rows[0]["Join_Date"].ToString();
                emptypebox.SelectedValue = dt.Rows[0]["Employee_Type_id"].ToString();
                salarybox.Text = dt.Rows[0]["Employee_Salary"].ToString();
                otratebox.Text = dt.Rows[0]["OT_Rate_Hourly"].ToString();
                allowancebox.Text = dt.Rows[0]["Allowance"].ToString();
                adminidbox.Text = dt.Rows[0]["Admin_id"].ToString();
            }
            else
            {
                MessageBox.Show("No data found.");
            }
        }
    }
}