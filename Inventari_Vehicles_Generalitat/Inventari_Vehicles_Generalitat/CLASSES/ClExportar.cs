using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Inventari_Vehicles_Generalitat.CLASSES
{
    public class ClExportar
    {
        private Excel.Application excelApp;
        private Excel.Workbook workbook;
        private Excel.Worksheet worksheet;

        private void iniExcel(string xWorksheetName)
        {
            if (excelApp == null)
            {
                excelApp = new Excel.Application();
                excelApp.Visible = false;
                workbook = excelApp.Workbooks.Add();
                worksheet = (Excel.Worksheet)workbook.Sheets.Add();
                worksheet.Name = xWorksheetName;
            }
        }
        public void exportarList(List<string> list, string worksheetName)
        {
            if (list.Count == 0)
            {
                MessageBox.Show("No hi han dades.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                iniExcel(worksheetName);

                //omplir capçalera
                worksheet.Cells[1] = worksheetName;
                omplirExcelList(list);
                desarExcel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar dades: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void omplirExcelList(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                worksheet.Cells[i + 2 , 1] = list[i].ToString();
            }
        }

        public void exportarDg(DataGridView dataGridView, string worksheetName)
        {
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("No hi han dades.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                iniExcel(worksheetName);

                omplirCapcalera(dataGridView);
                omplirExcelDg(dataGridView);
                desarExcel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar dades: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void omplirCapcalera(DataGridView dataGridView)
        {
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = dataGridView.Columns[i].HeaderText;
            }
        }

        private void omplirExcelDg(DataGridView dataGridView)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString() ?? "";
                }
            }
        }

        private string obrirDialog()
        {
            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "Arxius Excel (*.xlsx)|*.xlsx",
                Title = "Desar arxiu Excel",
                FileName = "Dades.xlsx"
            };

            return saveDialog.ShowDialog() == DialogResult.OK ? saveDialog.FileName : string.Empty;
        }

        private void desarExcel()
        {
            string rutaArchivo = obrirDialog();
            if (!string.IsNullOrEmpty(rutaArchivo))
            {
                workbook.SaveAs(rutaArchivo);
                workbook.Close();
                excelApp.Quit();
                excelApp = null;
                MessageBox.Show("Dades exportades correctament.", "DADES EXPORTADES", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                workbook.Close(false);
                excelApp.Quit();
                excelApp = null;
            }
        }
    }
}