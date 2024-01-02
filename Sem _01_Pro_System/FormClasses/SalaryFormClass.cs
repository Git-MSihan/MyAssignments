using System;
using System.Data;
using System.Windows.Forms;
using MyInterface.Calculation;
using MyInterface.generalcode;

namespace MyInterface.FormClasses
{
    internal class SalaryFormClass
    {

        TextBox begindatebox, enddatebox, totalsalarybox, OThoursebox, totalleavebox, basepaybox, nopaybox, grosspaybox, nopaylevebox, salaryidbox;
        ComboBox daterangeidbox, employeenamebox;
        DateTimePicker salaryissuedatebox;
        DataGridView dgtable;
        salaryForm form;
        GroupBox findGroupBox, payValueGroupBox, searchGroupBox, dateRangeGroupBox;

        public SalaryFormClass(salaryForm _form)
        {
            form = _form;
            salaryidbox = form.idTextBox;
            daterangeidbox = form.rangeIdComboBox;
            begindatebox = form.beginDateTextBox;
            enddatebox = form.endDateTextBox;
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
                    daterangeidbox.Text = dgtable.Rows[RowIndex].Cells[11].Value.ToString();
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
                string insert_query = $"insert into Em_salary (Employee_id , Salary_Issue_Date, Total_Leaves, OverTime, Gross_pay_value, No_pay_value, Base_pay_value,Total_Salary, No_pay_Leaves,Workdays_id) values ('{employeenamebox.SelectedValue.ToString()}', '{salaryissuedatebox.Text}' , '{totalleavebox.Text}' , '{OThoursebox.Text}' , '{grosspaybox.Text}', '{nopaybox.Text}','{basepaybox.Text}','{totalsalarybox.Text}', '{nopaylevebox.Text}','{daterangeidbox.Text}')";
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
                string update_query = $"update Em_salary set Employee_id = '{employeenamebox.SelectedValue.ToString()}', Salary_Issue_Date = '{salaryissuedatebox.Text}', Total_Leaves = '{totalleavebox.Text}', OverTime = '{OThoursebox.Text}', No_pay_Leaves = '{nopaylevebox.Text}', Gross_pay_value = '{grosspaybox.Text}', No_pay_value = '{nopaybox.Text}', Base_pay_value = '{basepaybox.Text}', Total_Salary = '{totalsalarybox.Text}', Workdays_id = '{daterangeidbox.Text}' where salary_id = '" + salaryidbox.Text + "'";
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

            LoadData.loadFkIntoCompoBox($"Select * from workdays", daterangeidbox, "Wo_id", "Wo_id");
        }

        public void find_date_in_dateRangeroup()
        {
            SalaryDetailsCalculation.Find_dates_in_dateRangeroup(daterangeidbox, begindatebox,enddatebox);
        }

        public void find_findGroup_data()
        {
            try
            {
                if (daterangeidbox.SelectedIndex != -1)
                {
                    if (employeenamebox.SelectedIndex != -1)
                    {
                        MessageBox.Show("Please Confirm the Sallary issue date", "Alert Messsage", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        SalaryDetailsCalculation.find_total_salary(employeenamebox, totalsalarybox);

                        SalaryDetailsCalculation.find_total_leave(employeenamebox,totalleavebox,begindatebox,enddatebox);

                        SalaryDetailsCalculation.find_total_OThourse(employeenamebox, OThoursebox, begindatebox, enddatebox, salaryissuedatebox, daterangeidbox);
                    }
                    else
                    {
                        MessageBox.Show("Please Select Employee Name");
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Date Range ID");
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
                SalaryDetailsCalculation.find_Nopayvalue(totalsalarybox,employeenamebox,daterangeidbox,begindatebox,enddatebox,nopaylevebox,nopaybox);

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

