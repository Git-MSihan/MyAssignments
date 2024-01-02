using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyInterface.generalcode;


namespace MyInterface.FormClasses
{
    internal class empTypeFormClass
    {
        TextBox idbox, typebox;
        DataGridView dgtable;
        empTypeForm form;

        public empTypeFormClass (empTypeForm _form)
        {
            form = _form;
            idbox = form.idTextBox;
            typebox = form.empTypeTextBox;
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
                    typebox.Text = dgtable.Rows[RowIndex].Cells[1].Value.ToString();
                }
            }
            catch { }
        }

        string LoadTableQuery = $"select * from Employee_Types";

        public void LoadDataIntoGridView()
        {
            LoadData.loadTable(LoadTableQuery, dgtable);
        }

        public void save()
        {
            string insert_query = $"insert into Employee_Types (Emloyee_Type) values ('{typebox.Text}')";
            general.save(insert_query, LoadTableQuery, dgtable, form.Controls, idbox);
        }

        public void update()
        {
            string update_query = $"update Employee_Types set Emloyee_Types = '{typebox.Text}' where Emloyee_Type_id = '{idbox.Text}'";
            general.update(update_query, LoadTableQuery, dgtable, form.Controls, idbox);
        }

        public void delete()
        {
            string _delete_query = "delete from Employee_Types where Emloyee_Type_id = '" + idbox.Text + "' ";
            general.delete(_delete_query, LoadTableQuery, dgtable, form.Controls);
        }

        public void clear()
        {
            general.Clear(form.Controls);
        }
    }
}   
