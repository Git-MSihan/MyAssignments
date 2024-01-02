using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyInterface.generalcode;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MyInterface.FormClasses
{
    internal class typesofLeaveFormClass
    {
        TextBox idbox, typesbox;
        DataGridView dgtable;
        typesofLeaveForm form;

        public typesofLeaveFormClass (typesofLeaveForm _form)
        {
            form = _form;
            idbox = form.idTextBox;
            typesbox = form.leaveTypesTextBox;
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
                    typesbox.Text = dgtable.Rows[RowIndex].Cells[1].Value.ToString();
                }
            }
            catch { }
        }

        string LoadTableQuery = $"select * from type_of_leaves";

        public void LoadDataIntoGridView()
        {
            LoadData.loadTable(LoadTableQuery, dgtable);
        }

        public void save()
        {
            if (toolscheck.CheckAllDataInsert(form.Controls, idbox))
            {
                string insert_query = $"insert into type_of_leaves (Leave_Type) values ('{typesbox.Text}')";
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
                string update_query = $"update type_of_leaves set Leave_Type = '{typesbox.Text}'  where Leave_Type_id = '" + idbox.Text + "'";
                CommonCode.update(update_query, LoadTableQuery, dgtable, form.Controls, idbox);
            }
            else
            {
                MessageBox.Show("Please provide all relevant information.");
            }
        }

        public void delete()
        {
            string _delete_query = "delete from type_of_leaves where Leave_Type_id = '" + idbox.Text + "' ";
            CommonCode.delete(_delete_query, LoadTableQuery, dgtable, form.Controls);
        }

        public void clear()
        {
            CommonCode.Clear(form.Controls);
        }
    }
}
