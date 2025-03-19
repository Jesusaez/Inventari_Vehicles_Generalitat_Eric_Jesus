namespace Inventari_Vehicles_Generalitat
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbOrdenar = new System.Windows.Forms.GroupBox();
            this.rbTipusDret = new System.Windows.Forms.RadioButton();
            this.rbMarca = new System.Windows.Forms.RadioButton();
            this.rbDataDESC = new System.Windows.Forms.RadioButton();
            this.rbDataASC = new System.Windows.Forms.RadioButton();
            this.btData = new System.Windows.Forms.Button();
            this.btCombustibles = new System.Windows.Forms.Button();
            this.btMarcas = new System.Windows.Forms.Button();
            this.btMostrarDades = new System.Windows.Forms.Button();
            this.dgDades = new System.Windows.Forms.DataGridView();
            this.gbTotals = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbVehicles = new System.Windows.Forms.TextBox();
            this.gbDades = new System.Windows.Forms.GroupBox();
            this.ckFiltre = new System.Windows.Forms.CheckBox();
            this.lbMarca = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCombustible = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbFitxer = new System.Windows.Forms.GroupBox();
            this.btExaminar = new System.Windows.Forms.Button();
            this.tbRuta = new System.Windows.Forms.TextBox();
            this.gbDates = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpInici = new System.Windows.Forms.DateTimePicker();
            this.gbExportar = new System.Windows.Forms.GroupBox();
            this.gbOrdenar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDades)).BeginInit();
            this.gbTotals.SuspendLayout();
            this.gbDades.SuspendLayout();
            this.gbFitxer.SuspendLayout();
            this.gbDates.SuspendLayout();
            this.gbExportar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOrdenar
            // 
            this.gbOrdenar.Controls.Add(this.rbTipusDret);
            this.gbOrdenar.Controls.Add(this.rbMarca);
            this.gbOrdenar.Controls.Add(this.rbDataDESC);
            this.gbOrdenar.Controls.Add(this.rbDataASC);
            this.gbOrdenar.Location = new System.Drawing.Point(893, 118);
            this.gbOrdenar.Name = "gbOrdenar";
            this.gbOrdenar.Size = new System.Drawing.Size(537, 73);
            this.gbOrdenar.TabIndex = 12;
            this.gbOrdenar.TabStop = false;
            this.gbOrdenar.Text = "Ordenar";
            // 
            // rbTipusDret
            // 
            this.rbTipusDret.AutoSize = true;
            this.rbTipusDret.Location = new System.Drawing.Point(416, 31);
            this.rbTipusDret.Name = "rbTipusDret";
            this.rbTipusDret.Size = new System.Drawing.Size(90, 20);
            this.rbTipusDret.TabIndex = 3;
            this.rbTipusDret.Text = "Tipus Dret";
            this.rbTipusDret.UseVisualStyleBackColor = true;
            this.rbTipusDret.Click += new System.EventHandler(this.btMostrarDades_Click);
            // 
            // rbMarca
            // 
            this.rbMarca.AutoSize = true;
            this.rbMarca.Location = new System.Drawing.Point(268, 31);
            this.rbMarca.Name = "rbMarca";
            this.rbMarca.Size = new System.Drawing.Size(117, 20);
            this.rbMarca.TabIndex = 2;
            this.rbMarca.Text = "Marca y Model";
            this.rbMarca.UseVisualStyleBackColor = true;
            this.rbMarca.Click += new System.EventHandler(this.btMostrarDades_Click);
            // 
            // rbDataDESC
            // 
            this.rbDataDESC.AutoSize = true;
            this.rbDataDESC.Location = new System.Drawing.Point(132, 31);
            this.rbDataDESC.Name = "rbDataDESC";
            this.rbDataDESC.Size = new System.Drawing.Size(93, 20);
            this.rbDataDESC.TabIndex = 1;
            this.rbDataDESC.Text = "Data Alta ↓";
            this.rbDataDESC.UseVisualStyleBackColor = true;
            this.rbDataDESC.Click += new System.EventHandler(this.btMostrarDades_Click);
            // 
            // rbDataASC
            // 
            this.rbDataASC.AutoSize = true;
            this.rbDataASC.Checked = true;
            this.rbDataASC.Location = new System.Drawing.Point(7, 31);
            this.rbDataASC.Name = "rbDataASC";
            this.rbDataASC.Size = new System.Drawing.Size(93, 20);
            this.rbDataASC.TabIndex = 0;
            this.rbDataASC.TabStop = true;
            this.rbDataASC.Text = "Data Alta ↑";
            this.rbDataASC.UseVisualStyleBackColor = true;
            this.rbDataASC.Click += new System.EventHandler(this.btMostrarDades_Click);
            // 
            // btData
            // 
            this.btData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btData.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btData.Location = new System.Drawing.Point(557, 31);
            this.btData.Name = "btData";
            this.btData.Size = new System.Drawing.Size(177, 42);
            this.btData.TabIndex = 15;
            this.btData.Text = "Data Grid View";
            this.btData.UseVisualStyleBackColor = false;
            this.btData.Click += new System.EventHandler(this.btData_Click);
            // 
            // btCombustibles
            // 
            this.btCombustibles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btCombustibles.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btCombustibles.Location = new System.Drawing.Point(344, 31);
            this.btCombustibles.Name = "btCombustibles";
            this.btCombustibles.Size = new System.Drawing.Size(177, 42);
            this.btCombustibles.TabIndex = 14;
            this.btCombustibles.Text = "Tipus Combustibles";
            this.btCombustibles.UseVisualStyleBackColor = false;
            this.btCombustibles.Click += new System.EventHandler(this.btCombustibles_Click);
            // 
            // btMarcas
            // 
            this.btMarcas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btMarcas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btMarcas.Location = new System.Drawing.Point(128, 31);
            this.btMarcas.Name = "btMarcas";
            this.btMarcas.Size = new System.Drawing.Size(177, 42);
            this.btMarcas.TabIndex = 13;
            this.btMarcas.Text = "Marques y Models";
            this.btMarcas.UseVisualStyleBackColor = false;
            this.btMarcas.Click += new System.EventHandler(this.btMarcas_Click);
            // 
            // btMostrarDades
            // 
            this.btMostrarDades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btMostrarDades.ForeColor = System.Drawing.SystemColors.Control;
            this.btMostrarDades.Location = new System.Drawing.Point(173, 686);
            this.btMostrarDades.Name = "btMostrarDades";
            this.btMostrarDades.Size = new System.Drawing.Size(177, 42);
            this.btMostrarDades.TabIndex = 9;
            this.btMostrarDades.Text = "Mostrar Dades";
            this.btMostrarDades.UseVisualStyleBackColor = false;
            this.btMostrarDades.Click += new System.EventHandler(this.btMostrarDades_Click);
            // 
            // dgDades
            // 
            this.dgDades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDades.Location = new System.Drawing.Point(364, 198);
            this.dgDades.Name = "dgDades";
            this.dgDades.RowHeadersWidth = 51;
            this.dgDades.RowTemplate.Height = 24;
            this.dgDades.Size = new System.Drawing.Size(1066, 451);
            this.dgDades.TabIndex = 11;
            // 
            // gbTotals
            // 
            this.gbTotals.Controls.Add(this.label3);
            this.gbTotals.Controls.Add(this.tbVehicles);
            this.gbTotals.Location = new System.Drawing.Point(645, 119);
            this.gbTotals.Name = "gbTotals";
            this.gbTotals.Size = new System.Drawing.Size(232, 73);
            this.gbTotals.TabIndex = 10;
            this.gbTotals.TabStop = false;
            this.gbTotals.Text = "Totals";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vehicles";
            // 
            // tbVehicles
            // 
            this.tbVehicles.Enabled = false;
            this.tbVehicles.Location = new System.Drawing.Point(108, 27);
            this.tbVehicles.Name = "tbVehicles";
            this.tbVehicles.Size = new System.Drawing.Size(111, 22);
            this.tbVehicles.TabIndex = 0;
            // 
            // gbDades
            // 
            this.gbDades.Controls.Add(this.ckFiltre);
            this.gbDades.Controls.Add(this.lbMarca);
            this.gbDades.Controls.Add(this.label4);
            this.gbDades.Controls.Add(this.cbCombustible);
            this.gbDades.Controls.Add(this.label2);
            this.gbDades.Location = new System.Drawing.Point(12, 118);
            this.gbDades.Name = "gbDades";
            this.gbDades.Size = new System.Drawing.Size(330, 550);
            this.gbDades.TabIndex = 8;
            this.gbDades.TabStop = false;
            this.gbDades.Text = "Tria les dades a Consultar";
            // 
            // ckFiltre
            // 
            this.ckFiltre.AutoSize = true;
            this.ckFiltre.Checked = true;
            this.ckFiltre.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckFiltre.Location = new System.Drawing.Point(189, 51);
            this.ckFiltre.Name = "ckFiltre";
            this.ckFiltre.Size = new System.Drawing.Size(102, 20);
            this.ckFiltre.TabIndex = 7;
            this.ckFiltre.Text = "Activar Filtre";
            this.ckFiltre.UseVisualStyleBackColor = true;
            this.ckFiltre.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lbMarca
            // 
            this.lbMarca.FormattingEnabled = true;
            this.lbMarca.ItemHeight = 16;
            this.lbMarca.Location = new System.Drawing.Point(10, 175);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbMarca.Size = new System.Drawing.Size(311, 356);
            this.lbMarca.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Marques";
            // 
            // cbCombustible
            // 
            this.cbCombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCombustible.FormattingEnabled = true;
            this.cbCombustible.Location = new System.Drawing.Point(10, 91);
            this.cbCombustible.Name = "cbCombustible";
            this.cbCombustible.Size = new System.Drawing.Size(314, 24);
            this.cbCombustible.TabIndex = 0;
            this.cbCombustible.SelectedIndexChanged += new System.EventHandler(this.cbCombustible_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipus de Combustible";
            // 
            // gbFitxer
            // 
            this.gbFitxer.Controls.Add(this.btExaminar);
            this.gbFitxer.Controls.Add(this.tbRuta);
            this.gbFitxer.Location = new System.Drawing.Point(12, 12);
            this.gbFitxer.Name = "gbFitxer";
            this.gbFitxer.Size = new System.Drawing.Size(1418, 100);
            this.gbFitxer.TabIndex = 7;
            this.gbFitxer.TabStop = false;
            this.gbFitxer.Text = "Fitxer XML";
            // 
            // btExaminar
            // 
            this.btExaminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btExaminar.ForeColor = System.Drawing.SystemColors.Control;
            this.btExaminar.Location = new System.Drawing.Point(1235, 27);
            this.btExaminar.Name = "btExaminar";
            this.btExaminar.Size = new System.Drawing.Size(177, 54);
            this.btExaminar.TabIndex = 1;
            this.btExaminar.Text = "Examinar";
            this.btExaminar.UseVisualStyleBackColor = false;
            this.btExaminar.Click += new System.EventHandler(this.btExaminar_Click_1);
            // 
            // tbRuta
            // 
            this.tbRuta.Location = new System.Drawing.Point(29, 43);
            this.tbRuta.Name = "tbRuta";
            this.tbRuta.Size = new System.Drawing.Size(1200, 22);
            this.tbRuta.TabIndex = 0;
            // 
            // gbDates
            // 
            this.gbDates.Controls.Add(this.label1);
            this.gbDates.Controls.Add(this.lbData);
            this.gbDates.Controls.Add(this.dtpFin);
            this.gbDates.Controls.Add(this.dtpInici);
            this.gbDates.Location = new System.Drawing.Point(364, 119);
            this.gbDates.Name = "gbDates";
            this.gbDates.Size = new System.Drawing.Size(275, 73);
            this.gbDates.TabIndex = 11;
            this.gbDates.TabStop = false;
            this.gbDates.Text = "Dates";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hasta";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(58, 22);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(48, 16);
            this.lbData.TabIndex = 8;
            this.lbData.Text = "Desde";
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(157, 40);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(112, 22);
            this.dtpFin.TabIndex = 1;
            this.dtpFin.ValueChanged += new System.EventHandler(this.dtpInici_ValueChanged_1);
            // 
            // dtpInici
            // 
            this.dtpInici.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInici.Location = new System.Drawing.Point(19, 41);
            this.dtpInici.Name = "dtpInici";
            this.dtpInici.Size = new System.Drawing.Size(117, 22);
            this.dtpInici.TabIndex = 0;
            this.dtpInici.ValueChanged += new System.EventHandler(this.dtpInici_ValueChanged_1);
            // 
            // gbExportar
            // 
            this.gbExportar.Controls.Add(this.btMarcas);
            this.gbExportar.Controls.Add(this.btCombustibles);
            this.gbExportar.Controls.Add(this.btData);
            this.gbExportar.Location = new System.Drawing.Point(356, 655);
            this.gbExportar.Name = "gbExportar";
            this.gbExportar.Size = new System.Drawing.Size(1074, 85);
            this.gbExportar.TabIndex = 16;
            this.gbExportar.TabStop = false;
            this.gbExportar.Text = "Exportar dades";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 753);
            this.Controls.Add(this.gbExportar);
            this.Controls.Add(this.gbDates);
            this.Controls.Add(this.gbOrdenar);
            this.Controls.Add(this.btMostrarDades);
            this.Controls.Add(this.dgDades);
            this.Controls.Add(this.gbTotals);
            this.Controls.Add(this.gbDades);
            this.Controls.Add(this.gbFitxer);
            this.Name = "FrmMain";
            this.Text = "Inventari de vehicles de la Generalitat de Catalunya i el sector públic";
            this.gbOrdenar.ResumeLayout(false);
            this.gbOrdenar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDades)).EndInit();
            this.gbTotals.ResumeLayout(false);
            this.gbTotals.PerformLayout();
            this.gbDades.ResumeLayout(false);
            this.gbDades.PerformLayout();
            this.gbFitxer.ResumeLayout(false);
            this.gbFitxer.PerformLayout();
            this.gbDates.ResumeLayout(false);
            this.gbDates.PerformLayout();
            this.gbExportar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOrdenar;
        private System.Windows.Forms.RadioButton rbTipusDret;
        private System.Windows.Forms.RadioButton rbMarca;
        private System.Windows.Forms.RadioButton rbDataDESC;
        private System.Windows.Forms.RadioButton rbDataASC;
        private System.Windows.Forms.Button btData;
        private System.Windows.Forms.Button btCombustibles;
        private System.Windows.Forms.Button btMarcas;
        private System.Windows.Forms.Button btMostrarDades;
        private System.Windows.Forms.DataGridView dgDades;
        private System.Windows.Forms.GroupBox gbTotals;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbVehicles;
        private System.Windows.Forms.GroupBox gbDades;
        private System.Windows.Forms.CheckBox ckFiltre;
        private System.Windows.Forms.ListBox lbMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCombustible;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbFitxer;
        private System.Windows.Forms.Button btExaminar;
        private System.Windows.Forms.TextBox tbRuta;
        private System.Windows.Forms.GroupBox gbDates;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpInici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.GroupBox gbExportar;
    }
}

