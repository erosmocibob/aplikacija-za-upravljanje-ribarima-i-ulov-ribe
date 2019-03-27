namespace Aplikacija
{
    partial class WindowPovijestUlovaRadnika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowPovijestUlovaRadnika));
            this.dgUlov = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pocetakvrijemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.krajvrijemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgStavkaUlov = new System.Windows.Forms.DataGridView();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.chartRibe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ulovListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.DateTimeKrajDatum = new MetroFramework.Controls.MetroDateTime();
            this.DateTimePocDatum = new MetroFramework.Controls.MetroDateTime();
            this.label1 = new System.Windows.Forms.Label();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.stavkaPresenterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgUlov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulovBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStavkaUlov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRibe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulovListBindingSource)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaPresenterBindingSource)).BeginInit();
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
            this.datumDataGridViewTextBoxColumn,
            this.pocetakvrijemeDataGridViewTextBoxColumn,
            this.krajvrijemeDataGridViewTextBoxColumn});
            this.dgUlov.DataSource = this.ulovBindingSource;
            this.dgUlov.Location = new System.Drawing.Point(3, 3);
            this.dgUlov.Name = "dgUlov";
            this.dgUlov.ReadOnly = true;
            this.dgUlov.Size = new System.Drawing.Size(435, 150);
            this.dgUlov.TabIndex = 0;
            this.dgUlov.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUlov_CellClick);
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
            this.pocetakvrijemeDataGridViewTextBoxColumn.HeaderText = "Početak vrijeme";
            this.pocetakvrijemeDataGridViewTextBoxColumn.Name = "pocetakvrijemeDataGridViewTextBoxColumn";
            this.pocetakvrijemeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // krajvrijemeDataGridViewTextBoxColumn
            // 
            this.krajvrijemeDataGridViewTextBoxColumn.DataPropertyName = "Kraj_vrijeme";
            this.krajvrijemeDataGridViewTextBoxColumn.HeaderText = "Kraj vrijeme";
            this.krajvrijemeDataGridViewTextBoxColumn.Name = "krajvrijemeDataGridViewTextBoxColumn";
            this.krajvrijemeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ulovBindingSource
            // 
            this.ulovBindingSource.DataSource = typeof(Aplikacija.Ulov);
            // 
            // dgStavkaUlov
            // 
            this.dgStavkaUlov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStavkaUlov.Location = new System.Drawing.Point(3, 183);
            this.dgStavkaUlov.Name = "dgStavkaUlov";
            this.dgStavkaUlov.Size = new System.Drawing.Size(338, 136);
            this.dgStavkaUlov.TabIndex = 1;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(637, 17);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(83, 33);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Natrag";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // chartRibe
            // 
            this.chartRibe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 0;
            chartArea1.Name = "ChartArea1";
            this.chartRibe.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            legend1.IsEquallySpacedItems = true;
            legend1.IsTextAutoFit = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend1.Name = "Legend1";
            this.chartRibe.Legends.Add(legend1);
            this.chartRibe.Location = new System.Drawing.Point(15, -9);
            this.chartRibe.Name = "chartRibe";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Kilaža";
            this.chartRibe.Series.Add(series1);
            this.chartRibe.Size = new System.Drawing.Size(688, 355);
            this.chartRibe.TabIndex = 3;
            this.chartRibe.Text = "chartRibe";
            title1.Alignment = System.Drawing.ContentAlignment.BottomCenter;
            title1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Left;
            title1.DockedToChartArea = "ChartArea1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            title1.IsDockedInsideChartArea = false;
            title1.Name = "Title1";
            title1.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            this.chartRibe.Titles.Add(title1);
            // 
            // ulovListBindingSource
            // 
            this.ulovListBindingSource.DataMember = "UlovList";
            this.ulovListBindingSource.DataSource = this.ulovBindingSource;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.metroTabControl1.Location = new System.Drawing.Point(23, 56);
            this.metroTabControl1.Multiline = true;
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(713, 388);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroButton2);
            this.metroTabPage1.Controls.Add(this.DateTimeKrajDatum);
            this.metroTabPage1.Controls.Add(this.DateTimePocDatum);
            this.metroTabPage1.Controls.Add(this.label1);
            this.metroTabPage1.Controls.Add(this.dgUlov);
            this.metroTabPage1.Controls.Add(this.dgStavkaUlov);
            this.metroTabPage1.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(705, 346);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Tablica";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(556, 188);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(106, 37);
            this.metroButton2.TabIndex = 5;
            this.metroButton2.Text = "Generiraj";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // DateTimeKrajDatum
            // 
            this.DateTimeKrajDatum.Location = new System.Drawing.Point(497, 120);
            this.DateTimeKrajDatum.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateTimeKrajDatum.Name = "DateTimeKrajDatum";
            this.DateTimeKrajDatum.Size = new System.Drawing.Size(200, 29);
            this.DateTimeKrajDatum.TabIndex = 4;
            // 
            // DateTimePocDatum
            // 
            this.DateTimePocDatum.Location = new System.Drawing.Point(497, 52);
            this.DateTimePocDatum.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateTimePocDatum.Name = "DateTimePocDatum";
            this.DateTimePocDatum.Size = new System.Drawing.Size(200, 29);
            this.DateTimePocDatum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(521, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Odaberi datum od i do";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.chartRibe);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Margin = new System.Windows.Forms.Padding(3, 3, 4, 3);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(705, 346);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Graf stavke ulova";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.chart1);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(705, 346);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Graf ukupan ulov";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
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
            this.chart1.Location = new System.Drawing.Point(-14, 5);
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
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            title2.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title2.Name = "Title1";
            title2.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            this.chart1.Titles.Add(title2);
            // 
            // stavkaPresenterBindingSource
            // 
            this.stavkaPresenterBindingSource.DataSource = typeof(Aplikacija.StavkaPresenter);
            // 
            // WindowPovijestUlovaRadnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.metroButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WindowPovijestUlovaRadnika";
            this.Text = "Povijest Ulova";
            this.Load += new System.EventHandler(this.WindowPovijestUlovaRadnika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUlov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulovBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStavkaUlov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRibe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulovListBindingSource)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaPresenterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgUlov;
        private System.Windows.Forms.DataGridView dgStavkaUlov;
        private System.Windows.Forms.BindingSource ulovBindingSource;
        private System.Windows.Forms.BindingSource stavkaPresenterBindingSource;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pocetakvrijemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn krajvrijemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRibe;
        private System.Windows.Forms.BindingSource ulovListBindingSource;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroDateTime DateTimeKrajDatum;
        private MetroFramework.Controls.MetroDateTime DateTimePocDatum;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}