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
    public partial class CompradorRangoFechas : Form
    {
        public CompradorRangoFechas()
        {
            InitializeComponent();
        }

        private void CompradorRangoFechas_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            string inicio = Idia.Text+"/"+Imes+"/"+Ianno;
            int diaFinal = Int32.Parse(Fdia.Text);
            int mesFinal = Int32.Parse(Fmes.Text);
            int annoFinal = Int32.Parse(Fanno.Text);
            string cliente = Loader.objetoSecuencial.mayorCompra(inicio, diaFinal, mesFinal, annoFinal);
            Console.WriteLine("dfghjklgfddfghjklkjhgfdfghj"+cliente);
            
            tbxShower.Text = (string)cliente;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
