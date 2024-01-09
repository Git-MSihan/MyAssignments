namespace MyInterface
{
    partial class homeForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homeForm));
            this.EmpBtn = new System.Windows.Forms.Button();
            this.salBtn = new System.Windows.Forms.Button();
            this.empLeavBtn = new System.Windows.Forms.Button();
            this.setBtn = new System.Windows.Forms.Button();
            this.dailattBtn = new System.Windows.Forms.Button();
            this.DashbordLoadpanelArea = new System.Windows.Forms.Panel();
            this.loginGroupBox = new System.Windows.Forms.GroupBox();
            this.shopasCheckBox = new System.Windows.Forms.CheckBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Loginpagebtn = new System.Windows.Forms.Button();
            this.loginedAdminIdTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DashbordLoadpanelArea.SuspendLayout();
            this.loginGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmpBtn
            // 
            this.EmpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(191)))), ((int)(((byte)(145)))));
            this.EmpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmpBtn.Font = new System.Drawing.Font("Modern No. 20", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpBtn.Location = new System.Drawing.Point(3, 65);
            this.EmpBtn.Name = "EmpBtn";
            this.EmpBtn.Size = new System.Drawing.Size(339, 102);
            this.EmpBtn.TabIndex = 1;
            this.EmpBtn.Text = "Employee Component";
            this.EmpBtn.UseVisualStyleBackColor = false;
            this.EmpBtn.Click += new System.EventHandler(this.EmpBtn_Click);
            // 
            // salBtn
            // 
            this.salBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(191)))), ((int)(((byte)(145)))));
            this.salBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salBtn.Font = new System.Drawing.Font("Modern No. 20", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salBtn.Location = new System.Drawing.Point(3, 185);
            this.salBtn.Name = "salBtn";
            this.salBtn.Size = new System.Drawing.Size(339, 102);
            this.salBtn.TabIndex = 2;
            this.salBtn.Text = "Salary Component";
            this.salBtn.UseVisualStyleBackColor = false;
            this.salBtn.Click += new System.EventHandler(this.salBtn_Click);
            // 
            // empLeavBtn
            // 
            this.empLeavBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(191)))), ((int)(((byte)(145)))));
            this.empLeavBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.empLeavBtn.Font = new System.Drawing.Font("Modern No. 20", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empLeavBtn.Location = new System.Drawing.Point(1, 431);
            this.empLeavBtn.Name = "empLeavBtn";
            this.empLeavBtn.Size = new System.Drawing.Size(339, 102);
            this.empLeavBtn.TabIndex = 3;
            this.empLeavBtn.Text = "Employee Leaves Component";
            this.empLeavBtn.UseVisualStyleBackColor = false;
            this.empLeavBtn.Click += new System.EventHandler(this.empLeavBtn_Click);
            // 
            // setBtn
            // 
            this.setBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(191)))), ((int)(((byte)(145)))));
            this.setBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setBtn.Font = new System.Drawing.Font("Modern No. 20", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setBtn.Location = new System.Drawing.Point(1, 305);
            this.setBtn.Name = "setBtn";
            this.setBtn.Size = new System.Drawing.Size(339, 102);
            this.setBtn.TabIndex = 4;
            this.setBtn.Text = "Setting Component";
            this.setBtn.UseVisualStyleBackColor = false;
            this.setBtn.Click += new System.EventHandler(this.setBtn_Click);
            // 
            // dailattBtn
            // 
            this.dailattBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(191)))), ((int)(((byte)(145)))));
            this.dailattBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dailattBtn.Font = new System.Drawing.Font("Modern No. 20", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailattBtn.Location = new System.Drawing.Point(1, 552);
            this.dailattBtn.Name = "dailattBtn";
            this.dailattBtn.Size = new System.Drawing.Size(339, 102);
            this.dailattBtn.TabIndex = 3;
            this.dailattBtn.Text = "Daily Attendance Component";
            this.dailattBtn.UseVisualStyleBackColor = false;
            this.dailattBtn.Click += new System.EventHandler(this.dailattBtn_Click);
            // 
            // DashbordLoadpanelArea
            // 
            this.DashbordLoadpanelArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(221)))), ((int)(((byte)(242)))));
            this.DashbordLoadpanelArea.Controls.Add(this.loginGroupBox);
            this.DashbordLoadpanelArea.Controls.Add(this.groupBox1);
            this.DashbordLoadpanelArea.Controls.Add(this.label1);
            this.DashbordLoadpanelArea.Location = new System.Drawing.Point(346, 0);
            this.DashbordLoadpanelArea.Name = "DashbordLoadpanelArea";
            this.DashbordLoadpanelArea.Size = new System.Drawing.Size(1053, 772);
            this.DashbordLoadpanelArea.TabIndex = 6;
            // 
            // loginGroupBox
            // 
            this.loginGroupBox.Controls.Add(this.shopasCheckBox);
            this.loginGroupBox.Controls.Add(this.loginbtn);
            this.loginGroupBox.Controls.Add(this.passwordTextBox);
            this.loginGroupBox.Controls.Add(this.usernameTextBox);
            this.loginGroupBox.Controls.Add(this.label2);
            this.loginGroupBox.Controls.Add(this.Username);
            this.loginGroupBox.Location = new System.Drawing.Point(164, 199);
            this.loginGroupBox.Name = "loginGroupBox";
            this.loginGroupBox.Size = new System.Drawing.Size(704, 527);
            this.loginGroupBox.TabIndex = 15;
            this.loginGroupBox.TabStop = false;
            // 
            // shopasCheckBox
            // 
            this.shopasCheckBox.AutoSize = true;
            this.shopasCheckBox.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopasCheckBox.Location = new System.Drawing.Point(264, 209);
            this.shopasCheckBox.Name = "shopasCheckBox";
            this.shopasCheckBox.Size = new System.Drawing.Size(146, 27);
            this.shopasCheckBox.TabIndex = 20;
            this.shopasCheckBox.Text = "Show password";
            this.shopasCheckBox.UseCompatibleTextRendering = true;
            this.shopasCheckBox.UseVisualStyleBackColor = true;
            this.shopasCheckBox.CheckedChanged += new System.EventHandler(this.shopasCheckBox_CheckedChanged);
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.loginbtn.Font = new System.Drawing.Font("Bell MT", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.Location = new System.Drawing.Point(299, 271);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(185, 58);
            this.loginbtn.TabIndex = 19;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(257, 165);
            this.passwordTextBox.MaxLength = 8;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(352, 28);
            this.passwordTextBox.TabIndex = 16;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameTextBox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(257, 101);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(352, 28);
            this.usernameTextBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 28);
            this.label2.TabIndex = 17;
            this.label2.Text = "Password 🔑 :";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(82, 99);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(157, 28);
            this.Username.TabIndex = 18;
            this.Username.Text = "Username 👤 :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Location = new System.Drawing.Point(290, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 337);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(33)))), ((int)(((byte)(28)))));
            this.label1.Location = new System.Drawing.Point(234, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(595, 126);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grifindo Toys ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(95)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.Loginpagebtn);
            this.panel1.Controls.Add(this.loginedAdminIdTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dailattBtn);
            this.panel1.Controls.Add(this.empLeavBtn);
            this.panel1.Controls.Add(this.setBtn);
            this.panel1.Controls.Add(this.EmpBtn);
            this.panel1.Controls.Add(this.salBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 772);
            this.panel1.TabIndex = 7;
            // 
            // Loginpagebtn
            // 
            this.Loginpagebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(191)))), ((int)(((byte)(145)))));
            this.Loginpagebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Loginpagebtn.Font = new System.Drawing.Font("Modern No. 20", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginpagebtn.Location = new System.Drawing.Point(3, 7);
            this.Loginpagebtn.Name = "Loginpagebtn";
            this.Loginpagebtn.Size = new System.Drawing.Size(339, 48);
            this.Loginpagebtn.TabIndex = 17;
            this.Loginpagebtn.Text = "Login Page";
            this.Loginpagebtn.UseVisualStyleBackColor = false;
            this.Loginpagebtn.Click += new System.EventHandler(this.Loginpagebtn_Click);
            // 
            // loginedAdminIdTextBox
            // 
            this.loginedAdminIdTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginedAdminIdTextBox.Location = new System.Drawing.Point(34, 713);
            this.loginedAdminIdTextBox.Name = "loginedAdminIdTextBox";
            this.loginedAdminIdTextBox.ReadOnly = true;
            this.loginedAdminIdTextBox.Size = new System.Drawing.Size(295, 30);
            this.loginedAdminIdTextBox.TabIndex = 15;
            this.loginedAdminIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 671);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 30);
            this.label3.TabIndex = 16;
            this.label3.Text = "Logined Admin Id :";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // homeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 773);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DashbordLoadpanelArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "homeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBord";
            this.DashbordLoadpanelArea.ResumeLayout(false);
            this.DashbordLoadpanelArea.PerformLayout();
            this.loginGroupBox.ResumeLayout(false);
            this.loginGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button EmpBtn;
        internal System.Windows.Forms.Button salBtn;
        internal System.Windows.Forms.Button empLeavBtn;
        internal System.Windows.Forms.Button setBtn;
        internal System.Windows.Forms.Button dailattBtn;
        internal System.Windows.Forms.Panel DashbordLoadpanelArea;
        internal System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        internal System.Windows.Forms.TextBox loginedAdminIdTextBox;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Button Loginpagebtn;
        internal System.Windows.Forms.GroupBox loginGroupBox;
        internal System.Windows.Forms.CheckBox shopasCheckBox;
        internal System.Windows.Forms.Button loginbtn;
        internal System.Windows.Forms.TextBox passwordTextBox;
        internal System.Windows.Forms.TextBox usernameTextBox;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label Username;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

