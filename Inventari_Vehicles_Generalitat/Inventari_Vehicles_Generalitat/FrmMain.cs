using Inventari_Vehicles_Generalitat.CLASSES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Excel = Microsoft.Office.Interop.Excel;

namespace Inventari_Vehicles_Generalitat
{
    public partial class FrmMain: Form
    {
        static XPathDocument document;
        XPathNavigator navegador;
        ClExportar ExportarDades; 
        // objectes que utilitzarem per a crear un nou arxiu XML
        XmlDocument xDoc;
        XmlNode xNodeArrel;
        XmlDeclaration xDeclaracio;
        XmlComment xComentari;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btExaminar_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos XML (*.xml)|*.xml";
                openFileDialog.Title = "Seleccionar un archivo XML";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tbRuta.Text = openFileDialog.FileName;
                    document = new XPathDocument(openFileDialog.FileName);
                    navegador = document.CreateNavigator();
                }

            }

            getCombo();
            getMarques();
            getDates();
        }

        private void getDates()
        {
            XPathNodeIterator cursor = navegador.Select("//row/row");

            DateTime fechaMinima = DateTime.MaxValue; // Inicializar con el valor máximo posible
            DateTime fechaMaxima = DateTime.MinValue; // Inicializar con el valor mínimo posible

            while (cursor.MoveNext())
            {
                string fechaString = cursor.Current.SelectSingleNode("data_d_alta_inventari")?.Value;

                if (DateTime.TryParse(fechaString, out DateTime fecha))
                {
                    if (fecha < fechaMinima && fecha != DateTime.MinValue)
                    {
                        fechaMinima = fecha; // Actualizar la fecha mínima
                    }

                    if (fecha > fechaMaxima)
                    {
                        fechaMaxima = fecha; // Actualizar la fecha máxima
                    }
                }
            }

            // Asignar las fechas a los DateTimePicker
            if (fechaMinima != DateTime.MaxValue) // Si se encontró al menos una fecha válida
            {
                dtpInici.Value = fechaMinima;
                dtpInici.MinDate = fechaMinima;
                dtpInici.MaxDate = fechaMaxima;

                dtpFin.Value = fechaMaxima;
                dtpFin.MinDate = fechaMinima;
                dtpFin.MaxDate = fechaMaxima;

            }
            else
            {
                // Si no se encontraron fechas válidas, establecer valores predeterminados
                dtpInici.Value = DateTime.Now;
                dtpFin.Value = DateTime.Now;
            }
        }

        private void getCombo()
        {
            XPathNodeIterator cursor = navegador.Select("//tipus_de_combustible");

            HashSet<string> combustibles = new HashSet<string>(StringComparer.OrdinalIgnoreCase); 

            while (cursor.MoveNext())
            {
                string valor = cursor.Current.Value.Trim(); 
                if (!string.IsNullOrEmpty(valor))
                {
                    combustibles.Add(valor);
                }
            }

            List<string> listaOrdenada = combustibles.ToList();
            listaOrdenada.Sort();

            cbCombustible.Items.Clear();
            cbCombustible.Items.AddRange(listaOrdenada.ToArray());

            if (cbCombustible.Items.Count > 0)
            {
                cbCombustible.SelectedIndex = 0;
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(ckFiltre.Checked==true)
            {
                cbCombustible.Enabled = true;
            }
            else
            {
                cbCombustible.Enabled = false;
            }
            getMarques();
        }

        private void getMarques()
        {
            string xpathQuery;
            if (cbCombustible.Enabled == true)
            {
                xpathQuery = $"//row[tipus_de_combustible='{cbCombustible.SelectedItem.ToString()}']/marca";
            }
            else
            {
                xpathQuery = $"//row/marca";
            }

            navegador = document.CreateNavigator();
            XPathNodeIterator cursor = null;
            XPathExpression expr = navegador.Compile(xpathQuery);
            expr.AddSort("marca", XmlSortOrder.Ascending, XmlCaseOrder.None, "", XmlDataType.Text);

            lbMarca.Items.Clear();
            cursor = navegador.Select(expr);

            HashSet<string> marcasUnicas = new HashSet<string>();

            foreach (XPathNavigator tut in cursor)
            {
                string marca = tut.Value.ToString();
                if (!marcasUnicas.Contains(marca))
                {
                    marcasUnicas.Add(marca);
                    lbMarca.Items.Add(marca);
                }
            }


        }

        private void cbCombustible_SelectedIndexChanged(object sender, EventArgs e)
        {
            getMarques();
        }

        private void btMostrarDades_Click(object sender, EventArgs e)
        {
            int numVehicles = 0;
            var vehiclesList = new List<Vehicle>(); 

            navegador = document.CreateNavigator();
            XPathNodeIterator cursor = navegador.Select("//row/row"); 

            bool filterCombustible = cbCombustible.Enabled;

            var marcasSeleccionadas = new List<String>();
            foreach (string item in lbMarca.SelectedItems)
            {
                marcasSeleccionadas.Add(item); // Asume que el texto del item es la marca
            }


            foreach (XPathNavigator vehiculo in cursor)
            {
                DateTime dataAltaInv;

                string marca = vehiculo.SelectSingleNode("marca")?.Value;
                string modelo = vehiculo.SelectSingleNode("model")?.Value;
                string tipoDret = vehiculo.SelectSingleNode("tipus_de_dret")?.Value;

                if (DateTime.TryParse(vehiculo.SelectSingleNode("data_d_alta_inventari")?.Value, out DateTime parsedDate))
                {
                    dataAltaInv = parsedDate;
                }
                else
                {
                    dataAltaInv = default(DateTime);
                }

                string denominaci = vehiculo.SelectSingleNode("denominaci")?.Value;
                string combustible = vehiculo.SelectSingleNode("tipus_de_combustible")?.Value;

                if (dataAltaInv<=dtpInici.Value || dataAltaInv>=dtpFin.Value)
                {
                    continue;
                }

                if (filterCombustible && combustible != cbCombustible.SelectedItem.ToString())
                {
                    continue; 
                }
                if (marcasSeleccionadas.Count > 0 && !marcasSeleccionadas.Contains(marca))
                {
                    continue;
                }


                vehiclesList.Add(new Vehicle
                {
                    Marca = marca,
                    Modelo = modelo,
                    TipusDret = tipoDret,
                    DataAltaInv = dataAltaInv,
                    Denominacio = denominaci,
                    tipusCombustible = combustible
                });
            }

            // Ordenacion xd
            if (rbDataASC.Checked)
            {
                vehiclesList = vehiclesList.OrderBy(v => v.DataAltaInv).ToList();
            }
            else if (rbDataDESC.Checked)
            {
                vehiclesList = vehiclesList.OrderByDescending(v => v.DataAltaInv).ToList();
            }
            else if (rbMarca.Checked)
            {
                vehiclesList = vehiclesList.OrderByDescending(v => v.Marca).ThenBy(v => v.Modelo).ToList();
            }
            else if (rbTipusDret.Checked)
            {
                vehiclesList = vehiclesList.OrderByDescending(v => v.TipusDret).ToList();
            }

            
            dgDades.Rows.Clear();
            dgDades.Columns.Clear();
            dgDades.Columns.Add("Marca", "Marca");
            dgDades.Columns.Add("Modelo", "Modelo");
            dgDades.Columns.Add("TipusDret", "Tipus Dret");
            dgDades.Columns.Add("DataAltaInv", "Data Alta Inventari");
            dgDades.Columns.Add("Denominacio", "Denominació");
            dgDades.Columns.Add("TipusCombustible", "Tipus de Combustible");

            foreach (var vehicle in vehiclesList)
            {
                dgDades.Rows.Add(vehicle.Marca, vehicle.Modelo, vehicle.TipusDret, vehicle.DataAltaInv.ToString("yyyy-MM-dd"), vehicle.Denominacio, vehicle.tipusCombustible);
                numVehicles++;
            }

            tbVehicles.Text = numVehicles.ToString();
        }

        private void dtpInici_ValueChanged(object sender, EventArgs e)
        {
            //DateTime dtMinim = new DateTime(1985, 5, 10);
            //if(dtpInici.Value<dtMinim) dtpInici.Value = dtMinim;
        }

        private void btMarcas_Click(object sender, EventArgs e)
        {
            List<string> listMarques = lbMarca.Items.Cast<string>().ToList();
            ExportarDades = new ClExportar();
            ExportarDades.exportarList(listMarques, "Marques");
        }

        private void btCombustibles_Click(object sender, EventArgs e)
        {
            List<string> comboBoxItems = cbCombustible.Items.Cast<string>().ToList();
            ExportarDades = new ClExportar();
            ExportarDades.exportarList(comboBoxItems, "Combustibles");
        }

        private void btData_Click(object sender, EventArgs e)
        {
            ExportarDades = new ClExportar();
            ExportarDades.exportarDg(dgDades,"Dades Vehicles");
        }
    }
}
