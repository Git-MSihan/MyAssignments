using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MyInterface.generalcode
{
    internal class CommonCode
    {
        private static SqlConnection connect_sql = new SqlConnection("Data Source=SIFATHEEK;Initial Catalog=grifindo_toys;Integrated Security=True");

        public static void save(string insert_query, string Load_table_query, DataGridView dataGridViewName, Control.ControlCollection controls, TextBox PKbox)
        {
            try
            {
                connect_sql.Open();
                SqlCommand cmd = new SqlCommand(insert_query, connect_sql);
                int rowsCount = cmd.ExecuteNonQuery();
                if (rowsCount > 0)
                {
                    MessageBox.Show("Insert Successful");
                    LoadData.loadTable(Load_table_query, dataGridViewName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connect_sql.Close();
            }
        }


        public static void update(string update_query, string Load_table_query, DataGridView dataGridViewName, Control.ControlCollection controls, TextBox PKbox)
        {
            try
            {
                if (MessageBox.Show("Sure! Do you want to Update ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    connect_sql.Open();
                    SqlCommand cmd = new SqlCommand(update_query, connect_sql);
                    int affectedRows = cmd.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Update Successful");
                        LoadData.loadTable(Load_table_query, dataGridViewName);
                    }
                }
                else
                {
                    MessageBox.Show("Please provide all relevant information.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connect_sql.Close();
            }
        }


        public static void delete(string delet_query, string Load_table_query, DataGridView dataGridViewName, Control.ControlCollection _this)
        {
            try
            {
                if (MessageBox.Show("Sure! Do you want to Delete ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    connect_sql.Open();

                    SqlCommand cmd = new SqlCommand(delet_query, connect_sql);
                    int RowsCount = cmd.ExecuteNonQuery();
                    if (RowsCount > 0)
                    {
                        MessageBox.Show("Delete Successful");
                        LoadData.loadTable(Load_table_query, dataGridViewName);
                        CommonCode.Clear(_this);
                    }
                    else
                    {
                        MessageBox.Show("Please select the data");
                    }
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connect_sql.Close();
            }
        }



        public static void Clear(Control.ControlCollection controls)
        {
            try
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                    {
                        ((TextBox)control).Clear();
                    }
                    else if (control is ComboBox)
                    {
                        ((ComboBox)control).SelectedIndex = -1;
                    }
                    else if (control is DateTimePicker)
                    {
                        ((DateTimePicker)control).Value = DateTime.Now;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
