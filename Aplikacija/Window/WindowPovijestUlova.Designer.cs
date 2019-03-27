namespace Aplikacija
{
    partial class WindowPovijestUlova
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowPovijestUlova));
            this.dgUlov = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDBrodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pocetakvrijemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.krajvrijemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDKBrodaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgStavkeUlov = new System.Windows.Forms.DataGridView();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.DateTimeKrajDatum = new MetroFramework.Controls.MetroDateTime();
            this.ComboBoxKapBroda = new MetroFramework.Controls.MetroComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.DateTimePocDatum = new MetroFramework.Controls.MetroDateTime();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.chartRibe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgUlov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulovBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStavkeUlov)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRibe)).BeginInit();
            this.metroTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgUlov
            // 
            this.dgUlov.AllowUserToAddRows = false;
            this.dgUlov.AllowUserToDeleteRows = false;
            this.dgUlov.AutoGenerateColumns = false;
            this.dgUlov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUlov.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.iDBrodDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.pocetakvrijemeDataGridViewTextBoxColumn,
            this.krajvrijemeDataGridViewTextBoxColumn,
            this.iDKBrodaDataGridViewTextBoxColumn});
            this.dgUlov.DataSource = this.ulovBindingSource;
            this.dgUlov.Location = new System.Drawing.Point(3, 3);
            this.dgUlov.Name = "dgUlov";
            this.dgUlov.ReadOnly = true;
            this.dgUlov.Size = new System.Drawing.Size(374, 150);
            this.dgUlov.TabIndex = 0;
            this.dgUlov.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUlov_RowEnter);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDBrodDataGridViewTextBoxColumn
            // 
            this.iDBrodDataGridViewTextBoxColumn.DataPropertyName = "IDBrod";
            this.iDBrodDataGridViewTextBoxColumn.HeaderText = "IDBrod";
            this.iDBrodDataGridViewTextBoxColumn.Name = "iDBrodDataGridViewTextBoxColumn";
            this.iDBrodDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDBrodDataGridViewTextBoxColumn.Visible = false;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pocetakvrijemeDataGridViewTextBoxColumn
            // 
            this.pocetakvrijemeDataGridViewTextBoxColumn.DataPropertyName = "Pocetak_vrijeme";
            this.pocetakvrijemeDataGridViewTextBoxColumn.HeaderText = "Pocetak_vrijeme";
            this.pocetakvrijemeDataGridViewTextBoxColumn.Name = "pocetakvrijemeDataGridViewTextBoxColumn";
            this.pocetakvrijemeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // krajvrijemeDataGridViewTextBoxColumn
            // 
            this.krajvrijemeDataGridViewTextBoxColumn.DataPropertyName = "Kraj_vrijeme";
            this.krajvrijemeDataGridViewTextBoxColumn.HeaderText = "Kraj_vrijeme";
            this.krajvrijemeDataGridViewTextBoxColumn.Name = "krajvrijemeDataGridViewTextBoxColumn";
            this.krajvrijemeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDKBrodaDataGridViewTextBoxColumn
            // 
            this.iDKBrodaDataGridViewTextBoxColumn.DataPropertyName = "IDKBroda";
            this.iDKBrodaDataGridViewTextBoxColumn.HeaderText = "IDKBroda";
            this.iDKBrodaDataGridViewTextBoxColumn.Name = "iDKBrodaDataGridViewTextBoxColumn";
            this.iDKBrodaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDKBrodaDataGridViewTextBoxColumn.Visible = false;
            // 
            // ulovBindingSource
            // 
            this.ulovBindingSource.DataSource = typeof(Aplikacija.Ulov);
            // 
            // dgStavkeUlov
            // 
            this.dgStavkeUlov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStavkeUlov.Location = new System.Drawing.Point(6, 168);
            this.dgStavkeUlov.Name = "dgStavkeUlov";
            this.dgStavkeUlov.Size = new System.Drawing.Size(316, 150);
            this.dgStavkeUlov.TabIndex = 1;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage4);
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(733, 375);
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.label2);
            this.metroTabPage1.Controls.Add(this.DateTimeKrajDatum);
            this.metroTabPage1.Controls.Add(this.ComboBoxKapBroda);
            this.metroTabPage1.Controls.Add(this.label4);
            this.metroTabPage1.Controls.Add(this.metroButton1);
            this.metroTabPage1.Controls.Add(this.dgUlov);
            this.metroTabPage1.Controls.Add(this.DateTimePocDatum);
            this.metroTabPage1.Controls.Add(this.dgStavkeUlov);
            this.metroTabPage1.Controls.Add(this.label1);
            this.metroTabPage1.Controls.Add(this.label3);
            this.metroTabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(725, 333);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Tablica";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(524, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Odaberi datum od i do";
            // 
            // DateTimeKrajDatum
            // 
            this.DateTimeKrajDatum.Location = new System.Drawing.Point(500, 109);
            this.DateTimeKrajDatum.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateTimeKrajDatum.Name = "DateTimeKrajDatum";
            this.DateTimeKrajDatum.Size = new System.Drawing.Size(200, 29);
            this.DateTimeKrajDatum.TabIndex = 8;
            // 
            // ComboBoxKapBroda
            // 
            this.ComboBoxKapBroda.FormattingEnabled = true;
            this.ComboBoxKapBroda.ItemHeight = 23;
            this.ComboBoxKapBroda.Location = new System.Drawing.Point(514, 250);
            this.ComboBoxKapBroda.Name = "ComboBoxKapBroda";
            this.ComboBoxKapBroda.Size = new System.Drawing.Size(169, 29);
            this.ComboBoxKapBroda.TabIndex = 4;
            this.ComboBoxKapBroda.UseSelectable = true;
            this.ComboBoxKapBroda.SelectedIndexChanged += new System.EventHandler(this.ComboBoxKBroda_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(158, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(554, 157);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(97, 43);
            this.metroButton1.TabIndex = 7;
            this.metroButton1.Text = "Generiraj";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // DateTimePocDatum
            // 
            this.DateTimePocDatum.Location = new System.Drawing.Point(500, 35);
            this.DateTimePocDatum.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateTimePocDatum.Name = "DateTimePocDatum";
            this.DateTimePocDatum.Size = new System.Drawing.Size(200, 29);
            this.DateTimePocDatum.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(524, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Odaberi podatke za prikaz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ukupna količina ribe :";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.chartRibe);
            this.metroTabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(725, 333);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Graf stavke ulova";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // chartRibe
            // 
            this.chartRibe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 0;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.None;
            chartArea1.Area3DStyle.PointDepth = 0;
            chartArea1.Area3DStyle.PointGapDepth = 0;
            chartArea1.BorderWidth = 5;
            chartArea1.Name = "ChartArea1";
            this.chartRibe.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            legend1.IsDockedInsideChartArea = false;
            legend1.IsEquallySpacedItems = true;
            legend1.IsTextAutoFit = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend1.Name = "Legend1";
            this.chartRibe.Legends.Add(legend1);
            this.chartRibe.Location = new System.Drawing.Point(-4, 3);
            this.chartRibe.Name = "chartRibe";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            series1.Legend = "Legend1";
            series1.Name = "Kilaža";
            series1.SmartLabelStyle.IsOverlappedHidden = false;
            series1.SmartLabelStyle.MinMovingDistance = 5D;
            this.chartRibe.Series.Add(series1);
            this.chartRibe.Size = new System.Drawing.Size(726, 334);
            this.chartRibe.TabIndex = 2;
            this.chartRibe.Text = "chartRibe";
            title1.Alignment = System.Drawing.ContentAlignment.MiddleRight;
            title1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Right;
            title1.Name = "Stavke ulova";
            title1.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            this.chartRibe.Titles.Add(title1);
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.Controls.Add(this.metroButton3);
            this.metroTabPage4.Controls.Add(this.chart1);
            this.metroTabPage4.HorizontalScrollbar = true;
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = true;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(725, 333);
            this.metroTabPage4.TabIndex = 4;
            this.metroTabPage4.Text = "Graf ukupan ulov";
            this.metroTabPage4.VerticalScrollbar = true;
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = true;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(3, 3);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(91, 36);
            this.metroButton3.TabIndex = 4;
            this.metroButton3.Text = "Spremi graf";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Area3DStyle.Enable3D = true;
            chartArea2.Area3DStyle.Inclination = 0;
            chartArea2.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.None;
            chartArea2.Area3DStyle.PointDepth = 0;
            chartArea2.Area3DStyle.PointGapDepth = 0;
            chartArea2.BorderWidth = 5;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            legend2.IsDockedInsideChartArea = false;
            legend2.IsEquallySpacedItems = true;
            legend2.IsTextAutoFit = false;
            legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(-4, 3);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            series2.Legend = "Legend1";
            series2.Name = "Kilaža";
            series2.SmartLabelStyle.IsOverlappedHidden = false;
            series2.SmartLabelStyle.MinMovingDistance = 5D;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(733, 337);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            title2.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title2.Name = "Title1";
            title2.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            this.chart1.Titles.Add(title2);
            // 
            // metroButton2
            // 
            this.metroButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton2.Location = new System.Drawing.Point(378, 20);
            this.metroButton2.MaximumSize = new System.Drawing.Size(84, 37);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(84, 37);
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "Natrag";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // WindowPovijestUlova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.metroButton2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "WindowPovijestUlova";
            this.Text = "Povijest ulova";
            this.Load += new System.EventHandler(this.WindowPovijestUlova_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUlov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulovBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStavkeUlov)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRibe)).EndInit();
            this.metroTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgUlov;
        private System.Windows.Forms.DataGridView dgStavkeUlov;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroComboBox ComboBoxKapBroda;
        private System.Windows.Forms.BindingSource ulovBindingSource;
        private MetroFramework.Controls.MetroDateTime DateTimePocDatum;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroDateTime DateTimeKrajDatum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRibe;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MetroFramework.Controls.MetroButton metroButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDBrodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pocetakvrijemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn krajvrijemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKBrodaDataGridViewTextBoxColumn;
    }
}