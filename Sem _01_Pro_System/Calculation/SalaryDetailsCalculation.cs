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
    internal class SalaryDetailsCalculation
    {
        public static void find_work_date_range(TextBox _daterangebox)
        {
            DataTable dt = LoadData.getDataTableFromGivenSQL($"SELECT Work_Date_Range FROM workdays");
            if (dt.Rows.Count > 0)
            {
                _daterangebox.Text = dt.Rows[0]["Work_Date_Range"].ToString();
            }
        }

        public static void find_total_salary(ComboBox _employeenamebox, TextBox _totalsalarybox)
        {
            try
            {
                string id = _employeenamebox.SelectedValue.ToString();
                string _totalSalary = $"SELECT (Employee_Salary + Allowance) as TotalSalary FROM emp_personal_details WHERE Employee_id = '{id}'";

                DataTable dt = LoadData.getDataTableFromGivenSQL(_totalSalary);
                if (dt.Rows.Count > 0)
                {
                    _totalsalarybox.Text = dt.Rows[0]["TotalSalary"].ToString();
                }
                else
                {
                    _totalsalarybox.Text = "No data found";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static void find_total_leave(ComboBox _employeenamebox, TextBox _totalleavebox, DateTimePicker _begindatebox, DateTimePicker _enddatebox)
        {
            try
            {
                string totalleave = $"Select sum (No_of_Leaves) as Total_Leaves from request_leave where Employee_id = {_employeenamebox.SelectedValue.ToString()} and Leave_Begin_Date BETWEEN '{_begindatebox.Text}' AND '{_enddatebox.Text}' ";
                DataTable dt = LoadData.getDataTableFromGivenSQL(totalleave);
                if (dt.Rows.Count > 0)
                {
                    int LValue;
                    if (int.TryParse(dt.Rows[0]["Total_Leaves"].ToString(), out LValue))
                    {
                        if (LValue > 0)
                        {
                            _totalleavebox.Text = LValue.ToString();
                        }
                    }
                    else
                    {
                        _totalleavebox.Text = "0";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        public static void find_total_OThourse(ComboBox _employeenamebox, TextBox _OThoursebox, DateTimePicker _begindatebox, DateTimePicker _enddatebox, DateTimePicker _salaryissuedatebox, TextBox _daterangebox)
        {
            try
            {
                string OTQuery = $"SELECT((SELECT SUM (worked_hours) AS Worked_Hours FROM daily_attendance DA where Employee_id = '{_employeenamebox.SelectedValue.ToString()}' and DA.Intime BETWEEN '{_begindatebox.Text}' AND '{_enddatebox.Text}') - (('{_daterangebox.Text}' - (SELECT SUM (No_of_Leaves) as Total_Leaves FROM request_leave WHERE Employee_id = '{_employeenamebox.SelectedValue.ToString()}' and Leave_Begin_Date BETWEEN '{_begindatebox.Text}' AND '{_enddatebox.Text}')) * (SELECT Daily_Working_Hours FROM Configure C1 WHERE '{_salaryissuedatebox.Text}' BETWEEN C1.Annual_Year_Start_Date AND c1.Annual_Year_End_Date ))) AS Worked_OT_Hours";

                DataTable dt = LoadData.getDataTableFromGivenSQL(OTQuery);
                if (dt.Rows.Count > 0)
                {
                    int OTValue;
                    if (int.TryParse(dt.Rows[0]["Worked_OT_Hours"].ToString(), out OTValue))
                    {
                        if (OTValue > 0)
                        {
                            _OThoursebox.Text = OTValue.ToString();
                        }
                    }
                    else
                    {
                        _OThoursebox.Text = "0";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        public static void find_Nopayvalue(TextBox _totalsalarybox, ComboBox _employeenamebox, DateTimePicker _begindatebox, DateTimePicker _enddatebox, TextBox _nopaylevebox, TextBox _nopaybox, TextBox _daterangebox)
        {
            try
            {
                string id = _employeenamebox.SelectedValue.ToString();

                if (decimal.TryParse(_totalsalarybox.Text, out decimal TotalSalary))
                {
                    string NopayleveQuery = $"SELECT SUM(No_of_Leaves) AS NopayLeaves FROM request_leave WHERE Employee_id = '{id}' AND Leave_Types_id = 6 AND Leave_Begin_Date BETWEEN '{_begindatebox.Text}' AND '{_enddatebox.Text}'";
                    string noPayQuery = $"SELECT ( ({TotalSalary} / '{_daterangebox.Text}') * (Select sum (No_of_Leaves) from request_leave where Employee_id = {id} and Leave_Types_id = 6  and Leave_Begin_Date BETWEEN '{_begindatebox.Text}' AND '{_enddatebox.Text}')) as NoPayValue";

                    DataTable dt = LoadData.getDataTableFromGivenSQL(NopayleveQuery);
                    if (dt.Rows.Count > 0)
                    {
                        int nopayLeaves;
                        if (int.TryParse(dt.Rows[0]["NopayLeaves"].ToString(), out nopayLeaves))
                        {
                            _nopaylevebox.Text = dt.Rows[0]["NopayLeaves"].ToString();

                            DataTable dt1 = LoadData.getDataTableFromGivenSQL(noPayQuery);
                            if (dt1.Rows.Count > 0)
                            {
                                _nopaybox.Text = dt1.Rows[0]["NoPayValue"].ToString();
                            }
                        }
                        else
                        {
                            _nopaybox.Text = "0";
                            _nopaylevebox.Text = "0";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static void find_Basepayvalue(TextBox _totalsalarybox, TextBox _OThoursebox, TextBox _basepaybox, ComboBox _employeenamebox)
        {
            try
            {
                if (decimal.TryParse(_totalsalarybox.Text, out decimal TotalSalary) && decimal.TryParse(_OThoursebox.Text, out decimal Worked_OT_Hours))
                {
                    string basePayQuery = $"SELECT ({TotalSalary} + ((SELECT OT_Rate_Hourly FROM emp_personal_details WHERE Employee_id = '{_employeenamebox.SelectedValue.ToString()}') * {Worked_OT_Hours})) AS BasePayValue";

                    DataTable dt = LoadData.getDataTableFromGivenSQL(basePayQuery);
                    if (dt.Rows.Count > 0)
                    {
                        _basepaybox.Text = dt.Rows[0]["BasePayValue"].ToString();
                    }
                    else
                    {
                        _basepaybox.Text = "0";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        public static void find_Grosspayvalue(TextBox _grosspaybox, TextBox _basepaybox, TextBox _nopaybox, DateTimePicker _salaryissuedatebox)
        {
            try
            {
                if (decimal.TryParse(_basepaybox.Text, out decimal basepayvalue) && decimal.TryParse(_nopaybox.Text, out decimal nopayvalue))
                {
                    string grossPayQuery = $"SELECT ({basepayvalue} - ({nopayvalue} + {basepayvalue} * (select Tax_Rate FROM Configure C1 WHERE '{_salaryissuedatebox.Text}' BETWEEN C1.Annual_Year_Start_Date AND c1.Annual_Year_End_Date) )) as GrossPayValue";
                    DataTable dt = LoadData.getDataTableFromGivenSQL(grossPayQuery);
                    if (dt.Rows.Count > 0)
                    {
                        _grosspaybox.Text = dt.Rows[0]["GrossPayValue"].ToString();
                    }
                    else
                    {
                        _grosspaybox.Text = "0";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }           
        }
    }
}
