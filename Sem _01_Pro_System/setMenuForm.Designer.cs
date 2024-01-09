namespace MyInterface
{
    partial class setMenuForm
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
            this.LoadpanelArea = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.workDaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadpanelArea
            // 
            this.LoadpanelArea.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoadpanelArea.Location = new System.Drawing.Point(0, 34);
            this.LoadpanelArea.Name = "LoadpanelArea";
            this.LoadpanelArea.Size = new System.Drawing.Size(1055, 740);
            this.LoadpanelArea.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(93)))), ((int)(((byte)(115)))));
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workDaysToolStripMenuItem,
            this.adminDetailsToolStripMenuItem,
            this.configureDetailsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(300, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1055, 31);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "setMenuStrip";
            // 
            // workDaysToolStripMenuItem
            // 
            this.workDaysToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.workDaysToolStripMenuItem.Name = "workDaysToolStripMenuItem";
            this.workDaysToolStripMenuItem.Size = new System.Drawing.Size(118, 27);
            this.workDaysToolStripMenuItem.Text = "Work Days";
            this.workDaysToolStripMenuItem.Click += new System.EventHandler(this.workDaysToolStripMenuItem_Click);
            // 
            // adminDetailsToolStripMenuItem
            // 
            this.adminDetailsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.adminDetailsToolStripMenuItem.Name = "adminDetailsToolStripMenuItem";
            this.adminDetailsToolStripMenuItem.Size = new System.Drawing.Size(136, 27);
            this.adminDetailsToolStripMenuItem.Text = "Login Details";
            this.adminDetailsToolStripMenuItem.Click += new System.EventHandler(this.adminDetailsToolStripMenuItem_Click);
            // 
            // configureDetailsToolStripMenuItem
            // 
            this.configureDetailsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.configureDetailsToolStripMenuItem.Name = "configureDetailsToolStripMenuItem";
            this.configureDetailsToolStripMenuItem.Size = new System.Drawing.Size(172, 27);
            this.configureDetailsToolStripMenuItem.Text = "Configure Details";
            this.configureDetailsToolStripMenuItem.Click += new System.EventHandler(this.configureDetailsToolStripMenuItem_Click);
            // 
            // setMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 773);
            this.ControlBox = false;
            this.Controls.Add(this.LoadpanelArea);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "setMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "setMenuForm";
            this.Load += new System.EventHandler(this.setMenuForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LoadpanelArea;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem workDaysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureDetailsToolStripMenuItem;
    }
}