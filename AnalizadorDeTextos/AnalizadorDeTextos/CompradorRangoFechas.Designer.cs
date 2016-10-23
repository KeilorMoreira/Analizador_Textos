namespace AnalizadorDeTextos
{
    partial class CompradorRangoFechas
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
            this.Fdia = new System.Windows.Forms.ComboBox();
            this.Fmes = new System.Windows.Forms.ComboBox();
            this.Fanno = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Idia = new System.Windows.Forms.ComboBox();
            this.Ianno = new System.Windows.Forms.ComboBox();
            this.Imes = new System.Windows.Forms.ComboBox();
            this.tbxShower = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Fdia
            // 
            this.Fdia.FormattingEnabled = true;
            this.Fdia.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.Fdia.Location = new System.Drawing.Point(220, 22);
            this.Fdia.Name = "Fdia";
            this.Fdia.Size = new System.Drawing.Size(121, 21);
            this.Fdia.TabIndex = 0;
            // 
            // Fmes
            // 
            this.Fmes.FormattingEnabled = true;
            this.Fmes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.Fmes.Location = new System.Drawing.Point(220, 49);
            this.Fmes.Name = "Fmes";
            this.Fmes.Size = new System.Drawing.Size(121, 21);
            this.Fmes.TabIndex = 1;
            // 
            // Fanno
            // 
            this.Fanno.FormattingEnabled = true;
            this.Fanno.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.Fanno.Location = new System.Drawing.Point(220, 76);
            this.Fanno.Name = "Fanno";
            this.Fanno.Size = new System.Drawing.Size(121, 21);
            this.Fanno.TabIndex = 2;
            this.Fanno.Text = "2016";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxShower);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Idia);
            this.groupBox1.Controls.Add(this.Ianno);
            this.groupBox1.Controls.Add(this.Fdia);
            this.groupBox1.Controls.Add(this.Imes);
            this.groupBox1.Controls.Add(this.Fanno);
            this.groupBox1.Controls.Add(this.Fmes);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 295);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rango de Fechas";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "A";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(150, 118);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Año";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dia";
            // 
            // Idia
            // 
            this.Idia.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.Idia.Location = new System.Drawing.Point(39, 22);
            this.Idia.Name = "Idia";
            this.Idia.Size = new System.Drawing.Size(121, 21);
            this.Idia.TabIndex = 0;
            // 
            // Ianno
            // 
            this.Ianno.FormattingEnabled = true;
            this.Ianno.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.Ianno.Location = new System.Drawing.Point(39, 76);
            this.Ianno.Name = "Ianno";
            this.Ianno.Size = new System.Drawing.Size(121, 21);
            this.Ianno.TabIndex = 2;
            this.Ianno.Text = "2016";
            // 
            // Imes
            // 
            this.Imes.FormattingEnabled = true;
            this.Imes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.Imes.Location = new System.Drawing.Point(39, 49);
            this.Imes.Name = "Imes";
            this.Imes.Size = new System.Drawing.Size(121, 21);
            this.Imes.TabIndex = 1;
            // 
            // tbxShower
            // 
            this.tbxShower.Location = new System.Drawing.Point(13, 167);
            this.tbxShower.Multiline = true;
            this.tbxShower.Name = "tbxShower";
            this.tbxShower.Size = new System.Drawing.Size(328, 116);
            this.tbxShower.TabIndex = 7;
            // 
            // CompradorRangoFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 295);
            this.Controls.Add(this.groupBox1);
            this.Name = "CompradorRangoFechas";
            this.Text = "CompradorRangoFechas";
            this.Load += new System.EventHandler(this.CompradorRangoFechas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Fdia;
        private System.Windows.Forms.ComboBox Fmes;
        private System.Windows.Forms.ComboBox Fanno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Idia;
        private System.Windows.Forms.ComboBox Ianno;
        private System.Windows.Forms.ComboBox Imes;
        private System.Windows.Forms.TextBox tbxShower;
    }
}