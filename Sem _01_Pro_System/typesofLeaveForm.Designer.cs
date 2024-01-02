namespace MyInterface
{
    partial class typesofLeaveForm
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
            this.label14 = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.dltBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.dataGridViewArea = new System.Windows.Forms.DataGridView();
            this.leaveTypesTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.ClrBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArea)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(95)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(232, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 48);
            this.label1.TabIndex = 19;
            this.label1.Text = "Types of Leave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 232);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 23);
            this.label2.TabIndex = 60;
            this.label2.Text = "Leave types :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(18, 192);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(172, 23);
            this.label14.TabIndex = 61;
            this.label14.Text = "Types of Leave id :";
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.updateBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(194, 419);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(116, 44);
            this.updateBtn.TabIndex = 68;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // dltBtn
            // 
            this.dltBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.dltBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dltBtn.Location = new System.Drawing.Point(194, 356);
            this.dltBtn.Margin = new System.Windows.Forms.Padding(2);
            this.dltBtn.Name = "dltBtn";
            this.dltBtn.Size = new System.Drawing.Size(116, 44);
            this.dltBtn.TabIndex = 67;
            this.dltBtn.Text = "Delete";
            this.dltBtn.UseVisualStyleBackColor = false;
            this.dltBtn.Click += new System.EventHandler(this.dltBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.saveBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(383, 356);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(116, 44);
            this.saveBtn.TabIndex = 66;
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
            this.dataGridViewArea.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewArea.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(93)))), ((int)(((byte)(115)))));
            this.dataGridViewArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArea.Location = new System.Drawing.Point(612, 94);
            this.dataGridViewArea.Name = "dataGridViewArea";
            this.dataGridViewArea.ReadOnly = true;
            this.dataGridViewArea.RowHeadersWidth = 51;
            this.dataGridViewArea.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewArea.RowTemplate.Height = 24;
            this.dataGridViewArea.Size = new System.Drawing.Size(408, 546);
            this.dataGridViewArea.TabIndex = 65;
            // 
            // leaveTypesTextBox
            // 
            this.leaveTypesTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.leaveTypesTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaveTypesTextBox.Location = new System.Drawing.Point(201, 231);
            this.leaveTypesTextBox.Name = "leaveTypesTextBox";
            this.leaveTypesTextBox.Size = new System.Drawing.Size(347, 29);
            this.leaveTypesTextBox.TabIndex = 69;
            // 
            // idTextBox
            // 
            this.idTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(201, 191);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(347, 29);
            this.idTextBox.TabIndex = 70;
            this.idTextBox.Text = "0";
            this.idTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ClrBtn
            // 
            this.ClrBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.ClrBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClrBtn.Location = new System.Drawing.Point(383, 419);
            this.ClrBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ClrBtn.Name = "ClrBtn";
            this.ClrBtn.Size = new System.Drawing.Size(116, 44);
            this.ClrBtn.TabIndex = 71;
            this.ClrBtn.Text = "Clear";
            this.ClrBtn.UseVisualStyleBackColor = false;
            this.ClrBtn.Click += new System.EventHandler(this.ClrBtn_Click);
            // 
            // typesofLeaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(221)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1032, 693);
            this.Controls.Add(this.ClrBtn);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.leaveTypesTextBox);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.dltBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.dataGridViewArea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.Name = "typesofLeaveForm";
            this.Text = "typesofLeaveForm";
            this.Load += new System.EventHandler(this.typesofLeaveForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.Button updateBtn;
        internal System.Windows.Forms.Button dltBtn;
        internal System.Windows.Forms.Button saveBtn;
        internal System.Windows.Forms.DataGridView dataGridViewArea;
        internal System.Windows.Forms.TextBox leaveTypesTextBox;
        internal System.Windows.Forms.TextBox idTextBox;
        internal System.Windows.Forms.Button ClrBtn;
    }
}