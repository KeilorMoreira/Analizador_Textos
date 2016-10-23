using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalizadorDeTextos
{
    public partial class Loader : Form
    {
        OpenFileDialog open;
        public static Secuencial objetoSecuencial = new Secuencial();
        public Loader()
        {
            InitializeComponent();
            open = new OpenFileDialog();
            open.Filter = "Archivos txt(*.txt)|*.txt";
            open.Title = "Cargar Archivos TXT";
            txtCompras.Text = "C:/Users/keilor/Documents/Semestre II 2016/Arqui/Proyecto/Compras.txt";
            txtPerfiles.Text = "C:/Users/keilor/Documents/Semestre II 2016/Arqui/Proyecto/Perfiles.txt";
            txtClientes.Text = "C:/Users/keilor/Documents/Semestre II 2016/Arqui/Proyecto/Clientes.txt";

        }

        private void btn_Click(object sender, EventArgs e)
        {
            if(open.ShowDialog() == DialogResult.OK)
            {
                txtPerfiles.Text = open.FileName;
            }
        }

        private void btnACompras_Click(object sender, EventArgs e)
        {
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtCompras.Text = open.FileName;
            }
        }

        private void btnAClientes_Click(object sender, EventArgs e)
        {
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtClientes.Text = open.FileName;
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

            if (txtPerfiles.Text != "" && txtCompras.Text != "" && txtClientes.Text != "")
            {
                
                // 
                if (rbSecuencial.Checked)
                {
                objetoSecuencial.cargarCliente(txtClientes.Text);
                objetoSecuencial.cargarCompras(txtCompras.Text);
                objetoSecuencial.cargarPerfiles(txtPerfiles.Text);
                
                /////////////////////////////////////////////////////////
                
                Hide();
                }
                else if (rbRecurrente.Checked)
                {
                    //
                }
                
            }
            else
            {
                MessageBox.Show("Todos los archivos deben ser cargados..!","Error de Carga de Datos",MessageBoxButtons.OK);
            }
        }

        private void Loader_Load(object sender, EventArgs e)
        {

        }
    }
}
