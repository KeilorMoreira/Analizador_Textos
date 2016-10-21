﻿namespace AnalizadorDeTextos
{
    partial class CargaCPU
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbAct3D = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chGrafico)).BeginInit();
            this.SuspendLayout();
            // 
            // chGrafico
            // 
            this.chGrafico.BackColor = System.Drawing.Color.Gray;
            this.chGrafico.BorderSkin.BackColor = System.Drawing.Color.Black;
            this.chGrafico.BorderSkin.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Percent60;
            this.chGrafico.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.FrameThin4;
            chartArea1.Name = "ChartArea1";
            this.chGrafico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chGrafico.Legends.Add(legend1);
            this.chGrafico.Location = new System.Drawing.Point(0, 0);
            this.chGrafico.Name = "chGrafico";
            this.chGrafico.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chGrafico.Series.Add(series1);
            this.chGrafico.Size = new System.Drawing.Size(724, 404);
            this.chGrafico.TabIndex = 0;
            this.chGrafico.Text = "CargaProcesador";
            this.chGrafico.Click += new System.EventHandler(this.chart1_Click);
            // 
            // cbAct3D
            // 
            this.cbAct3D.AutoSize = true;
            this.cbAct3D.BackColor = System.Drawing.Color.Transparent;
            this.cbAct3D.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.cbAct3D.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAct3D.ForeColor = System.Drawing.Color.DarkMagenta;
            this.cbAct3D.Location = new System.Drawing.Point(28, 21);
            this.cbAct3D.Name = "cbAct3D";
            this.cbAct3D.Size = new System.Drawing.Size(42, 17);
            this.cbAct3D.TabIndex = 1;
            this.cbAct3D.Text = "3D";
            this.cbAct3D.UseVisualStyleBackColor = false;
            this.cbAct3D.CheckedChanged += new System.EventHandler(this.cbAct3D_CheckedChanged);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 399);
            this.Controls.Add(this.cbAct3D);
            this.Controls.Add(this.chGrafico);
            this.Name = "Form1";
            this.Text = "Carga de Procesamiento";
            ((System.ComponentModel.ISupportInitialize)(this.chGrafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chGrafico;
        private System.Windows.Forms.CheckBox cbAct3D;
        private System.Windows.Forms.Timer timer;
    }
}
