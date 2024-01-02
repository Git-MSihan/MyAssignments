using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyInterface.generalcode;

namespace MyInterface.Calculation
{
    internal class dailyAttendanceCalculation
    {

        // an emplyee can't work continuously for 24 hours and the calculation not accept to isert 24 hours or more than, cobtinuously
        /*public static bool DontAccept24Hours(DateTimePicker intimeText, DateTimePicker outTimeText, TextBox workHourBox)
        {
            try
            {
                DateTime intime = DateTime.Parse(intimeText.Text);
                DateTime outTime = DateTime.Parse(outTimeText.Text);

                DateTime fixedTime = intime.AddDays(1);

                if(workHourBox.Text <= 0)
                {
                    MessageBox.Show("Check the Out-Time.");
                    return false;

                }
                else if(outTime >= fixedTime)
                {
                    MessageBox.Show("You cannot work continuously for 24 hours.");
                    return false;
                }
                else
                {
                    int Hours = (outTime - intime).Hours;
                    workHourBox.Text = Hours.ToString();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }*/

        public static bool DontAccept24Hours(DateTimePicker intimeText, DateTimePicker outTimeText, TextBox workHourBox)
        {
            try
            {
                DateTime intime = DateTime.Parse(intimeText.Text);
                DateTime outTime = DateTime.Parse(outTimeText.Text);

                TimeSpan duration = outTime - intime;

                if (duration.TotalHours <= 0)
                {
                    MessageBox.Show("Check the Out-Time.");
                    return false;
                }
                else
                {
                    int hoursWorked = (int)duration.TotalHours;
                    workHourBox.Text = hoursWorked.ToString();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        /* the calculation for : 
            count the worked hours in a day */
        public static void findWorkedHourse(DateTimePicker _intimeText, DateTimePicker _outimeText, TextBox _workHourBox)
        {
            try
            {
                DateTime intime = DateTime.Parse(_intimeText.Text);
                DateTime outTime = DateTime.Parse(_outimeText.Text);
                TimeSpan duration = outTime - intime;
                _workHourBox.Text = duration.ToString();
            }
            catch { }
        }
    }
}
