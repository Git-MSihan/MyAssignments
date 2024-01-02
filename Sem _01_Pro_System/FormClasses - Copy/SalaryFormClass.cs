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
                general.save(insert_query, LoadTableQuery, dgtable, form.Controls, salaryidbox);
            }
            else
            {
                MessageBox.Show("Please provide all relevant information.");
            }
        }

        public void update()
        {
            string update_query = $"update Em_salary set Employee_id = '{employeenamebox.SelectedValue.ToString()}', Salary_Issue_Date = '{salaryissuedatebox.Text}', Total_Leaves = '{totalleavebox.Text}', OverTime = '{OThoursebox.Text}', No_pay_Leaves = '{nopaylevebox.Text}', Gross_pay_value = '{grosspaybox.Text}', No_pay_value = '{nopaybox.Text}', Base_pay_value = '{basepaybox.Text}', Total_Salary = '{totalsalarybox.Text}', Workdays_id = '{daterangeidbox.Text}' where salary_id = '" + salaryidbox.Text + "'";
            general.update(update_query, LoadTableQuery, dgtable, form.Controls, salaryidbox);
        }

        public void delete() 
        {
            string _delete_query = "delete from Em_salary where salary_id = '" + salaryidbox.Text + "' ";
            general.delete(_delete_query, LoadTableQuery, dgtable, form.Controls);
        }

        public void clear()
        {
            general.Clear(form.Controls);
            general.Clear(findGroupBox.Controls);
            general.Clear(payValueGroupBox.Controls);
            general.Clear(searchGroupBox.Controls);
            general.Clear(dateRangeGroupBox.Controls);
        }

        public void showFKdata()
        {
            LoadData.loadFkIntoCompoBox("select * from emp_personal_details", employeenamebox, "Employee_id", "Employee_Full_Name");

            LoadData.loadFkIntoCompoBox($"Select * from workdays", daterangeidbox, "Wo_id", "Wo_id");
        }

        public void find_date_in_dateRangeroup()
        {
            string _find = $"select * from workdays where Wo_id = '{daterangeidbox.Text}'";
            DataTable dt = LoadData.getDataTableFromGivenSQL(_find);
            if (dt.Rows.Count > 0)
            {
                string startDate = dt.Rows[0]["Work_Begin_Date"].ToString();
                string endDate = dt.Rows[0]["Work_End_Date"].ToString();
                begindatebox.Text = startDate.Substring(0, startDate.IndexOf(" ")+1);
                enddatebox.Text = endDate.Substring(0, startDate.IndexOf(" ") + 1);
            }
        }

        public void find_findGroup_data()
        {
            try
            {
                MessageBox.Show("Please Confirm the Sallary issue date", "Alert Messsage",MessageBoxButtons.OK ,MessageBoxIcon.Information);
                if (daterangeidbox.SelectedIndex != -1)
                {
                    if (employeenamebox.SelectedIndex != -1)
                    {
                        string id = employeenamebox.SelectedValue.ToString();
                        string _totalSalary = $"SELECT (Employee_Salary + Allowance) as TotalSalary FROM emp_personal_details WHERE Employee_id = '{id}'";

                        try
                        {
                            DataTable dt = LoadData.getDataTableFromGivenSQL(_totalSalary);
                            if (dt.Rows.Count > 0)
                            {
                                totalsalarybox.Text = dt.Rows[0]["TotalSalary"].ToString();
                            }
                            else
                            {
                                totalsalarybox.Text = "No data found";
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }

                        try
                        {
                            string totalleve = $"Select sum (No_of_Leaves) as Total_Leaves from request_leave where Employee_id = {id} and Leave_Begin_Date BETWEEN '{begindatebox.Text}' AND '{enddatebox.Text}' ";
                            DataTable dt = LoadData.getDataTableFromGivenSQL(totalleve);
                            if (dt.Rows.Count > 0)
                            {
                                int LValue;
                                if (int.TryParse(dt.Rows[0]["Total_Leaves"].ToString(), out LValue))
                                {
                                    if (LValue > 0)
                                    {
                                        totalleavebox.Text = LValue.ToString();
                                    }
                                }
                                else
                                {
                                    totalleavebox.Text = "0";
                                }
                            }
                            else
                            {
                                totalleavebox.Text = "No data found";
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }

                        string OTQuery = $"SELECT((SELECT SUM (worked_hours) AS Worked_Hours FROM daily_attendance DA where Employee_id = '{id}' and DA.Intime BETWEEN '{begindatebox.Text}' AND '{enddatebox.Text}') - (((SELECT Work_Date_Range FROM workdays WHERE Wo_id = '{daterangeidbox.Text}') - (SELECT SUM (No_of_Leaves) as Total_Leaves FROM request_leave WHERE Employee_id = '{id}' and Leave_Begin_Date BETWEEN '{begindatebox.Text}' AND '{enddatebox.Text}')) * (SELECT Daily_Working_Hours FROM Configure C1 WHERE '{salaryissuedatebox.Text}' BETWEEN C1.Annual_Year_Start_Date AND c1.Annual_Year_End_Date ))) AS Worked_OT_Hours";
                        try
                        {
                            DataTable dt = LoadData.getDataTableFromGivenSQL(OTQuery);
                            if (dt.Rows.Count > 0)
                            {
                                int OTValue;
                                if (int.TryParse(dt.Rows[0]["Worked_OT_Hours"].ToString(), out OTValue))
                                {
                                    if (OTValue > 0)
                                    {
                                        OThoursebox.Text = OTValue.ToString();
                                    }
                                    else
                                    {
                                        OThoursebox.Text = "0";
                                    }
                                }
                                else
                                {
                                    OThoursebox.Text = "0";
                                }
                            }
                            else
                            {
                                OThoursebox.Text = "No data found";
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
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
                string id = employeenamebox.SelectedValue.ToString();

                if (decimal.TryParse(totalsalarybox.Text, out decimal TotalSalary) && decimal.TryParse(OThoursebox.Text, out decimal Worked_OT_Hours))
                {
                    try
                    {
                        string NopayleveQuery = $"SELECT SUM(No_of_Leaves) AS NopayLeaves FROM request_leave WHERE Employee_id = '{id}' AND Leave_Types_id = 6 AND Leave_Begin_Date BETWEEN '{begindatebox.Text}' AND '{enddatebox.Text}'";
                        string noPayQuery = $"SELECT ( ({TotalSalary} / (SELECT Work_Date_Range FROM workdays WHERE Wo_id = '{daterangeidbox.Text}')) * (Select sum (No_of_Leaves) as nopayLeves from request_leave where Employee_id = {id} and Leave_Types_id = 6  and Leave_Begin_Date BETWEEN '{begindatebox.Text}' AND '{enddatebox.Text}') ) as NoPayValue";

                        DataTable dt = LoadData.getDataTableFromGivenSQL(NopayleveQuery);
                        if (dt.Rows.Count > 0)
                        {
                            int nopayLeaves;
                            if (int.TryParse(dt.Rows[0]["NopayLeaves"].ToString(), out nopayLeaves))
                            {
                                nopaylevebox.Text = dt.Rows[0]["NopayLeaves"].ToString();

                                DataTable dt1 = LoadData.getDataTableFromGivenSQL(noPayQuery);
                                if (dt1.Rows.Count > 0)
                                {
                                    nopaybox.Text = dt.Rows[0]["NoPayValue"].ToString();
                                }
                                else
                                {
                                    nopaybox.Text = "No data found";
                                }
                            }
                            else
                            {
                                nopaybox.Text = "0";
                                nopaylevebox.Text = "0";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }

                    try
                    {
                        string basePayQuery = $"SELECT ({TotalSalary} + ((SELECT OT_Rate_Hourly FROM emp_personal_details WHERE Employee_id = '{id}') * {Worked_OT_Hours})) AS BasePayValue";

                        DataTable dt = LoadData.getDataTableFromGivenSQL(basePayQuery);
                        if (dt.Rows.Count > 0)
                        {
                            basepaybox.Text = dt.Rows[0]["BasePayValue"].ToString();
                        }
                        else
                        {
                            basepaybox.Text = "NO ";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid data entered for calculations");
                }
            }
            else
            {
                MessageBox.Show("Please find data in the Find Group");
            }

            if (decimal.TryParse(basepaybox.Text, out decimal basepayvalue) && decimal.TryParse(nopaybox.Text, out decimal nopayvalue))
            {
                try
                {
                    string grossPayQuery = $"SELECT ({basepayvalue} - ({nopayvalue} + {basepayvalue} * (select Tax_Rate FROM Configure C1 WHERE '{salaryissuedatebox.Text}' BETWEEN C1.Annual_Year_Start_Date AND c1.Annual_Year_End_Date) )) as GrossPayValue";
                    DataTable dt = LoadData.getDataTableFromGivenSQL(grossPayQuery);
                    if (dt.Rows.Count > 0)
                    {
                        grosspaybox.Text = dt.Rows[0]["GrossPayValue"].ToString();
                    }
                    else
                    {
                        grosspaybox.Text = "No data found";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        public void search_data()
        {
            string _sql = $"SELECT emp_personal_details.Employee_Full_Name, Em_salary.* FROM emp_personal_details JOIN Em_salary ON emp_personal_details.Employee_id = Em_salary.Employee_id WHERE emp_personal_details.Employee_id = '{employeenamebox.SelectedValue}'";
            LoadData.loadTable(_sql, dgtable);
        }
    }
}

