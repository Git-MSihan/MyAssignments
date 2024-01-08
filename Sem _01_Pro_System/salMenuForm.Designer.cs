namespace MyInterface
{
    partial class salMenuForm
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
            this.salMenuStrip = new System.Windows.Forms.MenuStrip();
            this.salaryCalculationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salMenuStrip.SuspendLayout();
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
            // salMenuStrip
            // 
            this.salMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(93)))), ((int)(((byte)(115)))));
            this.salMenuStrip.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.salMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salaryCalculationToolStripMenuItem});
            this.salMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.salMenuStrip.Name = "salMenuStrip";
            this.salMenuStrip.Padding = new System.Windows.Forms.Padding(380, 2, 0, 2);
            this.salMenuStrip.Size = new System.Drawing.Size(1055, 31);
            this.salMenuStrip.TabIndex = 5;
            this.salMenuStrip.Text = "menuStrip1";
            // 
            // salaryCalculationToolStripMenuItem
            // 
            this.salaryCalculationToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.salaryCalculationToolStripMenuItem.Name = "salaryCalculationToolStripMenuItem";
            this.salaryCalculationToolStripMenuItem.Size = new System.Drawing.Size(138, 27);
            this.salaryCalculationToolStripMenuItem.Text = "Salary details";
            this.salaryCalculationToolStripMenuItem.Click += new System.EventHandler(this.salaryCalculationToolStripMenuItem_Click);
            // 
            // salMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 773);
            this.ControlBox = false;
            this.Controls.Add(this.LoadpanelArea);
            this.Controls.Add(this.salMenuStrip);
            this.MainMenuStrip = this.salMenuStrip;
            this.Name = "salMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "salMenuForm";
            this.Load += new System.EventHandler(this.salMenuForm_Load);
            this.salMenuStrip.ResumeLayout(false);
            this.salMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LoadpanelArea;
        private System.Windows.Forms.MenuStrip salMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem salaryCalculationToolStripMenuItem;
    }
}