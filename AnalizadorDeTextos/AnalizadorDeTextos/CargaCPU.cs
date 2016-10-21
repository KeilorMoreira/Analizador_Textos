using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace AnalizadorDeTextos
{
    public partial class CargaCPU : Form
    {
        // Globales
        int x = 0;
        public CargaCPU()
        {
            InitializeComponent();
            cargaCPU();
            chGrafico.Legends.Clear();
            chGrafico.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Range;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void cbAct3D_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAct3D.Checked)
            {
                chGrafico.ChartAreas[0].Area3DStyle.Enable3D = true;
            }
            else
            {
                chGrafico.ChartAreas[0].Area3DStyle.Enable3D = false;
            }
        }
        PerformanceCounter cpuCounter = new PerformanceCounter();
        private void cargaCPU()
        {
            
            cpuCounter.CategoryName = "Processor";
            cpuCounter.CounterName = "% Processor Time";
            cpuCounter.InstanceName = "_Total";
        }
        

        private void timer_Tick(object sender, EventArgs e)
        {

            if (chGrafico.Series[0].Points.Count > 7)
            {
                chGrafico.Series[0].Points.RemoveAt(0);
                chGrafico.Update();
            }
            chGrafico.Series[0].Points.AddXY(x++, cpuCounter.NextValue());
            Thread.Sleep(1000);

        }
    }
}
