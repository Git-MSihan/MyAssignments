namespace MyInterface
{
    partial class ConfigureForm
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
            this.dataGridViewArea = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.workinghoursTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.annualLeaveTextBox = new System.Windows.Forms.TextBox();
            this.taxRateTextBox = new System.Windows.Forms.TextBox();
            this.ClrBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.AdminIdMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArea)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewArea
            // 
            this.dataGridViewArea.AllowUserToAddRows = false;
            this.dataGridViewArea.AllowUserToDeleteRows = false;
            this.dataGridViewArea.AllowUserToResizeColumns = false;
            this.dataGridViewArea.AllowUserToResizeRows = false;
            this.dataGridViewArea.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewArea.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(93)))), ((int)(((byte)(115)))));
            this.dataGridViewArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArea.Location = new System.Drawing.Point(1, 448);
            this.dataGridViewArea.Name = "dataGridViewArea";
            this.dataGridViewArea.ReadOnly = true;
            this.dataGridViewArea.RowHeadersWidth = 51;
            this.dataGridViewArea.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewArea.RowTemplate.Height = 24;
            this.dataGridViewArea.Size = new System.Drawing.Size(1040, 244);
            this.dataGridViewArea.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(95)))), ((int)(((byte)(55)))));
            this.label3.Location = new System.Drawing.Point(360, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(370, 48);
            this.label3.TabIndex = 68;
            this.label3.Text = "Configure Details";
            // 
            // idTextBox
            // 
            this.idTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.idTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(277, 128);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(480, 29);
            this.idTextBox.TabIndex = 67;
            this.idTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(141, 129);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 23);
            this.label6.TabIndex = 66;
            this.label6.Text = "Configure id :";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.CustomFormat = "yyyy-MMM-dd";
            this.endDateTimePicker.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDateTimePicker.Location = new System.Drawing.Point(277, 239);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(480, 27);
            this.endDateTimePicker.TabIndex = 205;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.CustomFormat = "yyyy-MMM-dd";
            this.startDateTimePicker.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateTimePicker.Location = new System.Drawing.Point(277, 203);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(480, 27);
            this.startDateTimePicker.TabIndex = 205;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 168);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 23);
            this.label1.TabIndex = 66;
            this.label1.Text = "Daily Working Hours :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 23);
            this.label2.TabIndex = 66;
            this.label2.Text = "Annual Year Start Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 239);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 23);
            this.label4.TabIndex = 66;
            this.label4.Text = "Annual Year End Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(115, 277);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 23);
            this.label5.TabIndex = 66;
            this.label5.Text = "Annually Leves :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(168, 314);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 23);
            this.label7.TabIndex = 66;
            this.label7.Text = "Tax Rate :";
            // 
            // workinghoursTextBox
            // 
            this.workinghoursTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.workinghoursTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.workinghoursTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workinghoursTextBox.Location = new System.Drawing.Point(277, 165);
            this.workinghoursTextBox.Name = "workinghoursTextBox";
            this.workinghoursTextBox.Size = new System.Drawing.Size(480, 29);
            this.workinghoursTextBox.TabIndex = 208;
            this.workinghoursTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(171, 351);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 23);
            this.label9.TabIndex = 207;
            this.label9.Text = "Admin id :";
            // 
            // annualLeaveTextBox
            // 
            this.annualLeaveTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.annualLeaveTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.annualLeaveTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annualLeaveTextBox.Location = new System.Drawing.Point(277, 274);
            this.annualLeaveTextBox.Name = "annualLeaveTextBox";
            this.annualLeaveTextBox.Size = new System.Drawing.Size(480, 29);
            this.annualLeaveTextBox.TabIndex = 209;
            this.annualLeaveTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // taxRateTextBox
            // 
            this.taxRateTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.taxRateTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.taxRateTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxRateTextBox.Location = new System.Drawing.Point(277, 311);
            this.taxRateTextBox.MaxLength = 4;
            this.taxRateTextBox.Name = "taxRateTextBox";
            this.taxRateTextBox.Size = new System.Drawing.Size(480, 29);
            this.taxRateTextBox.TabIndex = 209;
            this.taxRateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.taxRateTextBox.MouseHover += new System.EventHandler(this.taxRateTextBox_MouseHover);
            // 
            // ClrBtn
            // 
            this.ClrBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.ClrBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClrBtn.Location = new System.Drawing.Point(248, 399);
            this.ClrBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ClrBtn.Name = "ClrBtn";
            this.ClrBtn.Size = new System.Drawing.Size(116, 44);
            this.ClrBtn.TabIndex = 213;
            this.ClrBtn.Text = "Clear";
            this.ClrBtn.UseVisualStyleBackColor = false;
            this.ClrBtn.Click += new System.EventHandler(this.ClrBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.updateBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(428, 399);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(116, 44);
            this.updateBtn.TabIndex = 212;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.saveBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(608, 399);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(116, 44);
            this.saveBtn.TabIndex = 210;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // AdminIdMaskedTextBox
            // 
            this.AdminIdMaskedTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.AdminIdMaskedTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminIdMaskedTextBox.Location = new System.Drawing.Point(277, 349);
            this.AdminIdMaskedTextBox.Name = "AdminIdMaskedTextBox";
            this.AdminIdMaskedTextBox.ReadOnly = true;
            this.AdminIdMaskedTextBox.Size = new System.Drawing.Size(480, 27);
            this.AdminIdMaskedTextBox.TabIndex = 214;
            this.AdminIdMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ConfigureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(221)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1032, 693);
            this.Controls.Add(this.AdminIdMaskedTextBox);
            this.Controls.Add(this.ClrBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.taxRateTextBox);
            this.Controls.Add(this.annualLeaveTextBox);
            this.Controls.Add(this.workinghoursTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewArea);
            this.Name = "ConfigureForm";
            this.Text = "ConfigureForm";
            this.Load += new System.EventHandler(this.ConfigureForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dataGridViewArea;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox idTextBox;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.DateTimePicker endDateTimePicker;
        internal System.Windows.Forms.DateTimePicker startDateTimePicker;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox workinghoursTextBox;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox annualLeaveTextBox;
        internal System.Windows.Forms.TextBox taxRateTextBox;
        internal System.Windows.Forms.Button ClrBtn;
        internal System.Windows.Forms.Button updateBtn;
        internal System.Windows.Forms.Button saveBtn;
        internal System.Windows.Forms.MaskedTextBox AdminIdMaskedTextBox;
    }
}