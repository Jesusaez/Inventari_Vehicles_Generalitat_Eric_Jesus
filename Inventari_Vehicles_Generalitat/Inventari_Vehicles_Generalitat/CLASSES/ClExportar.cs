using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Inventari_Vehicles_Generalitat.CLASSES
{
    public class ClExportar
    {
        public void exportarList(List<string> list, string nom)
        {
            if (list.Count == 0)
            {
                MessageBox.Show("No hi han dades.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string miniNom = "Dades";
                if (nom == "Combustibles") miniNom = "Combustible";
                if (nom == "Marques") miniNom = "Marca";

                List<XElement> elementos = new List<XElement>();

                foreach (string item in list)
                {
                    elementos.Add(new XElement(miniNom, item));
                }

                XDocument xDoc = new XDocument(new XElement(nom, elementos));

                desarXML(xDoc);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar dades: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void exportarDg(DataGridView dgDades, string nom)
        {
            if (dgDades.Rows.Count == 0)
            {
                MessageBox.Show("No hi han dades.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                XElement xmlRoot = new XElement(nom.Replace(" ","_"));

                foreach (DataGridViewRow row in dgDades.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        XElement rowEle = new XElement("Cotxe");
                        foreach (DataGridViewCell celda in row.Cells)
                        {
                            string titol = dgDades.Columns[celda.ColumnIndex].HeaderText.Replace(" ", "_");
                            string dades = celda.Value == null || string.IsNullOrWhiteSpace(celda.Value.ToString()) ? "N/A" : celda.Value.ToString().Replace(" ", "_");
                            rowEle.Add(new XElement(titol, dades));
                        }
                        xmlRoot.Add(rowEle);
                    }
                }

                XDocument xmlDocument = new XDocument(xmlRoot);
                desarXML(xmlDocument);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar dades: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string obrirDialog()
        {
            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "Arxius XML (*.xml)|*.xml",
                Title = "Desar arxiu XML",
                FileName = "Dades.xml"
            };

            return saveDialog.ShowDialog() == DialogResult.OK ? saveDialog.FileName : string.Empty;
        }

        private void desarXML(XDocument xmlDocument)
        {
            string rutaArchivo = obrirDialog();
            if (!string.IsNullOrEmpty(rutaArchivo))
            {
                xmlDocument.Save(rutaArchivo);
                MessageBox.Show("Dades exportades correctament.", "DADES EXPORTADES", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
