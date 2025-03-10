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
            this.btMostrarDades = new System.Windows.Forms.Button();
            this.dgDades = new System.Windows.Forms.DataGridView();
            this.municipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.any = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDades = new System.Windows.Forms.GroupBox();
            this.lbAny = new System.Windows.Forms.Label();
            this.lbMunicipis = new System.Windows.Forms.Label();
            this.lbComarca = new System.Windows.Forms.Label();
            this.lBoxMunicipis = new System.Windows.Forms.ListBox();
            this.nUdAny = new System.Windows.Forms.NumericUpDown();
            this.cbComarca = new System.Windows.Forms.ComboBox();
            this.gbTotals = new System.Windows.Forms.GroupBox();
            this.gbFitxer = new System.Windows.Forms.GroupBox();
            this.tbXml = new System.Windows.Forms.TextBox();
            this.btExaminar = new System.Windows.Forms.Button();
            this.btExport1 = new System.Windows.Forms.Button();
            this.btExport2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDades)).BeginInit();
            this.gbDades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUdAny)).BeginInit();
            this.gbFitxer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btMostrarDades
            // 
            this.btMostrarDades.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btMostrarDades.Location = new System.Drawing.Point(357, 735);
            this.btMostrarDades.Name = "btMostrarDades";
            this.btMostrarDades.Size = new System.Drawing.Size(146, 50);
            this.btMostrarDades.TabIndex = 9;
            this.btMostrarDades.Text = "Mostrar Dades";
            this.btMostrarDades.UseVisualStyleBackColor = false;
            // 
            // dgDades
            // 
            this.dgDades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.municipi,
            this.any});
            this.dgDades.Location = new System.Drawing.Point(524, 221);
            this.dgDades.Name = "dgDades";
            this.dgDades.RowHeadersWidth = 51;
            this.dgDades.RowTemplate.Height = 24;
            this.dgDades.Size = new System.Drawing.Size(762, 486);
            this.dgDades.TabIndex = 8;
            // 
            // municipi
            // 
            this.municipi.HeaderText = "Municipi";
            this.municipi.MinimumWidth = 6;
            this.municipi.Name = "municipi";
            this.municipi.Width = 125;
            // 
            // any
            // 
            this.any.HeaderText = "Any";
            this.any.MinimumWidth = 6;
            this.any.Name = "any";
            this.any.Width = 125;
            // 
            // gbDades
            // 
            this.gbDades.Controls.Add(this.lbAny);
            this.gbDades.Controls.Add(this.lbMunicipis);
            this.gbDades.Controls.Add(this.lbComarca);
            this.gbDades.Controls.Add(this.lBoxMunicipis);
            this.gbDades.Controls.Add(this.nUdAny);
            this.gbDades.Controls.Add(this.cbComarca);
            this.gbDades.Location = new System.Drawing.Point(9, 114);
            this.gbDades.Name = "gbDades";
            this.gbDades.Size = new System.Drawing.Size(509, 593);
            this.gbDades.TabIndex = 7;
            this.gbDades.TabStop = false;
            this.gbDades.Text = "tria les dades a consultar";
            // 
            // lbAny
            // 
            this.lbAny.AutoSize = true;
            this.lbAny.Location = new System.Drawing.Point(367, 48);
            this.lbAny.Name = "lbAny";
            this.lbAny.Size = new System.Drawing.Size(30, 16);
            this.lbAny.TabIndex = 5;
            this.lbAny.Text = "Any";
            // 
            // lbMunicipis
            // 
            this.lbMunicipis.AutoSize = true;
            this.lbMunicipis.Location = new System.Drawing.Point(7, 131);
            this.lbMunicipis.Name = "lbMunicipis";
            this.lbMunicipis.Size = new System.Drawing.Size(63, 16);
            this.lbMunicipis.TabIndex = 4;
            this.lbMunicipis.Text = "Municipis";
            // 
            // lbComarca
            // 
            this.lbComarca.AutoSize = true;
            this.lbComarca.Location = new System.Drawing.Point(7, 67);
            this.lbComarca.Name = "lbComarca";
            this.lbComarca.Size = new System.Drawing.Size(62, 16);
            this.lbComarca.TabIndex = 3;
            this.lbComarca.Text = "Comarca";
            // 
            // lBoxMunicipis
            // 
            this.lBoxMunicipis.Cursor = System.Windows.Forms.Cursors.Default;
            this.lBoxMunicipis.FormattingEnabled = true;
            this.lBoxMunicipis.ItemHeight = 16;
            this.lBoxMunicipis.Location = new System.Drawing.Point(6, 150);
            this.lBoxMunicipis.Name = "lBoxMunicipis";
            this.lBoxMunicipis.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lBoxMunicipis.Size = new System.Drawing.Size(488, 436);
            this.lBoxMunicipis.TabIndex = 2;
            // 
            // nUdAny
            // 
            this.nUdAny.Location = new System.Drawing.Point(417, 46);
            this.nUdAny.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nUdAny.Name = "nUdAny";
            this.nUdAny.Size = new System.Drawing.Size(77, 22);
            this.nUdAny.TabIndex = 1;
            this.nUdAny.Value = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            // 
            // cbComarca
            // 
            this.cbComarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComarca.FormattingEnabled = true;
            this.cbComarca.Location = new System.Drawing.Point(6, 89);
            this.cbComarca.Name = "cbComarca";
            this.cbComarca.Size = new System.Drawing.Size(488, 24);
            this.cbComarca.TabIndex = 0;
            // 
            // gbTotals
            // 
            this.gbTotals.Location = new System.Drawing.Point(524, 114);
            this.gbTotals.Name = "gbTotals";
            this.gbTotals.Size = new System.Drawing.Size(762, 100);
            this.gbTotals.TabIndex = 6;
            this.gbTotals.TabStop = false;
            this.gbTotals.Text = "totals";
            // 
            // gbFitxer
            // 
            this.gbFitxer.Controls.Add(this.tbXml);
            this.gbFitxer.Controls.Add(this.btExaminar);
            this.gbFitxer.Location = new System.Drawing.Point(9, 8);
            this.gbFitxer.Name = "gbFitxer";
            this.gbFitxer.Size = new System.Drawing.Size(1277, 100);
            this.gbFitxer.TabIndex = 5;
            this.gbFitxer.TabStop = false;
            this.gbFitxer.Text = " fitxer xml";
            // 
            // tbXml
            // 
            this.tbXml.Location = new System.Drawing.Point(39, 42);
            this.tbXml.Name = "tbXml";
            this.tbXml.Size = new System.Drawing.Size(1044, 22);
            this.tbXml.TabIndex = 1;
            // 
            // btExaminar
            // 
            this.btExaminar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btExaminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExaminar.Location = new System.Drawing.Point(1089, 21);
            this.btExaminar.Name = "btExaminar";
            this.btExaminar.Size = new System.Drawing.Size(168, 61);
            this.btExaminar.TabIndex = 0;
            this.btExaminar.Text = "EXAMINAR";
            this.btExaminar.UseVisualStyleBackColor = false;
            // 
            // btExport1
            // 
            this.btExport1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btExport1.Location = new System.Drawing.Point(662, 735);
            this.btExport1.Name = "btExport1";
            this.btExport1.Size = new System.Drawing.Size(146, 50);
            this.btExport1.TabIndex = 10;
            this.btExport1.Text = "Exportar1";
            this.btExport1.UseVisualStyleBackColor = false;
            // 
            // btExport2
            // 
            this.btExport2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btExport2.Location = new System.Drawing.Point(1027, 735);
            this.btExport2.Name = "btExport2";
            this.btExport2.Size = new System.Drawing.Size(146, 50);
            this.btExport2.TabIndex = 11;
            this.btExport2.Text = "Exportar2";
            this.btExport2.UseVisualStyleBackColor = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 802);
            this.Controls.Add(this.btExport2);
            this.Controls.Add(this.btExport1);
            this.Controls.Add(this.btMostrarDades);
            this.Controls.Add(this.dgDades);
            this.Controls.Add(this.gbDades);
            this.Controls.Add(this.gbTotals);
            this.Controls.Add(this.gbFitxer);
            this.Name = "FrmMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgDades)).EndInit();
            this.gbDades.ResumeLayout(false);
            this.gbDades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUdAny)).EndInit();
            this.gbFitxer.ResumeLayout(false);
            this.gbFitxer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btMostrarDades;
        private System.Windows.Forms.DataGridView dgDades;
        private System.Windows.Forms.DataGridViewTextBoxColumn municipi;
        private System.Windows.Forms.DataGridViewTextBoxColumn any;
        private System.Windows.Forms.GroupBox gbDades;
        private System.Windows.Forms.Label lbAny;
        private System.Windows.Forms.Label lbMunicipis;
        private System.Windows.Forms.Label lbComarca;
        private System.Windows.Forms.ListBox lBoxMunicipis;
        private System.Windows.Forms.NumericUpDown nUdAny;
        private System.Windows.Forms.ComboBox cbComarca;
        private System.Windows.Forms.GroupBox gbTotals;
        private System.Windows.Forms.GroupBox gbFitxer;
        private System.Windows.Forms.TextBox tbXml;
        private System.Windows.Forms.Button btExaminar;
        private System.Windows.Forms.Button btExport1;
        private System.Windows.Forms.Button btExport2;
    }
}

