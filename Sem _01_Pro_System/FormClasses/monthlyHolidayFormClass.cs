using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyInterface.generalcode;


namespace MyInterface.FormClasses
{
    internal class monthlyHolidayFormClass
    {
        TextBox idbox, holinamebox;
        DateTimePicker datebox;
        MaskedTextBox adminidbox;
        DataGridView dgtable;
        monthlyHolidayForm form;

        public monthlyHolidayFormClass(monthlyHolidayForm _form)
        {
            form = _form;
            idbox = form.idTextBox;
            holinamebox = form.holidayNameTextBox;
            adminidbox = form.AdminIdMaskedTextBox;
            datebox = form.holidayDateTimePicker;
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
                    holinamebox.Text = dgtable.Rows[RowIndex].Cells[1].Value.ToString();
                    datebox.Text = dgtable.Rows[RowIndex].Cells[2].Value.ToString();
                    adminidbox.Text = dgtable.Rows[RowIndex].Cells[3].Value.ToString();
                }
            }
            catch { }
        }

        string LoadTableQuery = $"select * from Monthly_holiday";

        public void LoadDataIntoGridView()
        {
            LoadData.loadTable(LoadTableQuery, dgtable);
        }

        public void save()
        {
            if (toolscheck.CheckAllDataInsert(form.Controls, idbox))
            {
                string insert_query = $"insert into Monthly_holiday (Holiday_Name , Holiday_Date, Admin_id ) values ('{holinamebox.Text}', '{datebox.Text}' , '{LoginAuth.loggedUser.Id}' )";
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
                string update_query = $"update Monthly_holiday set Holiday_Name = '{holinamebox.Text}', Holiday_Date = '{datebox.Text}', Admin_id = '{LoginAuth.loggedUser.Id}' where Holiday_id = '" + idbox.Text + "'";
                CommonCode.update(update_query, LoadTableQuery, dgtable, form.Controls, idbox);
            }
            else
            {
                MessageBox.Show("Please provide all relevant information.");
            }
        }

        public void delete()
        {
            string _delete_query = "delete from Monthly_holiday where Holiday_id = '" + idbox.Text + "' ";
            CommonCode.delete(_delete_query, LoadTableQuery, dgtable, form.Controls);
        }

        public void clear()
        {
            CommonCode.Clear(form.Controls);
        }
    }
}
