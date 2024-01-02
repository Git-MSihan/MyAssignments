namespace MyInterface
{
    partial class empLeaveMenuForm
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
            this.empLeaveMenuStrip = new System.Windows.Forms.MenuStrip();
            this.requestLeaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typesOfLeaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empLeaveMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadpanelArea
            // 
            this.LoadpanelArea.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoadpanelArea.Location = new System.Drawing.Point(0, 34);
            this.LoadpanelArea.Name = "LoadpanelArea";
            this.LoadpanelArea.Size = new System.Drawing.Size(1055, 740);
            this.LoadpanelArea.TabIndex = 4;
            // 
            // empLeaveMenuStrip
            // 
            this.empLeaveMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(93)))), ((int)(((byte)(115)))));
            this.empLeaveMenuStrip.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empLeaveMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.empLeaveMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.requestLeaveToolStripMenuItem,
            this.typesOfLeaveToolStripMenuItem,
            this.monthlyHToolStripMenuItem});
            this.empLeaveMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.empLeaveMenuStrip.Name = "empLeaveMenuStrip";
            this.empLeaveMenuStrip.Padding = new System.Windows.Forms.Padding(250, 2, 0, 2);
            this.empLeaveMenuStrip.Size = new System.Drawing.Size(1055, 31);
            this.empLeaveMenuStrip.TabIndex = 5;
            this.empLeaveMenuStrip.Text = "menuStrip1";
            // 
            // requestLeaveToolStripMenuItem
            // 
            this.requestLeaveToolStripMenuItem.Name = "requestLeaveToolStripMenuItem";
            this.requestLeaveToolStripMenuItem.Size = new System.Drawing.Size(151, 27);
            this.requestLeaveToolStripMenuItem.Text = "Request Leave";
            this.requestLeaveToolStripMenuItem.Click += new System.EventHandler(this.requestLeaveToolStripMenuItem_Click);
            // 
            // typesOfLeaveToolStripMenuItem
            // 
            this.typesOfLeaveToolStripMenuItem.Name = "typesOfLeaveToolStripMenuItem";
            this.typesOfLeaveToolStripMenuItem.Size = new System.Drawing.Size(154, 27);
            this.typesOfLeaveToolStripMenuItem.Text = "Types of Leave";
            this.typesOfLeaveToolStripMenuItem.Click += new System.EventHandler(this.typesOfLeaveToolStripMenuItem_Click);
            // 
            // monthlyHToolStripMenuItem
            // 
            this.monthlyHToolStripMenuItem.Name = "monthlyHToolStripMenuItem";
            this.monthlyHToolStripMenuItem.Size = new System.Drawing.Size(172, 27);
            this.monthlyHToolStripMenuItem.Text = "Monthly Holidays";
            this.monthlyHToolStripMenuItem.Click += new System.EventHandler(this.monthlyHToolStripMenuItem_Click);
            // 
            // empLeaveMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 773);
            this.ControlBox = false;
            this.Controls.Add(this.LoadpanelArea);
            this.Controls.Add(this.empLeaveMenuStrip);
            this.MainMenuStrip = this.empLeaveMenuStrip;
            this.Name = "empLeaveMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "empLeaveMenuForm";
            this.Load += new System.EventHandler(this.empLeaveMenuForm_Load);
            this.empLeaveMenuStrip.ResumeLayout(false);
            this.empLeaveMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LoadpanelArea;
        private System.Windows.Forms.MenuStrip empLeaveMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem requestLeaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typesOfLeaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyHToolStripMenuItem;
    }
}