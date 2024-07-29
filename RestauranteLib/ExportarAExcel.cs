using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace RestauranteLib
{
    public class ExportarAExcel
    {
        private XLWorkbook wb;

        public ExportarAExcel()
        {
            this.wb = new XLWorkbook();
        }

        public void ExportarListaAExcel(IEnumerable listaAExportar, string archivoAGuardar)
        {
            IXLWorksheet xLWorksheet = this.wb.AddWorksheet();
            xLWorksheet.Cell("A1").Value = "ReservaID";
            xLWorksheet.Cell("B1").Value = "ReservaCodigo";
            xLWorksheet.Cell("C1").Value = "ReservaDateTime";
            xLWorksheet.Cell("D1").Value = "CantidadPersonas";
            xLWorksheet.Cell("E1").Value = "NumeroDeMesa";
            xLWorksheet.Cell("F1").Value = "ReservaEstado";
            xLWorksheet.Cell("G1").Value = "ReservaCreacion";
            xLWorksheet.Cell("H1").Value = "ReservaCliente";
            xLWorksheet.Cell("A2").InsertData(listaAExportar);
            wb.SaveAs(archivoAGuardar);
        }
    }
}
