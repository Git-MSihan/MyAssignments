namespace MyInterface
{
    partial class salaryForm
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
            this.updateBtn = new System.Windows.Forms.Button();
            this.ClrBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewArea = new System.Windows.Forms.DataGridView();
            this.saveBtn = new System.Windows.Forms.Button();
            this.NopayLeaveTextBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.totalLeaveTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.OThourseTextBox = new System.Windows.Forms.TextBox();
            this.totSalaryTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.findGroupBox = new System.Windows.Forms.GroupBox();
            this.findBtn = new System.Windows.Forms.Button();
            this.grossPayTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.noPayTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.basePayTextBox = new System.Windows.Forms.TextBox();
            this.PayBtn = new System.Windows.Forms.Button();
            this.payValueGroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.empNameComboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.SelectGroupBox = new System.Windows.Forms.GroupBox();
            this.issueDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dateRangeGroupBox = new System.Windows.Forms.GroupBox();
            this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BginDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.DateRangeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dltBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArea)).BeginInit();
            this.findGroupBox.SuspendLayout();
            this.payValueGroupBox.SuspendLayout();
            this.SelectGroupBox.SuspendLayout();
            this.dateRangeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.updateBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(921, 597);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(116, 44);
            this.updateBtn.TabIndex = 61;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // ClrBtn
            // 
            this.ClrBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.ClrBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClrBtn.Location = new System.Drawing.Point(921, 528);
            this.ClrBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ClrBtn.Name = "ClrBtn";
            this.ClrBtn.Size = new System.Drawing.Size(116, 44);
            this.ClrBtn.TabIndex = 64;
            this.ClrBtn.Text = "Clear";
            this.ClrBtn.UseVisualStyleBackColor = false;
            this.ClrBtn.Click += new System.EventHandler(this.ClrBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(659, 394);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 33;
            this.label2.Text = "Salary Id :";
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
            this.dataGridViewArea.Location = new System.Drawing.Point(4, 434);
            this.dataGridViewArea.Name = "dataGridViewArea";
            this.dataGridViewArea.ReadOnly = true;
            this.dataGridViewArea.RowHeadersWidth = 51;
            this.dataGridViewArea.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewArea.RowTemplate.Height = 24;
            this.dataGridViewArea.Size = new System.Drawing.Size(908, 294);
            this.dataGridViewArea.TabIndex = 58;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.saveBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(921, 457);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(116, 44);
            this.saveBtn.TabIndex = 59;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // NopayLeaveTextBox
            // 
            this.NopayLeaveTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.NopayLeaveTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NopayLeaveTextBox.Location = new System.Drawing.Point(770, 356);
            this.NopayLeaveTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NopayLeaveTextBox.Name = "NopayLeaveTextBox";
            this.NopayLeaveTextBox.ReadOnly = true;
            this.NopayLeaveTextBox.Size = new System.Drawing.Size(229, 29);
            this.NopayLeaveTextBox.TabIndex = 51;
            this.NopayLeaveTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(605, 358);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 23);
            this.label5.TabIndex = 38;
            this.label5.Text = "No pay Leaves  :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 189);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 23);
            this.label11.TabIndex = 44;
            this.label11.Text = "Tottal leave :";
            // 
            // totalLeaveTextBox
            // 
            this.totalLeaveTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.totalLeaveTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLeaveTextBox.Location = new System.Drawing.Point(47, 216);
            this.totalLeaveTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.totalLeaveTextBox.Name = "totalLeaveTextBox";
            this.totalLeaveTextBox.ReadOnly = true;
            this.totalLeaveTextBox.Size = new System.Drawing.Size(286, 29);
            this.totalLeaveTextBox.TabIndex = 50;
            this.totalLeaveTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 119);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 23);
            this.label8.TabIndex = 41;
            this.label8.Text = "O.T hours :";
            // 
            // OThourseTextBox
            // 
            this.OThourseTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.OThourseTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OThourseTextBox.Location = new System.Drawing.Point(47, 148);
            this.OThourseTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.OThourseTextBox.Name = "OThourseTextBox";
            this.OThourseTextBox.ReadOnly = true;
            this.OThourseTextBox.Size = new System.Drawing.Size(290, 29);
            this.OThourseTextBox.TabIndex = 56;
            this.OThourseTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // totSalaryTextBox
            // 
            this.totSalaryTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.totSalaryTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totSalaryTextBox.Location = new System.Drawing.Point(47, 80);
            this.totSalaryTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.totSalaryTextBox.Name = "totSalaryTextBox";
            this.totSalaryTextBox.ReadOnly = true;
            this.totSalaryTextBox.Size = new System.Drawing.Size(292, 29);
            this.totSalaryTextBox.TabIndex = 68;
            this.totSalaryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 48);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 23);
            this.label10.TabIndex = 69;
            this.label10.Text = "Tottal Salary :";
            // 
            // findGroupBox
            // 
            this.findGroupBox.Controls.Add(this.findBtn);
            this.findGroupBox.Controls.Add(this.label10);
            this.findGroupBox.Controls.Add(this.totSalaryTextBox);
            this.findGroupBox.Controls.Add(this.OThourseTextBox);
            this.findGroupBox.Controls.Add(this.label8);
            this.findGroupBox.Controls.Add(this.totalLeaveTextBox);
            this.findGroupBox.Controls.Add(this.label11);
            this.findGroupBox.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findGroupBox.Location = new System.Drawing.Point(4, 5);
            this.findGroupBox.Name = "findGroupBox";
            this.findGroupBox.Size = new System.Drawing.Size(354, 265);
            this.findGroupBox.TabIndex = 71;
            this.findGroupBox.TabStop = false;
            this.findGroupBox.Text = "Find";
            this.findGroupBox.Paint += new System.Windows.Forms.PaintEventHandler(this.findGroupBox_Paint);
            // 
            // findBtn
            // 
            this.findBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.findBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findBtn.Location = new System.Drawing.Point(228, 17);
            this.findBtn.Margin = new System.Windows.Forms.Padding(2);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(107, 38);
            this.findBtn.TabIndex = 66;
            this.findBtn.Text = "Find";
            this.findBtn.UseVisualStyleBackColor = false;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // grossPayTextBox
            // 
            this.grossPayTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.grossPayTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossPayTextBox.Location = new System.Drawing.Point(79, 216);
            this.grossPayTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.grossPayTextBox.Name = "grossPayTextBox";
            this.grossPayTextBox.ReadOnly = true;
            this.grossPayTextBox.Size = new System.Drawing.Size(281, 29);
            this.grossPayTextBox.TabIndex = 55;
            this.grossPayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 117);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 23);
            this.label7.TabIndex = 40;
            this.label7.Text = "No pay value:";
            // 
            // noPayTextBox
            // 
            this.noPayTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.noPayTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noPayTextBox.Location = new System.Drawing.Point(79, 148);
            this.noPayTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.noPayTextBox.Name = "noPayTextBox";
            this.noPayTextBox.ReadOnly = true;
            this.noPayTextBox.Size = new System.Drawing.Size(281, 29);
            this.noPayTextBox.TabIndex = 54;
            this.noPayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 48);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 23);
            this.label9.TabIndex = 42;
            this.label9.Text = "Base pay value :";
            // 
            // basePayTextBox
            // 
            this.basePayTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.basePayTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basePayTextBox.Location = new System.Drawing.Point(79, 80);
            this.basePayTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.basePayTextBox.Name = "basePayTextBox";
            this.basePayTextBox.ReadOnly = true;
            this.basePayTextBox.Size = new System.Drawing.Size(281, 29);
            this.basePayTextBox.TabIndex = 56;
            this.basePayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PayBtn
            // 
            this.PayBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.PayBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayBtn.Location = new System.Drawing.Point(256, 18);
            this.PayBtn.Margin = new System.Windows.Forms.Padding(2);
            this.PayBtn.Name = "PayBtn";
            this.PayBtn.Size = new System.Drawing.Size(107, 38);
            this.PayBtn.TabIndex = 74;
            this.PayBtn.Text = "Payments";
            this.PayBtn.UseVisualStyleBackColor = false;
            this.PayBtn.Click += new System.EventHandler(this.PayBtn_Click);
            // 
            // payValueGroupBox
            // 
            this.payValueGroupBox.Controls.Add(this.PayBtn);
            this.payValueGroupBox.Controls.Add(this.basePayTextBox);
            this.payValueGroupBox.Controls.Add(this.label9);
            this.payValueGroupBox.Controls.Add(this.noPayTextBox);
            this.payValueGroupBox.Controls.Add(this.label7);
            this.payValueGroupBox.Controls.Add(this.grossPayTextBox);
            this.payValueGroupBox.Controls.Add(this.label6);
            this.payValueGroupBox.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payValueGroupBox.Location = new System.Drawing.Point(661, 12);
            this.payValueGroupBox.Name = "payValueGroupBox";
            this.payValueGroupBox.Size = new System.Drawing.Size(377, 265);
            this.payValueGroupBox.TabIndex = 72;
            this.payValueGroupBox.TabStop = false;
            this.payValueGroupBox.Text = "Payment Values";
            this.payValueGroupBox.Paint += new System.Windows.Forms.PaintEventHandler(this.payValueGroupBox_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 185);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 23);
            this.label6.TabIndex = 39;
            this.label6.Text = "Gross pay value :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(587, 322);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 23);
            this.label3.TabIndex = 36;
            this.label3.Text = "Salary Issue Date :";
            // 
            // idTextBox
            // 
            this.idTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(770, 393);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(230, 29);
            this.idTextBox.TabIndex = 73;
            this.idTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // empNameComboBox
            // 
            this.empNameComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.empNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empNameComboBox.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empNameComboBox.FormattingEnabled = true;
            this.empNameComboBox.Location = new System.Drawing.Point(52, 64);
            this.empNameComboBox.Name = "empNameComboBox";
            this.empNameComboBox.Size = new System.Drawing.Size(333, 30);
            this.empNameComboBox.TabIndex = 76;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(84, 33);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(159, 23);
            this.label13.TabIndex = 75;
            this.label13.Text = "Employee Name :";
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.searchBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(272, 23);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(107, 38);
            this.searchBtn.TabIndex = 77;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // SelectGroupBox
            // 
            this.SelectGroupBox.Controls.Add(this.searchBtn);
            this.SelectGroupBox.Controls.Add(this.label13);
            this.SelectGroupBox.Controls.Add(this.empNameComboBox);
            this.SelectGroupBox.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectGroupBox.Location = new System.Drawing.Point(10, 306);
            this.SelectGroupBox.Name = "SelectGroupBox";
            this.SelectGroupBox.Size = new System.Drawing.Size(441, 105);
            this.SelectGroupBox.TabIndex = 75;
            this.SelectGroupBox.TabStop = false;
            this.SelectGroupBox.Text = "Select / Search";
            this.SelectGroupBox.Paint += new System.Windows.Forms.PaintEventHandler(this.SelectGroupBox_Paint);
            // 
            // issueDateTimePicker
            // 
            this.issueDateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.issueDateTimePicker.CustomFormat = "yyyy-MMM-dd";
            this.issueDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.issueDateTimePicker.Location = new System.Drawing.Point(770, 322);
            this.issueDateTimePicker.Name = "issueDateTimePicker";
            this.issueDateTimePicker.Size = new System.Drawing.Size(230, 27);
            this.issueDateTimePicker.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(95)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(403, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 56);
            this.label1.TabIndex = 177;
            this.label1.Text = "Salary Details";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(10, 36);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 23);
            this.label14.TabIndex = 73;
            this.label14.Text = "Begin Date :";
            // 
            // dateRangeGroupBox
            // 
            this.dateRangeGroupBox.Controls.Add(this.EndDateTimePicker);
            this.dateRangeGroupBox.Controls.Add(this.BginDateTimePicker);
            this.dateRangeGroupBox.Controls.Add(this.label15);
            this.dateRangeGroupBox.Controls.Add(this.label14);
            this.dateRangeGroupBox.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateRangeGroupBox.Location = new System.Drawing.Point(369, 92);
            this.dateRangeGroupBox.Name = "dateRangeGroupBox";
            this.dateRangeGroupBox.Size = new System.Drawing.Size(286, 178);
            this.dateRangeGroupBox.TabIndex = 70;
            this.dateRangeGroupBox.TabStop = false;
            this.dateRangeGroupBox.Text = "DATE RANGE";
            this.dateRangeGroupBox.Paint += new System.Windows.Forms.PaintEventHandler(this.dateRangeGroupBox_Paint);
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.EndDateTimePicker.CustomFormat = "yyyy-MMM-dd";
            this.EndDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndDateTimePicker.Location = new System.Drawing.Point(14, 138);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(253, 27);
            this.EndDateTimePicker.TabIndex = 180;
            // 
            // BginDateTimePicker
            // 
            this.BginDateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BginDateTimePicker.CustomFormat = "yyyy-MMM-dd";
            this.BginDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BginDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BginDateTimePicker.Location = new System.Drawing.Point(13, 68);
            this.BginDateTimePicker.Name = "BginDateTimePicker";
            this.BginDateTimePicker.Size = new System.Drawing.Size(254, 27);
            this.BginDateTimePicker.TabIndex = 179;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(10, 107);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 23);
            this.label15.TabIndex = 74;
            this.label15.Text = "End Date :";
            // 
            // DateRangeTextBox
            // 
            this.DateRangeTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.DateRangeTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateRangeTextBox.Location = new System.Drawing.Point(770, 286);
            this.DateRangeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DateRangeTextBox.Name = "DateRangeTextBox";
            this.DateRangeTextBox.ReadOnly = true;
            this.DateRangeTextBox.Size = new System.Drawing.Size(230, 29);
            this.DateRangeTextBox.TabIndex = 178;
            this.DateRangeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(593, 289);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 23);
            this.label4.TabIndex = 70;
            this.label4.Text = "Work date range :";
            // 
            // dltBtn
            // 
            this.dltBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.dltBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dltBtn.Location = new System.Drawing.Point(921, 665);
            this.dltBtn.Margin = new System.Windows.Forms.Padding(2);
            this.dltBtn.Name = "dltBtn";
            this.dltBtn.Size = new System.Drawing.Size(116, 44);
            this.dltBtn.TabIndex = 60;
            this.dltBtn.Text = "Delete";
            this.dltBtn.UseVisualStyleBackColor = false;
            this.dltBtn.Click += new System.EventHandler(this.dltBtn_Click);
            // 
            // salaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(221)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1037, 693);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DateRangeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectGroupBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.dateRangeGroupBox);
            this.Controls.Add(this.payValueGroupBox);
            this.Controls.Add(this.issueDateTimePicker);
            this.Controls.Add(this.findGroupBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NopayLeaveTextBox);
            this.Controls.Add(this.ClrBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.dltBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.dataGridViewArea);
            this.Controls.Add(this.label2);
            this.Name = "salaryForm";
            this.Load += new System.EventHandler(this.salaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArea)).EndInit();
            this.findGroupBox.ResumeLayout(false);
            this.findGroupBox.PerformLayout();
            this.payValueGroupBox.ResumeLayout(false);
            this.payValueGroupBox.PerformLayout();
            this.SelectGroupBox.ResumeLayout(false);
            this.SelectGroupBox.PerformLayout();
            this.dateRangeGroupBox.ResumeLayout(false);
            this.dateRangeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button updateBtn;
        internal System.Windows.Forms.Button ClrBtn;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.DataGridView dataGridViewArea;
        internal System.Windows.Forms.Button saveBtn;
        internal System.Windows.Forms.TextBox NopayLeaveTextBox;
        internal System.ComponentModel.BackgroundWorker backgroundWorker1;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.TextBox totalLeaveTextBox;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox OThourseTextBox;
        internal System.Windows.Forms.TextBox totSalaryTextBox;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.GroupBox findGroupBox;
        internal System.Windows.Forms.Button findBtn;
        internal System.Windows.Forms.TextBox grossPayTextBox;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox noPayTextBox;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox basePayTextBox;
        internal System.Windows.Forms.Button PayBtn;
        internal System.Windows.Forms.GroupBox payValueGroupBox;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox idTextBox;
        internal System.Windows.Forms.ComboBox empNameComboBox;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Button searchBtn;
        internal System.Windows.Forms.GroupBox SelectGroupBox;
        internal System.Windows.Forms.DateTimePicker issueDateTimePicker;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.GroupBox dateRangeGroupBox;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.TextBox DateRangeTextBox;
        internal System.Windows.Forms.DateTimePicker EndDateTimePicker;
        internal System.Windows.Forms.DateTimePicker BginDateTimePicker;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button dltBtn;
    }
}