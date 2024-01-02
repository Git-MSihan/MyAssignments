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
    internal class dashboardClass
    {
        TextBox usernamebox, passwordbox, Ladminidbox;
        CheckBox passsow;
        homeForm form;
        Panel _dadhbordpanel;

        public dashboardClass(homeForm _form)
        {
            form  = _form;
            usernamebox = form.usernameTextBox;
            passwordbox = form.passwordTextBox;
            Ladminidbox = form.loginedAdminIdTextBox;
            passsow = form.shopasCheckBox;
            _dadhbordpanel = form.DashbordLoadpanelArea;
        }


        public void login()
        {
            try
            {
                if (toolscheck.CheckAllDataInsert(form.Controls, Ladminidbox))
                {
                    string Login_query = $" select * from admin where Username = '" + usernamebox.Text + "' and Password = '" + passwordbox.Text + "' ";
                    DataTable dt = LoadData.getDataTableFromGivenSQL(Login_query);
                    if (dt.Rows.Count == 1)
                    {
                        passwordbox.Clear();
                        usernamebox.Clear();
                        string id = dt.Rows[0]["Admin_id"].ToString();
                        Ladminidbox.Text = id;
                        MessageBox.Show("Login Successful");
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password");
                        passwordbox.Clear();
                        usernamebox.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Please insert your username and password.");
                }
            }
            catch { }
        }

        public void showpassword()
        {
            if (passsow.Checked == true)
            {
                passwordbox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordbox.UseSystemPasswordChar = true;
            }
        }

        public void Loginpage()
        {
            form.Hide();
            homeForm Nform = new homeForm();
            Nform.Show();
        }

        public void employeebtn()
        {
            if(Ladminidbox.Text != "")
            {
                LoadData.loadpanel(new EmpMenuForm(), _dadhbordpanel);
            }
            else
            {
                MessageBox.Show("Please Login First");
            }
        }

        public void salarybtn()
        {
            if (Ladminidbox.Text != "")
            {
                LoadData.loadpanel(new salMenuForm(), _dadhbordpanel);
            }
            else
            {
                MessageBox.Show("Please Login First");
            }
        }

        public void settingbtn()
        {
            if (Ladminidbox.Text != "")
            {
                LoadData.loadpanel(new setMenuForm(), _dadhbordpanel);
            }
            else
            {
                MessageBox.Show("Please Login First");
            }
        }

        public void leavesbtn()
        {
            if (Ladminidbox.Text != "")
            {
                LoadData.loadpanel(new empLeaveMenuForm(), _dadhbordpanel);
            }
            else
            {
                MessageBox.Show("Please Login First");
            }
        }

        public void attendencebtn()
        {
            if (Ladminidbox.Text != "")
            {
                LoadData.loadpanel(new dailyAtteForm(), _dadhbordpanel);
            }
            else
            {
                MessageBox.Show("Please Login First");
            }
        }
    }
}
