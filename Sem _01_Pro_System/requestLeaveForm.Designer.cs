namespace MyInterface
{
    partial class requestLeaveForm
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
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.reasonTextBox = new System.Windows.Forms.TextBox();
            this.noOfLeaveTextBox = new System.Windows.Forms.TextBox();
            this.lBeginDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.empNameComboBox = new System.Windows.Forms.ComboBox();
            this.typeOfLeaveComboBox = new System.Windows.Forms.ComboBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.dltBtn = new System.Windows.Forms.Button();
            this.dataGridViewArea = new System.Windows.Forms.DataGridView();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.ClrBtn = new System.Windows.Forms.Button();
            this.findBtn = new System.Windows.Forms.Button();
            this.ReqBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArea)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(95)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(339, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 48);
            this.label1.TabIndex = 19;
            this.label1.Text = "Leave Request Details";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(75, 112);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(169, 23);
            this.label14.TabIndex = 47;
            this.label14.Text = "Request Leave id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 23);
            this.label2.TabIndex = 47;
            this.label2.Text = "Emloyee Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 184);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 23);
            this.label3.TabIndex = 47;
            this.label3.Text = "Type of Leave :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 218);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 23);
            this.label4.TabIndex = 47;
            this.label4.Text = "Leave Begin date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(85, 250);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 23);
            this.label5.TabIndex = 47;
            this.label5.Text = "Leave End Date :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(129, 285);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 23);
            this.label6.TabIndex = 47;
            this.label6.Text = "No. of days :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(160, 320);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 23);
            this.label7.TabIndex = 47;
            this.label7.Text = "Reason :";
            // 
            // reasonTextBox
            // 
            this.reasonTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.reasonTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reasonTextBox.Location = new System.Drawing.Point(258, 318);
            this.reasonTextBox.Multiline = true;
            this.reasonTextBox.Name = "reasonTextBox";
            this.reasonTextBox.Size = new System.Drawing.Size(576, 57);
            this.reasonTextBox.TabIndex = 50;
            // 
            // noOfLeaveTextBox
            // 
            this.noOfLeaveTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.noOfLeaveTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.noOfLeaveTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noOfLeaveTextBox.Location = new System.Drawing.Point(258, 283);
            this.noOfLeaveTextBox.Name = "noOfLeaveTextBox";
            this.noOfLeaveTextBox.Size = new System.Drawing.Size(576, 29);
            this.noOfLeaveTextBox.TabIndex = 50;
            this.noOfLeaveTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lBeginDateTimePicker
            // 
            this.lBeginDateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lBeginDateTimePicker.CustomFormat = "yyyy-MMM-dd";
            this.lBeginDateTimePicker.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBeginDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.lBeginDateTimePicker.Location = new System.Drawing.Point(258, 217);
            this.lBeginDateTimePicker.Name = "lBeginDateTimePicker";
            this.lBeginDateTimePicker.Size = new System.Drawing.Size(576, 27);
            this.lBeginDateTimePicker.TabIndex = 51;
            // 
            // lEndDateTimePicker
            // 
            this.lEndDateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lEndDateTimePicker.CustomFormat = "yyyy-MMM-dd";
            this.lEndDateTimePicker.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.lEndDateTimePicker.Location = new System.Drawing.Point(258, 250);
            this.lEndDateTimePicker.Name = "lEndDateTimePicker";
            this.lEndDateTimePicker.Size = new System.Drawing.Size(576, 27);
            this.lEndDateTimePicker.TabIndex = 51;
            // 
            // empNameComboBox
            // 
            this.empNameComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.empNameComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.empNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empNameComboBox.FormattingEnabled = true;
            this.empNameComboBox.Location = new System.Drawing.Point(258, 149);
            this.empNameComboBox.Name = "empNameComboBox";
            this.empNameComboBox.Size = new System.Drawing.Size(576, 28);
            this.empNameComboBox.TabIndex = 52;
            // 
            // typeOfLeaveComboBox
            // 
            this.typeOfLeaveComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.typeOfLeaveComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.typeOfLeaveComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeOfLeaveComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeOfLeaveComboBox.FormattingEnabled = true;
            this.typeOfLeaveComboBox.Location = new System.Drawing.Point(258, 183);
            this.typeOfLeaveComboBox.Name = "typeOfLeaveComboBox";
            this.typeOfLeaveComboBox.Size = new System.Drawing.Size(576, 28);
            this.typeOfLeaveComboBox.TabIndex = 53;
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.updateBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(889, 575);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(116, 44);
            this.updateBtn.TabIndex = 57;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // dltBtn
            // 
            this.dltBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.dltBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dltBtn.Location = new System.Drawing.Point(889, 666);
            this.dltBtn.Margin = new System.Windows.Forms.Padding(2);
            this.dltBtn.Name = "dltBtn";
            this.dltBtn.Size = new System.Drawing.Size(116, 44);
            this.dltBtn.TabIndex = 56;
            this.dltBtn.Text = "Delete";
            this.dltBtn.UseVisualStyleBackColor = false;
            this.dltBtn.Click += new System.EventHandler(this.dltBtn_Click);
            // 
            // dataGridViewArea
            // 
            this.dataGridViewArea.AllowUserToAddRows = false;
            this.dataGridViewArea.AllowUserToDeleteRows = false;
            this.dataGridViewArea.AllowUserToResizeRows = false;
            this.dataGridViewArea.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewArea.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(93)))), ((int)(((byte)(115)))));
            this.dataGridViewArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArea.Location = new System.Drawing.Point(2, 411);
            this.dataGridViewArea.Name = "dataGridViewArea";
            this.dataGridViewArea.ReadOnly = true;
            this.dataGridViewArea.RowHeadersWidth = 51;
            this.dataGridViewArea.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewArea.RowTemplate.Height = 24;
            this.dataGridViewArea.Size = new System.Drawing.Size(875, 334);
            this.dataGridViewArea.TabIndex = 54;
            // 
            // idTextBox
            // 
            this.idTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(258, 112);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(576, 29);
            this.idTextBox.TabIndex = 71;
            this.idTextBox.Text = "0";
            this.idTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ClrBtn
            // 
            this.ClrBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.ClrBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClrBtn.Location = new System.Drawing.Point(889, 490);
            this.ClrBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ClrBtn.Name = "ClrBtn";
            this.ClrBtn.Size = new System.Drawing.Size(116, 44);
            this.ClrBtn.TabIndex = 73;
            this.ClrBtn.Text = "Clear";
            this.ClrBtn.UseVisualStyleBackColor = false;
            this.ClrBtn.Click += new System.EventHandler(this.ClrBtn_Click);
            // 
            // findBtn
            // 
            this.findBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.findBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findBtn.Location = new System.Drawing.Point(851, 146);
            this.findBtn.Margin = new System.Windows.Forms.Padding(2);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(116, 44);
            this.findBtn.TabIndex = 74;
            this.findBtn.Text = "Find";
            this.findBtn.UseVisualStyleBackColor = false;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // ReqBtn
            // 
            this.ReqBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.ReqBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReqBtn.Location = new System.Drawing.Point(889, 411);
            this.ReqBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ReqBtn.Name = "ReqBtn";
            this.ReqBtn.Size = new System.Drawing.Size(116, 44);
            this.ReqBtn.TabIndex = 75;
            this.ReqBtn.Text = "Request";
            this.ReqBtn.UseVisualStyleBackColor = false;
            this.ReqBtn.Click += new System.EventHandler(this.ReqBtn_Click);
            // 
            // requestLeaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(221)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1032, 748);
            this.Controls.Add(this.ReqBtn);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.ClrBtn);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.dltBtn);
            this.Controls.Add(this.dataGridViewArea);
            this.Controls.Add(this.typeOfLeaveComboBox);
            this.Controls.Add(this.empNameComboBox);
            this.Controls.Add(this.lEndDateTimePicker);
            this.Controls.Add(this.lBeginDateTimePicker);
            this.Controls.Add(this.noOfLeaveTextBox);
            this.Controls.Add(this.reasonTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.Name = "requestLeaveForm";
            this.Text = "requestLeaveForm";
            this.Load += new System.EventHandler(this.requestLeaveForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox reasonTextBox;
        internal System.Windows.Forms.TextBox noOfLeaveTextBox;
        internal System.Windows.Forms.DateTimePicker lBeginDateTimePicker;
        internal System.Windows.Forms.DateTimePicker lEndDateTimePicker;
        internal System.Windows.Forms.ComboBox empNameComboBox;
        internal System.Windows.Forms.ComboBox typeOfLeaveComboBox;
        internal System.Windows.Forms.Button updateBtn;
        internal System.Windows.Forms.Button dltBtn;
        internal System.Windows.Forms.DataGridView dataGridViewArea;
        internal System.Windows.Forms.TextBox idTextBox;
        internal System.Windows.Forms.Button ClrBtn;
        internal System.Windows.Forms.Button findBtn;
        internal System.Windows.Forms.Button ReqBtn;
    }
}