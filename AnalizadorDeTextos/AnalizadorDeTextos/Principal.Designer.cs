﻿namespace AnalizadorDeTextos
{
    partial class Principal
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.CargarTXT = new System.Windows.Forms.ToolStripMenuItem();
            this.usoCPU = new System.Windows.Forms.ToolStripMenuItem();
            this.masCompradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CargarTXT,
            this.usoCPU,
            this.masCompradorToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(968, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip2";
            // 
            // CargarTXT
            // 
            this.CargarTXT.Name = "CargarTXT";
            this.CargarTXT.Size = new System.Drawing.Size(75, 20);
            this.CargarTXT.Text = "LoadDatos";
            this.CargarTXT.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // usoCPU
            // 
            this.usoCPU.Name = "usoCPU";
            this.usoCPU.Size = new System.Drawing.Size(61, 20);
            this.usoCPU.Text = "usoCPU";
            this.usoCPU.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // masCompradorToolStripMenuItem
            // 
            this.masCompradorToolStripMenuItem.Name = "masCompradorToolStripMenuItem";
            this.masCompradorToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.masCompradorToolStripMenuItem.Text = "MasComprador";
            this.masCompradorToolStripMenuItem.Click += new System.EventHandler(this.masCompradorToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.ClientSize = new System.Drawing.Size(968, 180);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cargarArchivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usoCPUToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cbTipo;
        private System.Windows.Forms.CheckBox cbCPU;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem usoCPU;
        private System.Windows.Forms.ToolStripMenuItem CargarTXT;
        private System.Windows.Forms.ToolStripMenuItem masCompradorToolStripMenuItem;
    }
}