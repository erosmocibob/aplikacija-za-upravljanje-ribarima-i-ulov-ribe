namespace Aplikacija
{
    partial class WindowUnosUlova
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowUnosUlova));
            this.Datumulova = new MetroFramework.Controls.MetroDateTime();
            this.Natrag = new MetroFramework.Controls.MetroButton();
            this.ButtonSpremiUlov = new MetroFramework.Controls.MetroButton();
            this.PocetakUlova = new System.Windows.Forms.DateTimePicker();
            this.PocetakUlovaLabel = new MetroFramework.Controls.MetroLabel();
            this.KrajUlovaLabel = new MetroFramework.Controls.MetroLabel();
            this.krajUlova = new System.Windows.Forms.DateTimePicker();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonDodajribu = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.ComboBoxRibe = new System.Windows.Forms.ComboBox();
            this.numericUpDownKilaza = new System.Windows.Forms.NumericUpDown();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dgRibe = new System.Windows.Forms.DataGridView();
            this.nazivDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkaPresenterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonDanMinus = new MetroFramework.Controls.MetroButton();
            this.buttonPlusDan = new MetroFramework.Controls.MetroButton();
            this.labeldDole = new System.Windows.Forms.Label();
            this.labelDesno = new System.Windows.Forms.Label();
            this.labelLijevo = new System.Windows.Forms.Label();
            this.labelGore = new System.Windows.Forms.Label();
            this.comboBoxBrod = new System.Windows.Forms.ComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKilaza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRibe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaPresenterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Datumulova
            // 
            this.Datumulova.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Datumulova.Location = new System.Drawing.Point(411, 88);
            this.Datumulova.MinimumSize = new System.Drawing.Size(0, 29);
            this.Datumulova.Name = "Datumulova";
            this.Datumulova.Size = new System.Drawing.Size(212, 29);
            this.Datumulova.TabIndex = 4;
            this.Datumulova.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Datumulova.ValueChanged += new System.EventHandler(this.Datumulova_ValueChanged);
            // 
            // Natrag
            // 
            this.Natrag.Location = new System.Drawing.Point(50, 373);
            this.Natrag.Name = "Natrag";
            this.Natrag.Size = new System.Drawing.Size(104, 35);
            this.Natrag.TabIndex = 6;
            this.Natrag.Text = "Natrag";
            this.Natrag.UseSelectable = true;
            this.Natrag.Click += new System.EventHandler(this.Natrag_Click);
            // 
            // ButtonSpremiUlov
            // 
            this.ButtonSpremiUlov.Location = new System.Drawing.Point(206, 373);
            this.ButtonSpremiUlov.Name = "ButtonSpremiUlov";
            this.ButtonSpremiUlov.Size = new System.Drawing.Size(102, 35);
            this.ButtonSpremiUlov.TabIndex = 7;
            this.ButtonSpremiUlov.Text = "Spremi ulov";
            this.ButtonSpremiUlov.UseSelectable = true;
            this.ButtonSpremiUlov.Click += new System.EventHandler(this.ButtonSpremiUlov_Click);
            // 
            // PocetakUlova
            // 
            this.PocetakUlova.CustomFormat = "H:mm";
            this.PocetakUlova.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PocetakUlova.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.PocetakUlova.Location = new System.Drawing.Point(143, 92);
            this.PocetakUlova.Name = "PocetakUlova";
            this.PocetakUlova.ShowUpDown = true;
            this.PocetakUlova.Size = new System.Drawing.Size(74, 24);
            this.PocetakUlova.TabIndex = 8;
            // 
            // PocetakUlovaLabel
            // 
            this.PocetakUlovaLabel.AutoSize = true;
            this.PocetakUlovaLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.PocetakUlovaLabel.Location = new System.Drawing.Point(11, 88);
            this.PocetakUlovaLabel.Name = "PocetakUlovaLabel";
            this.PocetakUlovaLabel.Size = new System.Drawing.Size(126, 25);
            this.PocetakUlovaLabel.TabIndex = 9;
            this.PocetakUlovaLabel.Text = "Početak ulova: ";
            // 
            // KrajUlovaLabel
            // 
            this.KrajUlovaLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.KrajUlovaLabel.Location = new System.Drawing.Point(11, 136);
            this.KrajUlovaLabel.Name = "KrajUlovaLabel";
            this.KrajUlovaLabel.Size = new System.Drawing.Size(113, 30);
            this.KrajUlovaLabel.TabIndex = 10;
            this.KrajUlovaLabel.Text = "Kraj ulova:";
            // 
            // krajUlova
            // 
            this.krajUlova.CustomFormat = "H:mm";
            this.krajUlova.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.krajUlova.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.krajUlova.Location = new System.Drawing.Point(143, 142);
            this.krajUlova.Name = "krajUlova";
            this.krajUlova.ShowUpDown = true;
            this.krajUlova.Size = new System.Drawing.Size(74, 24);
            this.krajUlova.TabIndex = 11;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazivDataGridViewTextBoxColumn.Width = 150;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.kolicinaDataGridViewTextBoxColumn.Width = 70;
            // 
            // ButtonDodajribu
            // 
            this.ButtonDodajribu.Location = new System.Drawing.Point(206, 255);
            this.ButtonDodajribu.Name = "ButtonDodajribu";
            this.ButtonDodajribu.Size = new System.Drawing.Size(94, 31);
            this.ButtonDodajribu.TabIndex = 14;
            this.ButtonDodajribu.Text = "Dodaj ";
            this.ButtonDodajribu.UseSelectable = true;
            this.ButtonDodajribu.Click += new System.EventHandler(this.ButtonDodajribu_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(453, 66);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(91, 19);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "Datum ulova:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(18, 183);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(118, 25);
            this.metroLabel2.TabIndex = 20;
            this.metroLabel2.Text = "Odaberi ribu: ";
            // 
            // ComboBoxRibe
            // 
            this.ComboBoxRibe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.ComboBoxRibe.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxRibe.DropDownHeight = 107;
            this.ComboBoxRibe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ComboBoxRibe.FormattingEnabled = true;
            this.ComboBoxRibe.IntegralHeight = false;
            this.ComboBoxRibe.Location = new System.Drawing.Point(23, 212);
            this.ComboBoxRibe.Name = "ComboBoxRibe";
            this.ComboBoxRibe.Size = new System.Drawing.Size(146, 24);
            this.ComboBoxRibe.TabIndex = 22;
            this.ComboBoxRibe.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ComboBoxRibe_MouseClick);
            // 
            // numericUpDownKilaza
            // 
            this.numericUpDownKilaza.DecimalPlaces = 2;
            this.numericUpDownKilaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownKilaza.Location = new System.Drawing.Point(213, 212);
            this.numericUpDownKilaza.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownKilaza.Name = "numericUpDownKilaza";
            this.numericUpDownKilaza.Size = new System.Drawing.Size(77, 24);
            this.numericUpDownKilaza.TabIndex = 27;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(213, 183);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(59, 25);
            this.metroLabel3.TabIndex = 26;
            this.metroLabel3.Text = "Kilaža:";
            // 
            // dgRibe
            // 
            this.dgRibe.AllowUserToAddRows = false;
            this.dgRibe.AllowUserToDeleteRows = false;
            this.dgRibe.AutoGenerateColumns = false;
            this.dgRibe.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRibe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgRibe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRibe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazivDataGridViewTextBoxColumn1,
            this.kolicinaDataGridViewTextBoxColumn1});
            this.dgRibe.DataSource = this.stavkaPresenterBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgRibe.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgRibe.Location = new System.Drawing.Point(411, 183);
            this.dgRibe.Name = "dgRibe";
            this.dgRibe.ReadOnly = true;
            this.dgRibe.Size = new System.Drawing.Size(332, 189);
            this.dgRibe.TabIndex = 30;
            this.dgRibe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRibe_CellClick_1);
            // 
            // nazivDataGridViewTextBoxColumn1
            // 
            this.nazivDataGridViewTextBoxColumn1.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn1.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn1.Name = "nazivDataGridViewTextBoxColumn1";
            this.nazivDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nazivDataGridViewTextBoxColumn1.Width = 120;
            // 
            // kolicinaDataGridViewTextBoxColumn1
            // 
            this.kolicinaDataGridViewTextBoxColumn1.DataPropertyName = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn1.HeaderText = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn1.Name = "kolicinaDataGridViewTextBoxColumn1";
            this.kolicinaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // stavkaPresenterBindingSource
            // 
            this.stavkaPresenterBindingSource.DataSource = typeof(Aplikacija.StavkaPresenter);
            // 
            // buttonDanMinus
            // 
            this.buttonDanMinus.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonDanMinus.BackgroundImage = global::Aplikacija.Properties.Resources._1danminus;
            this.buttonDanMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDanMinus.Location = new System.Drawing.Point(643, 112);
            this.buttonDanMinus.Name = "buttonDanMinus";
            this.buttonDanMinus.Size = new System.Drawing.Size(46, 39);
            this.buttonDanMinus.TabIndex = 31;
            this.buttonDanMinus.UseCustomBackColor = true;
            this.buttonDanMinus.UseCustomForeColor = true;
            this.buttonDanMinus.UseSelectable = true;
            this.buttonDanMinus.Click += new System.EventHandler(this.buttonDanMinus_Click);
            // 
            // buttonPlusDan
            // 
            this.buttonPlusDan.BackColor = System.Drawing.Color.Red;
            this.buttonPlusDan.BackgroundImage = global::Aplikacija.Properties.Resources._1danplus;
            this.buttonPlusDan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonPlusDan.Location = new System.Drawing.Point(643, 63);
            this.buttonPlusDan.Name = "buttonPlusDan";
            this.buttonPlusDan.Size = new System.Drawing.Size(45, 39);
            this.buttonPlusDan.TabIndex = 29;
            this.buttonPlusDan.UseCustomBackColor = true;
            this.buttonPlusDan.UseSelectable = true;
            this.buttonPlusDan.UseStyleColors = true;
            this.buttonPlusDan.Click += new System.EventHandler(this.buttonPlusDan_Click);
            // 
            // labeldDole
            // 
            this.labeldDole.BackColor = System.Drawing.Color.Transparent;
            this.labeldDole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labeldDole.ForeColor = System.Drawing.Color.Transparent;
            this.labeldDole.Location = new System.Drawing.Point(11, 299);
            this.labeldDole.Name = "labeldDole";
            this.labeldDole.Size = new System.Drawing.Size(308, 2);
            this.labeldDole.TabIndex = 32;
            // 
            // labelDesno
            // 
            this.labelDesno.BackColor = System.Drawing.Color.Transparent;
            this.labelDesno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDesno.ForeColor = System.Drawing.Color.Transparent;
            this.labelDesno.Location = new System.Drawing.Point(317, 179);
            this.labelDesno.Name = "labelDesno";
            this.labelDesno.Size = new System.Drawing.Size(2, 122);
            this.labelDesno.TabIndex = 34;
            // 
            // labelLijevo
            // 
            this.labelLijevo.BackColor = System.Drawing.Color.Transparent;
            this.labelLijevo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLijevo.ForeColor = System.Drawing.Color.Transparent;
            this.labelLijevo.Location = new System.Drawing.Point(11, 179);
            this.labelLijevo.Name = "labelLijevo";
            this.labelLijevo.Size = new System.Drawing.Size(2, 122);
            this.labelLijevo.TabIndex = 35;
            // 
            // labelGore
            // 
            this.labelGore.BackColor = System.Drawing.Color.Transparent;
            this.labelGore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGore.ForeColor = System.Drawing.Color.Transparent;
            this.labelGore.Location = new System.Drawing.Point(11, 179);
            this.labelGore.Name = "labelGore";
            this.labelGore.Size = new System.Drawing.Size(308, 2);
            this.labelGore.TabIndex = 36;
            // 
            // comboBoxBrod
            // 
            this.comboBoxBrod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxBrod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxBrod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxBrod.FormattingEnabled = true;
            this.comboBoxBrod.Location = new System.Drawing.Point(255, 92);
            this.comboBoxBrod.MaxDropDownItems = 5;
            this.comboBoxBrod.Name = "comboBoxBrod";
            this.comboBoxBrod.Size = new System.Drawing.Size(121, 24);
            this.comboBoxBrod.TabIndex = 37;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(285, 66);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(52, 25);
            this.metroLabel4.TabIndex = 38;
            this.metroLabel4.Text = "Brod:";
            // 
            // WindowUnosUlova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.comboBoxBrod);
            this.Controls.Add(this.labelGore);
            this.Controls.Add(this.labelLijevo);
            this.Controls.Add(this.labelDesno);
            this.Controls.Add(this.labeldDole);
            this.Controls.Add(this.buttonDanMinus);
            this.Controls.Add(this.dgRibe);
            this.Controls.Add(this.buttonPlusDan);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.numericUpDownKilaza);
            this.Controls.Add(this.ComboBoxRibe);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.ButtonDodajribu);
            this.Controls.Add(this.krajUlova);
            this.Controls.Add(this.KrajUlovaLabel);
            this.Controls.Add(this.PocetakUlovaLabel);
            this.Controls.Add(this.PocetakUlova);
            this.Controls.Add(this.ButtonSpremiUlov);
            this.Controls.Add(this.Natrag);
            this.Controls.Add(this.Datumulova);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WindowUnosUlova";
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Unos ulova";
            this.Load += new System.EventHandler(this.WindowUnosUlova_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKilaza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRibe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaPresenterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroDateTime Datumulova;
        private MetroFramework.Controls.MetroButton Natrag;
        private MetroFramework.Controls.MetroButton ButtonSpremiUlov;
        private System.Windows.Forms.DateTimePicker PocetakUlova;
        private MetroFramework.Controls.MetroLabel PocetakUlovaLabel;
        private MetroFramework.Controls.MetroLabel KrajUlovaLabel;
        private System.Windows.Forms.DateTimePicker krajUlova;
        private MetroFramework.Controls.MetroButton ButtonDodajribu;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ComboBox ComboBoxRibe;
        private System.Windows.Forms.NumericUpDown numericUpDownKilaza;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroButton buttonPlusDan;
        private System.Windows.Forms.DataGridView dgRibe;
        private System.Windows.Forms.BindingSource stavkaPresenterBindingSource;
        private MetroFramework.Controls.MetroButton buttonDanMinus;
        private System.Windows.Forms.Label labeldDole;
        private System.Windows.Forms.Label labelDesno;
        private System.Windows.Forms.Label labelLijevo;
        private System.Windows.Forms.Label labelGore;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.ComboBox comboBoxBrod;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}