using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyInterface.generalcode;


namespace MyInterface.FormClasses
{
    internal class AdminFormClass
    {
        TextBox idbox, usernamebox, User_Typebox, passbox;
        DataGridView dgtable;
        AdminForm form;

        public AdminFormClass(AdminForm _form)
        {
            form = _form;

            idbox = form.adminIdTextBox;
            usernamebox = form.userNameTextBox;
            User_Typebox = form.UserTypeTextBox;
            passbox = form.passTextBox;
            dgtable = form.dataGridViewArea;

            dgtable.CellClick += dgtable_cell_click;
        }

        string LoadTableQuery = $"select * from Login_Details where ID_Number = '{LoginAuth.loggedUser.Id}'";

        public void LoadDataIntoGridView()
        {
            if (LoginAuth.loggedUser.Id == "1")
            {
                LoadData.loadTable($"select * from Login_Details", dgtable);
            }
            else
            {
                LoadData.loadTable(LoadTableQuery, dgtable);
            }
        }

        public void save()
        {
            if (toolscheck.CheckAllDataInsert(form.Controls, idbox))
            {
                string insert_query = $"insert into Login_Details (username , User_Type, password) values ('{usernamebox.Text}', '{User_Typebox.Text}' , '{passbox.Text}' )";
                CommonCode.save(insert_query, LoadTableQuery, dgtable, form.Controls, idbox);
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
                string update_query = $"update Login_Details set username = '{usernamebox.Text}' , User_Type = '{User_Typebox.Text}', password = '{passbox.Text}' where ID_Number = '{idbox.Text}'";
                CommonCode.update(update_query, LoadTableQuery, dgtable, form.Controls, idbox);
            }
            else
            {
                MessageBox.Show("Please provide all relevant information.");
            }
        }

        public void delete()
        {
            string _delete_query = $"delete from Login_Details where ID_Number = '" + idbox.Text + "' ";
            CommonCode.delete(_delete_query, LoadTableQuery, dgtable, form.Controls);
            CommonCode.Clear(form.Controls);
        }

        public void dgtable_cell_click(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int RowIndex = e.RowIndex;
                if (RowIndex >= 0)
                {
                    idbox.Text = dgtable.Rows[RowIndex].Cells[0].Value.ToString();
                    User_Typebox.Text = dgtable.Rows[RowIndex].Cells[1].Value.ToString();
                    usernamebox.Text = dgtable.Rows[RowIndex].Cells[2].Value.ToString();
                    passbox.Text = dgtable.Rows[RowIndex].Cells[3].Value.ToString();
                }
            }
            catch { }
        }

        public void clear()
        {
            CommonCode.Clear(form.Controls);
        }
    }
}
