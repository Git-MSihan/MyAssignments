﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyInterface.generalcode;

namespace MyInterface.FormClasses
{
    internal class ConfigureFormClass
    {
        TextBox idbox, workinghoursbox, annualleavebox, taxratebox;
        DateTimePicker stardbox, endbox;
        DataGridView dgtable;
        ConfigureForm form;
        MaskedTextBox adminidbox;

        public ConfigureFormClass(ConfigureForm _form)
        {
            form = _form;
            idbox = form.idTextBox;
            workinghoursbox = form.workinghoursTextBox;
            annualleavebox = form.annualLeaveTextBox;
            taxratebox = form.taxRateTextBox;
            adminidbox = form.AdminIdMaskedTextBox;
            stardbox = form.startDateTimePicker;
            endbox = form.endDateTimePicker;
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
                    workinghoursbox.Text = dgtable.Rows[RowIndex].Cells[1].Value.ToString();
                    stardbox.Text = dgtable.Rows[RowIndex].Cells[2].Value.ToString();
                    endbox.Text = dgtable.Rows[RowIndex].Cells[3].Value.ToString();
                    annualleavebox.Text = dgtable.Rows[RowIndex].Cells[4].Value.ToString();
                    taxratebox.Text = dgtable.Rows[RowIndex].Cells[5].Value.ToString();
                    adminidbox.Text = dgtable.Rows[RowIndex].Cells[6].Value.ToString();
                }
            }
            catch { }
        }

        string LoadTableQuery = $"SELECT * FROM Configure";

        public void LoadDataIntoGridView()
        {
            LoadData.loadTable(LoadTableQuery, dgtable);
        }

        public void save()
        {
            if (toolscheck.CheckAllDataInsert(form.Controls, idbox))
            {
                string insert_query = $"insert into Configure (Daily_Working_Hours , Annual_Year_Start_Date, Annual_Year_End_Date, Annually_Leves, Tax_Rate, Admin_id) values ('{workinghoursbox.Text}', '{stardbox.Text}' , '{endbox.Text}', '{annualleavebox.Text}','{taxratebox.Text}', '{LoginAuth.loggedUser.Id}')";
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
                string update_query = $"update Configure set Daily_Working_Hours = '{workinghoursbox.Text}', Annual_Year_Start_Date = '{stardbox.Text}', Annual_Year_End_Date = '{endbox.Text}' ,Annually_Leves = '{annualleavebox.Text}' , Tax_Rate = '{taxratebox.Text}', Admin_id = '{LoginAuth.loggedUser.Id}' where Config_id ='" + idbox.Text + "'";
                CommonCode.update(update_query, LoadTableQuery, dgtable, form.Controls, idbox);
            }
            else
            {
                MessageBox.Show("Please provide all relevant information.");
            }
        }

        public void delete()
        {
            string _delete_query = "delete from Configure where Config_id = '" + idbox.Text + "' ";
            CommonCode.delete(_delete_query, LoadTableQuery, dgtable, form.Controls);
        }

        public void clear()
        {
            CommonCode.Clear(form.Controls);
        }

        public void hoverMsg()
        {
            string message = "Input the Tax rate in decimal format like 0.08";
            showMsgHover.show_msg_mouseHover(taxratebox, message);
        }
    }
}