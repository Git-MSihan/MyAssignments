using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyInterface.generalcode
{
    internal class LoadData
    {
        private static SqlConnection connect_sql = new SqlConnection("Data Source=SIFATHEEK;Initial Catalog=grifindo_toys;Integrated Security=True");

        public static void loadpanel(Form formN, Panel panelN)
        {
            try
            {
                panelN.Controls.Clear();
                formN.TopLevel = false;
                formN.AutoScroll = false;
                panelN.Controls.Add(formN);
                formN.FormBorderStyle = FormBorderStyle.None;
                formN.Dock = DockStyle.Fill;
                formN.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void loadTable(string _sql, DataGridView dataGridViewN)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(_sql, connect_sql);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewN.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static DataTable getDataTableFromGivenSQL(string sql_query)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql_query, connect_sql);
            dataAdapter.Fill(dt);
            return dt;
        }

        public static void loadFkIntoCompoBox(string sql_query, ComboBox _mybox, string idColumnName, string _nameColumnNamed)
        {
            DataTable dt = getDataTableFromGivenSQL(sql_query);
            _mybox.DisplayMember = _nameColumnNamed;
            _mybox.ValueMember = idColumnName;
            _mybox.DataSource = dt;
        }
    }
}
