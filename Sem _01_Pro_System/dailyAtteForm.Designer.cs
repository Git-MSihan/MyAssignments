namespace MyInterface
{
    partial class dailyAtteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.empNComboBox = new System.Windows.Forms.ComboBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.dltBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.dataGridViewArea = new System.Windows.Forms.DataGridView();
            this.inTimePicker = new System.Windows.Forms.DateTimePicker();
            this.outTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.ClrBtn = new System.Windows.Forms.Button();
            this.workedHourseTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.findBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArea)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(95)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(383, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 48);
            this.label1.TabIndex = 18;
            this.label1.Text = "Daily Attendance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 23);
            this.label2.TabIndex = 50;
            this.label2.Text = "Attendance Id :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(197, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 23);
            this.label5.TabIndex = 50;
            this.label5.Text = "Intime :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(176, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 23);
            this.label6.TabIndex = 50;
            this.label6.Text = "Out time :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(114, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 23);
            this.label8.TabIndex = 50;
            this.label8.Text = "Employee Name :";
            // 
            // empNComboBox
            // 
            this.empNComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.empNComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.empNComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empNComboBox.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empNComboBox.FormattingEnabled = true;
            this.empNComboBox.Location = new System.Drawing.Point(285, 172);
            this.empNComboBox.Name = "empNComboBox";
            this.empNComboBox.Size = new System.Drawing.Size(516, 30);
            this.empNComboBox.TabIndex = 52;
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.updateBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(544, 360);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(116, 44);
            this.updateBtn.TabIndex = 58;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // dltBtn
            // 
            this.dltBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.dltBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dltBtn.Location = new System.Drawing.Point(424, 360);
            this.dltBtn.Margin = new System.Windows.Forms.Padding(2);
            this.dltBtn.Name = "dltBtn";
            this.dltBtn.Size = new System.Drawing.Size(116, 44);
            this.dltBtn.TabIndex = 57;
            this.dltBtn.Text = "Delete";
            this.dltBtn.UseVisualStyleBackColor = false;
            this.dltBtn.Click += new System.EventHandler(this.dltBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.saveBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(664, 360);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(116, 44);
            this.saveBtn.TabIndex = 56;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // dataGridViewArea
            // 
            this.dataGridViewArea.AllowUserToAddRows = false;
            this.dataGridViewArea.AllowUserToDeleteRows = false;
            this.dataGridViewArea.AllowUserToResizeColumns = false;
            this.dataGridViewArea.AllowUserToResizeRows = false;
            this.dataGridViewArea.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewArea.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(93)))), ((int)(((byte)(115)))));
            this.dataGridViewArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArea.Location = new System.Drawing.Point(75, 406);
            this.dataGridViewArea.Name = "dataGridViewArea";
            this.dataGridViewArea.ReadOnly = true;
            this.dataGridViewArea.RowHeadersWidth = 51;
            this.dataGridViewArea.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewArea.RowTemplate.Height = 24;
            this.dataGridViewArea.Size = new System.Drawing.Size(848, 289);
            this.dataGridViewArea.TabIndex = 55;
            // 
            // inTimePicker
            // 
            this.inTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.inTimePicker.CustomFormat = "yyyy-MMM-dd HH : mm";
            this.inTimePicker.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inTimePicker.Location = new System.Drawing.Point(285, 210);
            this.inTimePicker.Name = "inTimePicker";
            this.inTimePicker.Size = new System.Drawing.Size(516, 27);
            this.inTimePicker.TabIndex = 53;
            this.inTimePicker.ValueChanged += new System.EventHandler(this.inTimePicker_ValueChanged);
            // 
            // outTimePicker
            // 
            this.outTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.outTimePicker.CustomFormat = "yyyy-MMM-dd HH : mm";
            this.outTimePicker.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.outTimePicker.Location = new System.Drawing.Point(285, 246);
            this.outTimePicker.Name = "outTimePicker";
            this.outTimePicker.Size = new System.Drawing.Size(516, 27);
            this.outTimePicker.TabIndex = 53;
            this.outTimePicker.ValueChanged += new System.EventHandler(this.outTimePicker_ValueChanged);
            // 
            // idTextBox
            // 
            this.idTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.idTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(285, 133);
            this.idTextBox.MaxLength = 12;
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(516, 29);
            this.idTextBox.TabIndex = 60;
            this.idTextBox.Text = "0";
            this.idTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ClrBtn
            // 
            this.ClrBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.ClrBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClrBtn.Location = new System.Drawing.Point(304, 360);
            this.ClrBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ClrBtn.Name = "ClrBtn";
            this.ClrBtn.Size = new System.Drawing.Size(116, 44);
            this.ClrBtn.TabIndex = 61;
            this.ClrBtn.Text = "Clear";
            this.ClrBtn.UseVisualStyleBackColor = false;
            this.ClrBtn.Click += new System.EventHandler(this.ClrBtn_Click);
            // 
            // workedHourseTextBox
            // 
            this.workedHourseTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.workedHourseTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workedHourseTextBox.Location = new System.Drawing.Point(285, 282);
            this.workedHourseTextBox.MaxLength = 3;
            this.workedHourseTextBox.Name = "workedHourseTextBox";
            this.workedHourseTextBox.ReadOnly = true;
            this.workedHourseTextBox.Size = new System.Drawing.Size(516, 29);
            this.workedHourseTextBox.TabIndex = 63;
            this.workedHourseTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(133, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 23);
            this.label3.TabIndex = 64;
            this.label3.Text = "Worked hours :";
            // 
            // findBtn
            // 
            this.findBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.findBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findBtn.Location = new System.Drawing.Point(816, 168);
            this.findBtn.Margin = new System.Windows.Forms.Padding(2);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(107, 38);
            this.findBtn.TabIndex = 65;
            this.findBtn.Text = "Find";
            this.findBtn.UseVisualStyleBackColor = false;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // dailyAtteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(221)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1032, 693);
            this.ControlBox = false;
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.workedHourseTextBox);
            this.Controls.Add(this.ClrBtn);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.dltBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.dataGridViewArea);
            this.Controls.Add(this.outTimePicker);
            this.Controls.Add(this.inTimePicker);
            this.Controls.Add(this.empNComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "dailyAtteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dailyAtteForm";
            this.Load += new System.EventHandler(this.dailyAtteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.ComboBox empNComboBox;
        internal System.Windows.Forms.Button updateBtn;
        internal System.Windows.Forms.Button dltBtn;
        internal System.Windows.Forms.Button saveBtn;
        internal System.Windows.Forms.DataGridView dataGridViewArea;
        internal System.Windows.Forms.DateTimePicker inTimePicker;
        internal System.Windows.Forms.DateTimePicker outTimePicker;
        internal System.Windows.Forms.TextBox idTextBox;
        internal System.Windows.Forms.Button ClrBtn;
        internal System.Windows.Forms.TextBox workedHourseTextBox;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Button findBtn;
    }
}