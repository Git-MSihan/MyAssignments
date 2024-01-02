using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyInterface;
using MyInterface.generalcode;

namespace MyInterface.FormClasses
{
    internal class workdaysFormClass
    {
        TextBox idbox, daterangebox, adminidbox;
        DateTimePicker startdatebox, enddatebox;
        DataGridView dgtable;
        workdaysForm form;

        public workdaysFormClass(workdaysForm _form)
        {
            form = _form;
            idbox = form.idTextBox;
            daterangebox = form.dateRangeTextBox;
            adminidbox = form.adminIdTextBox;
            startdatebox = form.beginDateTimePicker;
            enddatebox = form.endDateTimePicker;
            dgtable = form.dataGridViewArea;

            dgtable.CellClick += table_cell_click;
        }

        private void table_cell_click(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex;
            if (RowIndex >= 0 )
            {
                idbox.Text = dgtable.Rows[RowIndex].Cells[0].Value.ToString();
                startdatebox.Text = dgtable.Rows[RowIndex].Cells[1].Value.ToString();
                enddatebox.Text = dgtable.Rows[RowIndex].Cells[2].Value.ToString();
                daterangebox.Text = dgtable.Rows[RowIndex].Cells[3].Value.ToString();
                adminidbox.Text = dgtable.Rows[RowIndex].Cells[4].Value.ToString();
            }
        }

        string LoadTableQuery = $"select * from workdays";

        public void LoadDataIntoGridView()
        {
            LoadData.loadTable(LoadTableQuery, dgtable);
        }

        public void save()
        {
            string insert_query = $"insert into workdays (Work_Begin_Date , Work_End_Date, Work_Date_Range, Admin_id ) values ('{startdatebox.Text}', '{enddatebox.Text}' , '{daterangebox.Text}', '{adminidbox.Text}' )";
            general.save(insert_query, LoadTableQuery, dgtable, form.Controls, idbox);
        }

        public void update()
        {
            string update_query = $"update workdays set Work_Begin_Date = '{startdatebox.Text}', Work_End_Date = '{enddatebox.Text}', Work_Date_Range = '{daterangebox.Text}', Admin_id ='{adminidbox.Text}' where Wo_id = '" + idbox.Text + "'";
            general.update(update_query, LoadTableQuery, dgtable, form.Controls, idbox);
        }

        public void delete()
        {
            string _delete_query = $"delete from workdays where Wo_id = '" + idbox.Text + "' ";
            general.delete(_delete_query, LoadTableQuery, dgtable, form.Controls);
        }

        public void clear()
        {
            general.Clear(form.Controls);
        }
    }
}
