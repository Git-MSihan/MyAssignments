namespace MyInterface
{
    partial class EmpMenuForm
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
            this.EmpMenuStrip = new System.Windows.Forms.MenuStrip();
            this.emloyeeDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emloyeeTypesDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmpMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadpanelArea
            // 
            this.LoadpanelArea.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoadpanelArea.Location = new System.Drawing.Point(0, 34);
            this.LoadpanelArea.Name = "LoadpanelArea";
            this.LoadpanelArea.Size = new System.Drawing.Size(1055, 740);
            this.LoadpanelArea.TabIndex = 3;
            // 
            // EmpMenuStrip
            // 
            this.EmpMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(93)))), ((int)(((byte)(115)))));
            this.EmpMenuStrip.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpMenuStrip.GripMargin = new System.Windows.Forms.Padding(2);
            this.EmpMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.EmpMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emloyeeDetailsToolStripMenuItem,
            this.emloyeeTypesDetailsToolStripMenuItem});
            this.EmpMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.EmpMenuStrip.Name = "EmpMenuStrip";
            this.EmpMenuStrip.Padding = new System.Windows.Forms.Padding(300, 2, 0, 2);
            this.EmpMenuStrip.Size = new System.Drawing.Size(1055, 31);
            this.EmpMenuStrip.TabIndex = 2;
            this.EmpMenuStrip.Text = "menu";
            // 
            // emloyeeDetailsToolStripMenuItem
            // 
            this.emloyeeDetailsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.emloyeeDetailsToolStripMenuItem.Name = "emloyeeDetailsToolStripMenuItem";
            this.emloyeeDetailsToolStripMenuItem.Size = new System.Drawing.Size(161, 27);
            this.emloyeeDetailsToolStripMenuItem.Text = "Emloyee Details";
            this.emloyeeDetailsToolStripMenuItem.Click += new System.EventHandler(this.emloyeeDetailsToolStripMenuItem_Click);
            // 
            // emloyeeTypesDetailsToolStripMenuItem
            // 
            this.emloyeeTypesDetailsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.emloyeeTypesDetailsToolStripMenuItem.Name = "emloyeeTypesDetailsToolStripMenuItem";
            this.emloyeeTypesDetailsToolStripMenuItem.Size = new System.Drawing.Size(216, 27);
            this.emloyeeTypesDetailsToolStripMenuItem.Text = "Emloyee Types Details";
            this.emloyeeTypesDetailsToolStripMenuItem.Click += new System.EventHandler(this.emloyeeTypesDetailsToolStripMenuItem_Click);
            // 
            // EmpMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1055, 773);
            this.ControlBox = false;
            this.Controls.Add(this.LoadpanelArea);
            this.Controls.Add(this.EmpMenuStrip);
            this.Name = "EmpMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmpMenuForm";
            this.Load += new System.EventHandler(this.EmpMenuForm_Load);
            this.EmpMenuStrip.ResumeLayout(false);
            this.EmpMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LoadpanelArea;
        private System.Windows.Forms.MenuStrip EmpMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem emloyeeDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emloyeeTypesDetailsToolStripMenuItem;
    }
}