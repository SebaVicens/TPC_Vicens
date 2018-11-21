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
//using CrystalDecisions.CrystalReports.Engine;
//using CrystalDecisions.Shared;

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
            DgvFacturacion.DataSource = BD.Ejecutar("SELECT VE.IDVENTA AS FACTURA,VE.FECHA, CL.APELLIDO+' '+ CL.NOMBRE AS CLIENTE,US.APELLIDO+' '+ US.NOMBRE  AS VENDEDOR, SUM(AXV.PU) AS TOTAL_FACTURA FROM VENTAS AS VE INNER JOIN CLIENTES AS CL ON VE.IDCLIENTE = CL.IDCLIENTE INNER JOIN USUARIOS AS US ON VE.IDUSUARIO = US.IDUSUARIO INNER JOIN ARTICULOS_X_VENTA AS AXV ON VE.IDVENTA = AXV.IDVENTA INNER JOIN ARTICULOS AS AR ON AXV.IDARTICULO = AR.IDARTICULO GROUP BY VE.IDVENTA, CL.APELLIDO, US.APELLIDO,VE.FECHA,CL.NOMBRE, US.NOMBRE ORDER BY VE.IDVENTA DESC").Tables[0];
        }

        private void btnReporte2_Click(object sender, EventArgs e)
        {
            DgvFacturacion.DataSource = BD.Ejecutar("SELECT VE.IDVENTA AS FACTURA,VE.FECHA, CL.APELLIDO + ' ' + CL.NOMBRE AS CLIENTE, AR.DESCRIPCION,AXV.PU,US.APELLIDO + ' ' + US.NOMBRE  AS VENDEDOR FROM VENTAS AS VE INNER JOIN CLIENTES AS CL ON VE.IDCLIENTE = CL.IDCLIENTE INNER JOIN USUARIOS AS US ON VE.IDUSUARIO = US.IDUSUARIO INNER JOIN ARTICULOS_X_VENTA AS AXV ON VE.IDVENTA = AXV.IDVENTA INNER JOIN ARTICULOS AS AR ON AXV.IDARTICULO = AR.IDARTICULO ORDER BY VE.IDVENTA DESC").Tables[0];
        }
    }
}
