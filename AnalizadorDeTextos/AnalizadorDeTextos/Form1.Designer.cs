namespace AnalizadorDeTextos
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbAct3D = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chGrafico)).BeginInit();
            this.SuspendLayout();
            // 
            // chGrafico
            // 
            chartArea4.Name = "ChartArea1";
            this.chGrafico.ChartAreas.Add(chartArea4);
            this.chGrafico.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chGrafico.Legends.Add(legend4);
            this.chGrafico.Location = new System.Drawing.Point(0, 0);
            this.chGrafico.Name = "chGrafico";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chGrafico.Series.Add(series4);
            this.chGrafico.Size = new System.Drawing.Size(719, 399);
            this.chGrafico.TabIndex = 0;
            this.chGrafico.Text = "CargaProcesador";
            this.chGrafico.Click += new System.EventHandler(this.chart1_Click);
            // 
            // cbAct3D
            // 
            this.cbAct3D.AutoSize = true;
            this.cbAct3D.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbAct3D.Location = new System.Drawing.Point(0, 0);
            this.cbAct3D.Name = "cbAct3D";
            this.cbAct3D.Size = new System.Drawing.Size(719, 17);
            this.cbAct3D.TabIndex = 1;
            this.cbAct3D.Text = "Modo 3D";
            this.cbAct3D.UseVisualStyleBackColor = true;
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

