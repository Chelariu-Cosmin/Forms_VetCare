namespace VetCate.NET
{
    partial class IncomeVET
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label denumireVaccinLabel;
            System.Windows.Forms.Label anotimpLabel;
            System.Windows.Forms.Label numarAdministrariLabel;
            System.Windows.Forms.Label vaccinIDLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPacientID = new System.Windows.Forms.TextBox();
            this.txtPerioada = new System.Windows.Forms.TextBox();
            this.btnPdf = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAnotimp = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.vaccinIDText = new System.Windows.Forms.TextBox();
            this.txtVaccin = new System.Windows.Forms.TextBox();
            this.ddtGrid = new System.Windows.Forms.DataGridView();
            this.VaccinID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireVaccinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anotimpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numarAdministrariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerioadaAdministrare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PacientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaccinuriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vetDataSet = new VetCate.NET.VetDataSet();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.denumireVaccinText = new System.Windows.Forms.TextBox();
            this.anotimpText = new System.Windows.Forms.TextBox();
            this.numarAdministrariText = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtAnotimp = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblDenumireVaccin = new System.Windows.Forms.Label();
            this.vaccinuriTableAdapter = new VetCate.NET.VetDataSetTableAdapters.VaccinuriTableAdapter();
            this.tableAdapterManager = new VetCate.NET.VetDataSetTableAdapters.TableAdapterManager();
            this.vetDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vaccinuriBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            denumireVaccinLabel = new System.Windows.Forms.Label();
            anotimpLabel = new System.Windows.Forms.Label();
            numarAdministrariLabel = new System.Windows.Forms.Label();
            vaccinIDLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddtGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaccinuriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vetDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vetDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaccinuriBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // denumireVaccinLabel
            // 
            denumireVaccinLabel.AutoSize = true;
            denumireVaccinLabel.Location = new System.Drawing.Point(23, 48);
            denumireVaccinLabel.Name = "denumireVaccinLabel";
            denumireVaccinLabel.Size = new System.Drawing.Size(68, 16);
            denumireVaccinLabel.TabIndex = 24;
            denumireVaccinLabel.Text = "Denumire:";
            // 
            // anotimpLabel
            // 
            anotimpLabel.AutoSize = true;
            anotimpLabel.Location = new System.Drawing.Point(32, 86);
            anotimpLabel.Name = "anotimpLabel";
            anotimpLabel.Size = new System.Drawing.Size(59, 16);
            anotimpLabel.TabIndex = 22;
            anotimpLabel.Text = "Anotimp:";
            // 
            // numarAdministrariLabel
            // 
            numarAdministrariLabel.AutoSize = true;
            numarAdministrariLabel.Location = new System.Drawing.Point(32, 126);
            numarAdministrariLabel.Name = "numarAdministrariLabel";
            numarAdministrariLabel.Size = new System.Drawing.Size(65, 16);
            numarAdministrariLabel.TabIndex = 21;
            numarAdministrariLabel.Text = "Nr Admin:";
            numarAdministrariLabel.Click += new System.EventHandler(this.numarAdministrariLabel_Click);
            // 
            // vaccinIDLabel
            // 
            vaccinIDLabel.AutoSize = true;
            vaccinIDLabel.Location = new System.Drawing.Point(24, 13);
            vaccinIDLabel.Name = "vaccinIDLabel";
            vaccinIDLabel.Size = new System.Drawing.Size(67, 16);
            vaccinIDLabel.TabIndex = 38;
            vaccinIDLabel.Text = "Vaccin ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(3, 155);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(97, 16);
            label2.TabIndex = 50;
            label2.Text = "Perioada: (zile)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(220, 13);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(68, 16);
            label3.TabIndex = 52;
            label3.Text = "PacientID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txtPacientID);
            this.panel1.Controls.Add(label3);
            this.panel1.Controls.Add(this.txtPerioada);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(this.btnPdf);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblAnotimp);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(vaccinIDLabel);
            this.panel1.Controls.Add(this.vaccinIDText);
            this.panel1.Controls.Add(this.txtVaccin);
            this.panel1.Controls.Add(this.ddtGrid);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(denumireVaccinLabel);
            this.panel1.Controls.Add(this.denumireVaccinText);
            this.panel1.Controls.Add(anotimpLabel);
            this.panel1.Controls.Add(this.anotimpText);
            this.panel1.Controls.Add(numarAdministrariLabel);
            this.panel1.Controls.Add(this.numarAdministrariText);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1299, 521);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtPacientID
            // 
            this.txtPacientID.Location = new System.Drawing.Point(306, 10);
            this.txtPacientID.Name = "txtPacientID";
            this.txtPacientID.Size = new System.Drawing.Size(62, 22);
            this.txtPacientID.TabIndex = 53;
            // 
            // txtPerioada
            // 
            this.txtPerioada.Location = new System.Drawing.Point(103, 152);
            this.txtPerioada.Name = "txtPerioada";
            this.txtPerioada.Size = new System.Drawing.Size(100, 22);
            this.txtPerioada.TabIndex = 51;
            // 
            // btnPdf
            // 
            this.btnPdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPdf.Location = new System.Drawing.Point(558, 308);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(62, 41);
            this.btnPdf.TabIndex = 49;
            this.btnPdf.Text = "&PDF";
            this.btnPdf.UseVisualStyleBackColor = false;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(395, 139);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 35);
            this.panel3.TabIndex = 48;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "VaccinID",
            "NumarAdministrari"});
            this.comboBox1.Location = new System.Drawing.Point(67, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 24);
            this.comboBox1.TabIndex = 47;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "Sort by";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAnotimp
            // 
            this.lblAnotimp.AutoSize = true;
            this.lblAnotimp.Location = new System.Drawing.Point(407, 64);
            this.lblAnotimp.Name = "lblAnotimp";
            this.lblAnotimp.Size = new System.Drawing.Size(56, 16);
            this.lblAnotimp.TabIndex = 45;
            this.lblAnotimp.Text = "Anotimp";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(306, 54);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(62, 41);
            this.btnClear.TabIndex = 44;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chart1
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(633, 19);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "NumarAdministrari";
            series1.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(648, 486);
            this.chart1.TabIndex = 43;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnLoad.Location = new System.Drawing.Point(558, 400);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(62, 41);
            this.btnLoad.TabIndex = 42;
            this.btnLoad.Text = "&Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnExport.Location = new System.Drawing.Point(558, 228);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(62, 41);
            this.btnExport.TabIndex = 41;
            this.btnExport.Text = "&Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(306, 111);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(67, 41);
            this.btnUpdate.TabIndex = 40;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // vaccinIDText
            // 
            this.vaccinIDText.Enabled = false;
            this.vaccinIDText.Location = new System.Drawing.Point(103, 10);
            this.vaccinIDText.Name = "vaccinIDText";
            this.vaccinIDText.Size = new System.Drawing.Size(61, 22);
            this.vaccinIDText.TabIndex = 39;
            this.vaccinIDText.TextChanged += new System.EventHandler(this.vaccinIDText_TextChanged);
            // 
            // txtVaccin
            // 
            this.txtVaccin.Location = new System.Drawing.Point(410, 39);
            this.txtVaccin.Name = "txtVaccin";
            this.txtVaccin.Size = new System.Drawing.Size(124, 22);
            this.txtVaccin.TabIndex = 34;
            this.txtVaccin.TextChanged += new System.EventHandler(this.txtVaccin_TextChanged);
            // 
            // ddtGrid
            // 
            this.ddtGrid.AutoGenerateColumns = false;
            this.ddtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ddtGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VaccinID,
            this.denumireVaccinDataGridViewTextBoxColumn,
            this.anotimpDataGridViewTextBoxColumn,
            this.numarAdministrariDataGridViewTextBoxColumn,
            this.PerioadaAdministrare,
            this.PacientID});
            this.ddtGrid.DataSource = this.vaccinuriBindingSource;
            this.ddtGrid.Location = new System.Drawing.Point(0, 188);
            this.ddtGrid.Name = "ddtGrid";
            this.ddtGrid.RowHeadersWidth = 51;
            this.ddtGrid.RowTemplate.Height = 24;
            this.ddtGrid.Size = new System.Drawing.Size(552, 317);
            this.ddtGrid.TabIndex = 32;
            this.ddtGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ddtGrid_CellClick);
            this.ddtGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ddtGrid_CellContentClick);
            // 
            // VaccinID
            // 
            this.VaccinID.DataPropertyName = "VaccinID";
            this.VaccinID.HeaderText = "VaccinID";
            this.VaccinID.MinimumWidth = 6;
            this.VaccinID.Name = "VaccinID";
            this.VaccinID.Width = 125;
            // 
            // denumireVaccinDataGridViewTextBoxColumn
            // 
            this.denumireVaccinDataGridViewTextBoxColumn.DataPropertyName = "DenumireVaccin";
            this.denumireVaccinDataGridViewTextBoxColumn.HeaderText = "DenumireVaccin";
            this.denumireVaccinDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.denumireVaccinDataGridViewTextBoxColumn.Name = "denumireVaccinDataGridViewTextBoxColumn";
            this.denumireVaccinDataGridViewTextBoxColumn.Width = 125;
            // 
            // anotimpDataGridViewTextBoxColumn
            // 
            this.anotimpDataGridViewTextBoxColumn.DataPropertyName = "Anotimp";
            this.anotimpDataGridViewTextBoxColumn.HeaderText = "Anotimp";
            this.anotimpDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.anotimpDataGridViewTextBoxColumn.Name = "anotimpDataGridViewTextBoxColumn";
            this.anotimpDataGridViewTextBoxColumn.Width = 125;
            // 
            // numarAdministrariDataGridViewTextBoxColumn
            // 
            this.numarAdministrariDataGridViewTextBoxColumn.DataPropertyName = "NumarAdministrari";
            this.numarAdministrariDataGridViewTextBoxColumn.HeaderText = "NumarAdministrari";
            this.numarAdministrariDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numarAdministrariDataGridViewTextBoxColumn.Name = "numarAdministrariDataGridViewTextBoxColumn";
            this.numarAdministrariDataGridViewTextBoxColumn.Width = 125;
            // 
            // PerioadaAdministrare
            // 
            this.PerioadaAdministrare.DataPropertyName = "PerioadaAdministrare";
            this.PerioadaAdministrare.HeaderText = "PerioadaAdministrare";
            this.PerioadaAdministrare.MinimumWidth = 6;
            this.PerioadaAdministrare.Name = "PerioadaAdministrare";
            this.PerioadaAdministrare.Width = 125;
            // 
            // PacientID
            // 
            this.PacientID.DataPropertyName = "PacientID";
            this.PacientID.HeaderText = "PacientID";
            this.PacientID.MinimumWidth = 6;
            this.PacientID.Name = "PacientID";
            this.PacientID.Width = 125;
            // 
            // vaccinuriBindingSource
            // 
            this.vaccinuriBindingSource.DataMember = "Vaccinuri";
            this.vaccinuriBindingSource.DataSource = this.vetDataSet;
            // 
            // vetDataSet
            // 
            this.vetDataSet.DataSetName = "VetDataSet";
            this.vetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.Location = new System.Drawing.Point(226, 111);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(62, 41);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.OldLace;
            this.btnCreate.Location = new System.Drawing.Point(226, 54);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(62, 41);
            this.btnCreate.TabIndex = 29;
            this.btnCreate.Text = "&Save";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // denumireVaccinText
            // 
            this.denumireVaccinText.Location = new System.Drawing.Point(103, 45);
            this.denumireVaccinText.Name = "denumireVaccinText";
            this.denumireVaccinText.Size = new System.Drawing.Size(100, 22);
            this.denumireVaccinText.TabIndex = 27;
            // 
            // anotimpText
            // 
            this.anotimpText.Location = new System.Drawing.Point(103, 83);
            this.anotimpText.Name = "anotimpText";
            this.anotimpText.Size = new System.Drawing.Size(100, 22);
            this.anotimpText.TabIndex = 25;
            this.anotimpText.TextChanged += new System.EventHandler(this.anotimpText_TextChanged);
            // 
            // numarAdministrariText
            // 
            this.numarAdministrariText.Location = new System.Drawing.Point(103, 120);
            this.numarAdministrariText.Name = "numarAdministrariText";
            this.numarAdministrariText.Size = new System.Drawing.Size(100, 22);
            this.numarAdministrariText.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtAnotimp);
            this.panel2.Controls.Add(this.btnFilter);
            this.panel2.Controls.Add(this.lblDenumireVaccin);
            this.panel2.Location = new System.Drawing.Point(395, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 104);
            this.panel2.TabIndex = 47;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtAnotimp
            // 
            this.txtAnotimp.Location = new System.Drawing.Point(15, 64);
            this.txtAnotimp.Name = "txtAnotimp";
            this.txtAnotimp.Size = new System.Drawing.Size(124, 22);
            this.txtAnotimp.TabIndex = 46;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(156, 30);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(55, 40);
            this.btnFilter.TabIndex = 37;
            this.btnFilter.Text = "&Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lblDenumireVaccin
            // 
            this.lblDenumireVaccin.AutoSize = true;
            this.lblDenumireVaccin.Location = new System.Drawing.Point(12, 0);
            this.lblDenumireVaccin.Name = "lblDenumireVaccin";
            this.lblDenumireVaccin.Size = new System.Drawing.Size(109, 16);
            this.lblDenumireVaccin.TabIndex = 33;
            this.lblDenumireVaccin.Text = "Denumire Vaccin";
            this.lblDenumireVaccin.Click += new System.EventHandler(this.lblDenumireVaccin_Click);
            // 
            // vaccinuriTableAdapter
            // 
            this.vaccinuriTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = VetCate.NET.VetDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VaccinuriTableAdapter = this.vaccinuriTableAdapter;
            // 
            // vetDataSetBindingSource
            // 
            this.vetDataSetBindingSource.DataSource = this.vetDataSet;
            this.vetDataSetBindingSource.Position = 0;
            // 
            // vaccinuriBindingSource1
            // 
            this.vaccinuriBindingSource1.DataMember = "Vaccinuri";
            this.vaccinuriBindingSource1.DataSource = this.vetDataSet;
            // 
            // IncomeVET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 545);
            this.Controls.Add(this.panel1);
            this.Name = "IncomeVET";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Income Vet";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddtGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaccinuriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vetDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vetDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaccinuriBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox denumireVaccinText;
        private System.Windows.Forms.TextBox anotimpText;
        private System.Windows.Forms.TextBox numarAdministrariText;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtVaccin;
        private System.Windows.Forms.Label lblDenumireVaccin;
        private System.Windows.Forms.DataGridView ddtGrid;
        private VetDataSet vetDataSet;
        private System.Windows.Forms.BindingSource vaccinuriBindingSource;
        private VetDataSetTableAdapters.VaccinuriTableAdapter vaccinuriTableAdapter;
        private VetDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource vaccinuriBindingSource1;
        private System.Windows.Forms.BindingSource vetDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn VaccinID;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireVaccinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anotimpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numarAdministrariDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox vaccinIDText;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtAnotimp;
        private System.Windows.Forms.Label lblAnotimp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerioadaAdministrare;
        private System.Windows.Forms.DataGridViewTextBoxColumn PacientID;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.TextBox txtPerioada;
        private System.Windows.Forms.TextBox txtPacientID;
    }
}

