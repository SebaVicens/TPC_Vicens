using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dominio;
using Negocio;
using Excel = Microsoft.Office.Interop.Excel;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Presentacion
{
    public partial class Reportess : Form
    {
        public Reportess()
        {
            InitializeComponent();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (DgvFacturacion.RowCount > 0)
            {
                if (DgvFacturacion.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione el Reporte a Exportar");
                }

                else
                {
                    ExportarExcel(DgvFacturacion);
                }
            }
            else
            {
                MessageBox.Show("No posee Reporte para exportar");
            }
        }

        private void ExportarExcel(DataGridView grd)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo =
                    (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                //Recorremos el DataGridView rellenando la hoja de trabajo
                for (int i = 0; i < grd.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < grd.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i + 1, j + 1] = grd.Rows[i].Cells[j].Value.ToString();
                    }
                }
                libros_trabajo.SaveAs(fichero.FileName,
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }

        private void btnReporte1_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtApellido.Text = "";
            dtpFechaFinal.Text = "";
            dtpFechaInicial.Text = "";
            VentasNegocio v = new VentasNegocio();
            //DgvFacturacion.DataSource = v.listarVentas();
            //DgvFacturacion.Columns["Descripcion"].Visible = false;
            //DgvFacturacion.Columns["Cantidad"].Visible = false;
            //DgvFacturacion.Columns["Ventadet"].Visible = false;
            DgvFacturacion.DataSource = BD.Ejecutar("SELECT VE.IDVENTA AS FACTURA,VE.FECHA, CL.APELLIDO+' '+ CL.NOMBRE AS CLIENTE,US.APELLIDO+' '+ US.NOMBRE  AS VENDEDOR, SUM(AXV.PU*AXV.CANTIDAD) AS TOTAL_FACTURA FROM VENTAS AS VE INNER JOIN CLIENTES AS CL ON VE.IDCLIENTE = CL.IDCLIENTE INNER JOIN USUARIOS AS US ON VE.IDUSUARIO = US.IDUSUARIO INNER JOIN ARTICULOS_X_VENTA AS AXV ON VE.IDVENTA = AXV.IDVENTA INNER JOIN ARTICULOS AS AR ON AXV.IDARTICULO = AR.IDARTICULO GROUP BY VE.IDVENTA, CL.APELLIDO, US.APELLIDO,VE.FECHA,CL.NOMBRE, US.NOMBRE ORDER BY VE.IDVENTA DESC").Tables[0];
        }

        private void btnReporte2_Click(object sender, EventArgs e)
        {
            //VentasDetalle vent;
            //vent = (VentasDetalle)DgvFacturacion.CurrentRow.DataBoundItem;
            Ventasss ff = new Ventasss(Convert.ToInt32(txtFacID.Text));
            ff.ShowDialog();

            //VentasNegocio vent = new VentasNegocio();
            //vent.listarVentas();
            //DgvFacturacion.DataSource = BD.Ejecutar("SELECT VE.IDVENTA AS FACTURA,VE.FECHA, CL.APELLIDO + ' ' + CL.NOMBRE AS CLIENTE, AR.DESCRIPCION,AXV.PU,US.APELLIDO + ' ' + US.NOMBRE  AS VENDEDOR FROM VENTAS AS VE INNER JOIN CLIENTES AS CL ON VE.IDCLIENTE = CL.IDCLIENTE INNER JOIN USUARIOS AS US ON VE.IDUSUARIO = US.IDUSUARIO INNER JOIN ARTICULOS_X_VENTA AS AXV ON VE.IDVENTA = AXV.IDVENTA INNER JOIN ARTICULOS AS AR ON AXV.IDARTICULO = AR.IDARTICULO ORDER BY VE.IDVENTA DESC").Tables[0];
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (txtFacID.Text == "") { MessageBox.Show("INGRESE NUMERO DE FACTURA"); }
            else
            {
                int newidventa = 0;

                VentasNegocio ventaacc = new VentasNegocio();
                newidventa = ventaacc.obtenerId();

                if (Convert.ToInt32(txtFacID.Text) > newidventa) { MessageBox.Show("NUMERO DE FACTURA INVALIDO"); }
                else
                {
                    int fac = Convert.ToInt32(txtFacID.Text);
                    Report1 form = new Report1(fac);
                    form.Show();
                }
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFacID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        public SqlConnection cn = new SqlConnection ("data source=LAPTOP-20LSGO9A\\SQLEXPRESS; initial catalog=TPC_VICENS_BD; integrated security=sspi");

        void buscar()
        {

            SqlDataAdapter da = new SqlDataAdapter("buscar",cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@fechaini", SqlDbType.DateTime).Value = dtpFechaInicial.Text;
            da.SelectCommand.Parameters.Add("@fechafinal", SqlDbType.DateTime).Value = dtpFechaFinal.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.DgvFacturacion.DataSource = dt;

        }


        void buscarid()
        {

            SqlDataAdapter da = new SqlDataAdapter("buscarid", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = txtId.Text;
            
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.DgvFacturacion.DataSource = dt;

        }

        void buscarapellido()
        {

            SqlDataAdapter da = new SqlDataAdapter("buscarapellido", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@apellido", SqlDbType.NVarChar).Value = txtApellido.Text;

            DataTable dt = new DataTable();
            da.Fill(dt);
            this.DgvFacturacion.DataSource = dt;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void btnBucarID_Click(object sender, EventArgs e)
        {
            buscarid();
        }

        private void btnApellido_Click(object sender, EventArgs e)
        {
            buscarapellido();
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void DgvFacturacion_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = DgvFacturacion.CurrentRow;

            if (row == null)
                return;

            txtFacID.Text = row.Cells["Factura"].Value.ToString();
        }

        private void txtFacID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
