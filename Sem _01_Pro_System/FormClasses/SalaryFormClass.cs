using System;
using System.Data;
using System.Windows.Forms;
using MyInterface.Calculation;
using MyInterface.generalcode;

namespace MyInterface.FormClasses
{
    internal class SalaryFormClass
    {

        TextBox totalsalarybox, OThoursebox, totalleavebox, basepaybox, nopaybox, grosspaybox, nopaylevebox, salaryidbox, daterangebox;
        ComboBox employeenamebox;
        DateTimePicker salaryissuedatebox, begindatebox, enddatebox;
        DataGridView dgtable;
        salaryForm form;
        GroupBox findGroupBox, payValueGroupBox, searchGroupBox, dateRangeGroupBox;

        public SalaryFormClass(salaryForm _form)
        {
            form = _form;
            salaryidbox = form.idTextBox;
            daterangebox = form.DateRangeTextBox;
            begindatebox = form.BginDateTimePicker;
            enddatebox = form.EndDateTimePicker;
            totalsalarybox = form.totSalaryTextBox;
            OThoursebox = form.OThourseTextBox;
            totalleavebox = form.totalLeaveTextBox;
            basepaybox = form.basePayTextBox;
            nopaybox = form.noPayTextBox;
            grosspaybox = form.grossPayTextBox;
            nopaylevebox = form.NopayLeaveTextBox;
            employeenamebox = form.empNameComboBox;
            salaryissuedatebox = form.issueDateTimePicker;
            dgtable = form.dataGridViewArea;

            findGroupBox = form.findGroupBox;
            payValueGroupBox = form.payValueGroupBox;
            dateRangeGroupBox = form.dateRangeGroupBox;
            searchGroupBox = form.SelectGroupBox;

            dgtable.CellClick += table_cell_click;
        }


        string LoadTableQuery = $"SELECT emp_personal_details.Employee_Full_Name, Em_salary.* FROM emp_personal_details JOIN Em_salary ON emp_personal_details.Employee_id = Em_salary.Employee_id";


        private void table_cell_click(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int RowIndex = e.RowIndex;
                if (RowIndex >= 0)
                {
                    salaryidbox.Text = dgtable.Rows[RowIndex].Cells[1].Value.ToString();
                    employeenamebox.SelectedValue = dgtable.Rows[RowIndex].Cells[2].Value.ToString();
                    totalsalarybox.Text = dgtable.Rows[RowIndex].Cells[3].Value.ToString();
                    salaryissuedatebox.Text = dgtable.Rows[RowIndex].Cells[4].Value.ToString();
                    totalleavebox.Text = dgtable.Rows[RowIndex].Cells[5].Value.ToString();
                    nopaylevebox.Text = dgtable.Rows[RowIndex].Cells[6].Value.ToString();
                    OThoursebox.Text = dgtable.Rows[RowIndex].Cells[7].Value.ToString();
                    nopaybox.Text = dgtable.Rows[RowIndex].Cells[8].Value.ToString();
                    grosspaybox.Text = dgtable.Rows[RowIndex].Cells[9].Value.ToString();
                    basepaybox.Text = dgtable.Rows[RowIndex].Cells[10].Value.ToString();
                    daterangebox.Text = dgtable.Rows[RowIndex].Cells[11].Value.ToString();
                    begindatebox.Text = dgtable.Rows[RowIndex].Cells[12].Value.ToString();
                    enddatebox.Text = dgtable.Rows[RowIndex].Cells[13].Value.ToString();
                }
            }
            catch { }
        }

        public void LoadDataIntoGridView()
        {
            LoadData.loadTable(LoadTableQuery, dgtable);
        }

        public void save()
        {
            if (toolscheck.CheckAllDataInsert(form.Controls, salaryidbox))
            {
                string insert_query = $"insert into Em_salary (Employee_id , Salary_Issue_Date, Total_Leaves, OverTime, Gross_pay_value, No_pay_value, Base_pay_value,Total_Salary, No_pay_Leaves,Workdays_Range,Begin_date_range,End_date_range) values ('{employeenamebox.SelectedValue.ToString()}', '{salaryissuedatebox.Text}' , '{totalleavebox.Text}' , '{OThoursebox.Text}' , '{grosspaybox.Text}', '{nopaybox.Text}','{basepaybox.Text}','{totalsalarybox.Text}', '{nopaylevebox.Text}','{daterangebox.Text}','{begindatebox.Text}','{enddatebox.Text}')";
                CommonCode.save(insert_query, LoadTableQuery, dgtable, form.Controls, salaryidbox);
            }
            else
            {
                MessageBox.Show("Please provide all relevant information.");
            }
        }

        public void update()
        {
            if (toolscheck.CheckAllDataInsert(form.Controls, salaryidbox))
            {
                string update_query = $"update Em_salary set Employee_id = '{employeenamebox.SelectedValue.ToString()}', Salary_Issue_Date = '{salaryissuedatebox.Text}', Total_Leaves = '{totalleavebox.Text}', OverTime = '{OThoursebox.Text}', No_pay_Leaves = '{nopaylevebox.Text}', Gross_pay_value = '{grosspaybox.Text}', No_pay_value = '{nopaybox.Text}', Base_pay_value = '{basepaybox.Text}', Total_Salary = '{totalsalarybox.Text}', Workdays_Range = '{daterangebox.Text}',Begin_date_range = '{begindatebox.Text}',End_date_range = '{enddatebox.Text}' where salary_id = '" + salaryidbox.Text + "'";
                CommonCode.update(update_query, LoadTableQuery, dgtable, form.Controls, salaryidbox);
            }
            else
            {
                MessageBox.Show("Please provide all relevant information.");
            }
        }

        public void delete()
        {
            string _delete_query = "delete from Em_salary where salary_id = '" + salaryidbox.Text + "' ";
            CommonCode.delete(_delete_query, LoadTableQuery, dgtable, form.Controls);
        }

        public void clear()
        {
            CommonCode.Clear(form.Controls);
            CommonCode.Clear(findGroupBox.Controls);
            CommonCode.Clear(payValueGroupBox.Controls);
            CommonCode.Clear(searchGroupBox.Controls);
            CommonCode.Clear(dateRangeGroupBox.Controls);
        }

        public void showFKdata()
        {
            LoadData.loadFkIntoCompoBox("select * from emp_personal_details", employeenamebox, "Employee_id", "Employee_Full_Name");
        }

        public void find_findGroup_data()
        {
            try
            {
                if (employeenamebox.SelectedIndex != -1)
                {
                    MessageBox.Show("Please Confirm the Salary issue date, Date Range Begin Date and End Date", "Alert Messsage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    SalaryDetailsCalculation.find_work_date_range(daterangebox);
                    
                    SalaryDetailsCalculation.find_total_salary(employeenamebox, totalsalarybox);

                    SalaryDetailsCalculation.find_total_leave(employeenamebox,totalleavebox,begindatebox,enddatebox);

                    SalaryDetailsCalculation.find_total_OThourse(employeenamebox, OThoursebox, begindatebox, enddatebox, salaryissuedatebox, daterangebox);
                }
                else
                {
                    MessageBox.Show("Please Select Employee Name");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        public void find_paymentGroup_Data()
        {
            if (totalsalarybox.Text != "")
            {
                SalaryDetailsCalculation.find_Nopayvalue(totalsalarybox,employeenamebox,begindatebox,enddatebox,nopaylevebox,nopaybox, daterangebox);

                SalaryDetailsCalculation.find_Basepayvalue(totalsalarybox,OThoursebox,basepaybox,employeenamebox);

                SalaryDetailsCalculation.find_Grosspayvalue(grosspaybox,basepaybox,nopaybox,salaryissuedatebox);
            }
            else
            {
                MessageBox.Show("Please find data in the Find Group");
            }
        }

        public void search_data()
        {
            string _sql = $"SELECT emp_personal_details.Employee_Full_Name, Em_salary.* FROM emp_personal_details JOIN Em_salary ON emp_personal_details.Employee_id = Em_salary.Employee_id WHERE emp_personal_details.Employee_id = '{employeenamebox.SelectedValue}'";
            LoadData.loadTable(_sql, dgtable);
        }
    }
}

