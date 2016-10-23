namespace AnalizadorDeTextos
{
    partial class Loader
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
            this.txtPerfiles = new System.Windows.Forms.TextBox();
            this.txtCompras = new System.Windows.Forms.TextBox();
            this.txtClientes = new System.Windows.Forms.TextBox();
            this.btnAPerfiles = new System.Windows.Forms.Button();
            this.btnACompras = new System.Windows.Forms.Button();
            this.btnAClientes = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.rbRecurrente = new System.Windows.Forms.RadioButton();
            this.rbSecuencial = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPerfiles
            // 
            this.txtPerfiles.Location = new System.Drawing.Point(12, 38);
            this.txtPerfiles.Name = "txtPerfiles";
            this.txtPerfiles.Size = new System.Drawing.Size(282, 20);
            this.txtPerfiles.TabIndex = 0;
            // 
            // txtCompras
            // 
            this.txtCompras.Location = new System.Drawing.Point(12, 81);
            this.txtCompras.Name = "txtCompras";
            this.txtCompras.Size = new System.Drawing.Size(282, 20);
            this.txtCompras.TabIndex = 1;
            // 
            // txtClientes
            // 
            this.txtClientes.Location = new System.Drawing.Point(13, 127);
            this.txtClientes.Name = "txtClientes";
            this.txtClientes.Size = new System.Drawing.Size(281, 20);
            this.txtClientes.TabIndex = 2;
            // 
            // btnAPerfiles
            // 
            this.btnAPerfiles.Location = new System.Drawing.Point(301, 38);
            this.btnAPerfiles.Name = "btnAPerfiles";
            this.btnAPerfiles.Size = new System.Drawing.Size(75, 23);
            this.btnAPerfiles.TabIndex = 3;
            this.btnAPerfiles.Text = "Abrir";
            this.btnAPerfiles.UseVisualStyleBackColor = true;
            this.btnAPerfiles.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnACompras
            // 
            this.btnACompras.Location = new System.Drawing.Point(301, 77);
            this.btnACompras.Name = "btnACompras";
            this.btnACompras.Size = new System.Drawing.Size(75, 23);
            this.btnACompras.TabIndex = 4;
            this.btnACompras.Text = "Abrir";
            this.btnACompras.UseVisualStyleBackColor = true;
            this.btnACompras.Click += new System.EventHandler(this.btnACompras_Click);
            // 
            // btnAClientes
            // 
            this.btnAClientes.Location = new System.Drawing.Point(301, 124);
            this.btnAClientes.Name = "btnAClientes";
            this.btnAClientes.Size = new System.Drawing.Size(75, 23);
            this.btnAClientes.TabIndex = 5;
            this.btnAClientes.Text = "Abrir";
            this.btnAClientes.UseVisualStyleBackColor = true;
            this.btnAClientes.Click += new System.EventHandler(this.btnAClientes_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(12, 213);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(364, 23);
            this.btnCargar.TabIndex = 6;
            this.btnCargar.Text = "Cargar Datos";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Archivo Perfiles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Archivo Compras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Archivo Clientes";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // rbRecurrente
            // 
            this.rbRecurrente.AutoSize = true;
            this.rbRecurrente.Location = new System.Drawing.Point(109, 25);
            this.rbRecurrente.Name = "rbRecurrente";
            this.rbRecurrente.Size = new System.Drawing.Size(78, 17);
            this.rbRecurrente.TabIndex = 10;
            this.rbRecurrente.TabStop = true;
            this.rbRecurrente.Text = "Recurrente";
            this.rbRecurrente.UseVisualStyleBackColor = true;
            // 
            // rbSecuencial
            // 
            this.rbSecuencial.AutoSize = true;
            this.rbSecuencial.Checked = true;
            this.rbSecuencial.Location = new System.Drawing.Point(6, 25);
            this.rbSecuencial.Name = "rbSecuencial";
            this.rbSecuencial.Size = new System.Drawing.Size(78, 17);
            this.rbSecuencial.TabIndex = 11;
            this.rbSecuencial.TabStop = true;
            this.rbSecuencial.Text = "Secuencial";
            this.rbSecuencial.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSecuencial);
            this.groupBox1.Controls.Add(this.rbRecurrente);
            this.groupBox1.Location = new System.Drawing.Point(12, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 54);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // Loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 257);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnAClientes);
            this.Controls.Add(this.btnACompras);
            this.Controls.Add(this.btnAPerfiles);
            this.Controls.Add(this.txtClientes);
            this.Controls.Add(this.txtCompras);
            this.Controls.Add(this.txtPerfiles);
            this.Name = "Loader";
            this.Text = "Loader";
            this.Load += new System.EventHandler(this.Loader_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPerfiles;
        private System.Windows.Forms.TextBox txtCompras;
        private System.Windows.Forms.TextBox txtClientes;
        private System.Windows.Forms.Button btnAPerfiles;
        private System.Windows.Forms.Button btnACompras;
        private System.Windows.Forms.Button btnAClientes;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.RadioButton rbRecurrente;
        private System.Windows.Forms.RadioButton rbSecuencial;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}