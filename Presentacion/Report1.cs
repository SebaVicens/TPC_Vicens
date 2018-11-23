using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Presentacion
{
    public partial class Report1 : Form
    {
        public Report1(int dato)
        {
            InitializeComponent();
            this.dato = dato;
        }

        int dato;

        private void Report1_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            Factura3 rep = new Factura3();
            rep.SetParameterValue("@IDVENTA", dato);
            crystalReportViewer1.ReportSource = rep;
        }
    }
}
