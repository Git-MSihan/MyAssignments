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

        string LoadTableQuery = $"select * from Employee_Types_Details";

        public void LoadDataIntoGridView()
        {
            LoadData.loadTable(LoadTableQuery, dgtable);
        }

        public void save()
        {
            if (toolscheck.CheckAllDataInsert(form.Controls, idbox))
            {
                string insert_query = $"insert into Employee_Types_Details (Employee_Type) values ('{typebox.Text}')";
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
                string update_query = $"update Employee_Types_Details set Employee_Type = '{typebox.Text}' where Employee_Type_id = '{idbox.Text}'";
                CommonCode.update(update_query, LoadTableQuery, dgtable, form.Controls, idbox);
            }
            else
            {
                MessageBox.Show("Please provide all relevant information.");
            }
        }

        public void delete()
        {
            string _delete_query = "delete from Employee_Types_Details where Employee_Type_id = '" + idbox.Text + "' ";
            CommonCode.delete(_delete_query, LoadTableQuery, dgtable, form.Controls);
        }

        public void clear()
        {
            CommonCode.Clear(form.Controls);
        }
    }
}   
