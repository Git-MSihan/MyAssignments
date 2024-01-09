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
        GroupBox loginbox;

        public dashboardClass(homeForm _form)
        {
            form  = _form;
            usernamebox = form.usernameTextBox;
            passwordbox = form.passwordTextBox;
            Ladminidbox = form.loginedAdminIdTextBox;
            passsow = form.shopasCheckBox;
            _dadhbordpanel = form.DashbordLoadpanelArea;
            loginbox = form.loginGroupBox;
        }


        public void login()
        {
            try
            {
                if (usernamebox.Text.Trim() == "" && passwordbox.Text.Trim() == "")
                {
                    MessageBox.Show("Please insert your Username.");
                }
                else if (passwordbox.Text.Trim() == "")
                {
                    MessageBox.Show("Please insert your Password.");
                }
                else
                {
                    string Login_query = $" select * from Login_Details where Username = '" + usernamebox.Text + "' and Password = '" + passwordbox.Text + "' ";
                    DataTable dt = LoadData.getDataTableFromGivenSQL(Login_query);
                    if (dt.Rows.Count == 1)
                    {
                        passwordbox.Clear();
                        usernamebox.Clear();
                        string id = dt.Rows[0]["ID_Number"].ToString();
                        Ladminidbox.Text = id;
                        LoginAuth.loggedUser = new LoginAuth()
                        {
                            Id = dt.Rows[0]["ID_Number"].ToString(),
                            UserType = dt.Rows[0]["User_Type"].ToString(),
                            Username = dt.Rows[0]["Username"].ToString(),
                            Password = dt.Rows[0]["Password"].ToString(),
                        };
                        loginbox.Hide();
                        MessageBox.Show("Login Successful");
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password");
                    }
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
