namespace Aplikacija
{
    partial class WindowUnosRadnika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowUnosRadnika));
            this.ButtonDodajradnika = new MetroFramework.Controls.MetroButton();
            this.buttonNatrag = new MetroFramework.Controls.MetroButton();
            this.labelIme = new MetroFramework.Controls.MetroLabel();
            this.labelPrezime = new MetroFramework.Controls.MetroLabel();
            this.labelOib = new MetroFramework.Controls.MetroLabel();
            this.labelBrod = new MetroFramework.Controls.MetroLabel();
            this.TextBoxIme = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxPrezime = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxOib = new MetroFramework.Controls.MetroTextBox();
            this.ComboBoxBrod = new MetroFramework.Controls.MetroComboBox();
            this.dgRadnici = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.radnikPresenterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeBrodaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgRadnici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radnikPresenterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonDodajradnika
            // 
            this.ButtonDodajradnika.Location = new System.Drawing.Point(88, 259);
            this.ButtonDodajradnika.Name = "ButtonDodajradnika";
            this.ButtonDodajradnika.Size = new System.Drawing.Size(104, 41);
            this.ButtonDodajradnika.TabIndex = 0;
            this.ButtonDodajradnika.Text = "Dodaj radnika";
            this.ButtonDodajradnika.UseSelectable = true;
            this.ButtonDodajradnika.Click += new System.EventHandler(this.ButtonDodajradnika_Click);
            // 
            // buttonNatrag
            // 
            this.buttonNatrag.Location = new System.Drawing.Point(41, 381);
            this.buttonNatrag.Name = "buttonNatrag";
            this.buttonNatrag.Size = new System.Drawing.Size(104, 41);
            this.buttonNatrag.TabIndex = 1;
            this.buttonNatrag.Text = "Natrag";
            this.buttonNatrag.UseSelectable = true;
            this.buttonNatrag.Click += new System.EventHandler(this.buttonNatrag_Click);
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Location = new System.Drawing.Point(40, 73);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(34, 19);
            this.labelIme.TabIndex = 2;
            this.labelIme.Text = "Ime:";
            // 
            // labelPrezime
            // 
            this.labelPrezime.AutoSize = true;
            this.labelPrezime.Location = new System.Drawing.Point(40, 116);
            this.labelPrezime.Name = "labelPrezime";
            this.labelPrezime.Size = new System.Drawing.Size(60, 19);
            this.labelPrezime.TabIndex = 3;
            this.labelPrezime.Text = "Prezime:";
            // 
            // labelOib
            // 
            this.labelOib.AutoSize = true;
            this.labelOib.Location = new System.Drawing.Point(40, 161);
            this.labelOib.Name = "labelOib";
            this.labelOib.Size = new System.Drawing.Size(34, 19);
            this.labelOib.TabIndex = 4;
            this.labelOib.Text = "OIB:";
            // 
            // labelBrod
            // 
            this.labelBrod.AutoSize = true;
            this.labelBrod.Location = new System.Drawing.Point(40, 205);
            this.labelBrod.Name = "labelBrod";
            this.labelBrod.Size = new System.Drawing.Size(41, 19);
            this.labelBrod.TabIndex = 5;
            this.labelBrod.Text = "Brod:";
            // 
            // TextBoxIme
            // 
            // 
            // 
            // 
            this.TextBoxIme.CustomButton.Image = null;
            this.TextBoxIme.CustomButton.Location = new System.Drawing.Point(68, 1);
            this.TextBoxIme.CustomButton.Name = "";
            this.TextBoxIme.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBoxIme.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxIme.CustomButton.TabIndex = 1;
            this.TextBoxIme.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxIme.CustomButton.UseSelectable = true;
            this.TextBoxIme.CustomButton.Visible = false;
            this.TextBoxIme.Lines = new string[0];
            this.TextBoxIme.Location = new System.Drawing.Point(136, 73);
            this.TextBoxIme.MaxLength = 32767;
            this.TextBoxIme.Name = "TextBoxIme";
            this.TextBoxIme.PasswordChar = '\0';
            this.TextBoxIme.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxIme.SelectedText = "";
            this.TextBoxIme.SelectionLength = 0;
            this.TextBoxIme.SelectionStart = 0;
            this.TextBoxIme.ShortcutsEnabled = true;
            this.TextBoxIme.Size = new System.Drawing.Size(90, 23);
            this.TextBoxIme.TabIndex = 7;
            this.TextBoxIme.UseSelectable = true;
            this.TextBoxIme.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxIme.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxIme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxIme_KeyPress);
            // 
            // TextBoxPrezime
            // 
            // 
            // 
            // 
            this.TextBoxPrezime.CustomButton.Image = null;
            this.TextBoxPrezime.CustomButton.Location = new System.Drawing.Point(68, 1);
            this.TextBoxPrezime.CustomButton.Name = "";
            this.TextBoxPrezime.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBoxPrezime.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxPrezime.CustomButton.TabIndex = 1;
            this.TextBoxPrezime.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxPrezime.CustomButton.UseSelectable = true;
            this.TextBoxPrezime.CustomButton.Visible = false;
            this.TextBoxPrezime.Lines = new string[0];
            this.TextBoxPrezime.Location = new System.Drawing.Point(136, 112);
            this.TextBoxPrezime.MaxLength = 32767;
            this.TextBoxPrezime.Name = "TextBoxPrezime";
            this.TextBoxPrezime.PasswordChar = '\0';
            this.TextBoxPrezime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxPrezime.SelectedText = "";
            this.TextBoxPrezime.SelectionLength = 0;
            this.TextBoxPrezime.SelectionStart = 0;
            this.TextBoxPrezime.ShortcutsEnabled = true;
            this.TextBoxPrezime.Size = new System.Drawing.Size(90, 23);
            this.TextBoxPrezime.TabIndex = 8;
            this.TextBoxPrezime.UseSelectable = true;
            this.TextBoxPrezime.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxPrezime.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxPrezime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPrezime_KeyPress);
            // 
            // TextBoxOib
            // 
            // 
            // 
            // 
            this.TextBoxOib.CustomButton.Image = null;
            this.TextBoxOib.CustomButton.Location = new System.Drawing.Point(68, 1);
            this.TextBoxOib.CustomButton.Name = "";
            this.TextBoxOib.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBoxOib.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxOib.CustomButton.TabIndex = 1;
            this.TextBoxOib.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxOib.CustomButton.UseSelectable = true;
            this.TextBoxOib.CustomButton.Visible = false;
            this.TextBoxOib.Lines = new string[0];
            this.TextBoxOib.Location = new System.Drawing.Point(136, 157);
            this.TextBoxOib.MaxLength = 11;
            this.TextBoxOib.Name = "TextBoxOib";
            this.TextBoxOib.PasswordChar = '\0';
            this.TextBoxOib.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxOib.SelectedText = "";
            this.TextBoxOib.SelectionLength = 0;
            this.TextBoxOib.SelectionStart = 0;
            this.TextBoxOib.ShortcutsEnabled = true;
            this.TextBoxOib.Size = new System.Drawing.Size(90, 23);
            this.TextBoxOib.TabIndex = 9;
            this.TextBoxOib.UseSelectable = true;
            this.TextBoxOib.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxOib.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxOib.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxOib_KeyPress);
            this.TextBoxOib.Leave += new System.EventHandler(this.TextBoxOib_Leave);
            // 
            // ComboBoxBrod
            // 
            this.ComboBoxBrod.FormattingEnabled = true;
            this.ComboBoxBrod.ItemHeight = 23;
            this.ComboBoxBrod.Items.AddRange(new object[] {
            "--odaberi brod--"});
            this.ComboBoxBrod.Location = new System.Drawing.Point(136, 202);
            this.ComboBoxBrod.Name = "ComboBoxBrod";
            this.ComboBoxBrod.Size = new System.Drawing.Size(128, 29);
            this.ComboBoxBrod.TabIndex = 10;
            this.ComboBoxBrod.UseSelectable = true;
            this.ComboBoxBrod.SelectedIndexChanged += new System.EventHandler(this.ComboBoxBrod_SelectedIndexChanged);
            // 
            // dgRadnici
            // 
            this.dgRadnici.AllowUserToAddRows = false;
            this.dgRadnici.AllowUserToDeleteRows = false;
            this.dgRadnici.AutoGenerateColumns = false;
            this.dgRadnici.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgRadnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRadnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.imeBrodaDataGridViewTextBoxColumn});
            this.dgRadnici.DataSource = this.radnikPresenterBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgRadnici.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgRadnici.Location = new System.Drawing.Point(334, 150);
            this.dgRadnici.Name = "dgRadnici";
            this.dgRadnici.ReadOnly = true;
            this.dgRadnici.Size = new System.Drawing.Size(430, 272);
            this.dgRadnici.TabIndex = 11;
            this.dgRadnici.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRadnici_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(499, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Lista radnika:";
            // 
            // radnikPresenterBindingSource
            // 
            this.radnikPresenterBindingSource.DataSource = typeof(Aplikacija.RadnikPresenter);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imeBrodaDataGridViewTextBoxColumn
            // 
            this.imeBrodaDataGridViewTextBoxColumn.DataPropertyName = "Ime_Broda";
            this.imeBrodaDataGridViewTextBoxColumn.HeaderText = "Ime broda";
            this.imeBrodaDataGridViewTextBoxColumn.Name = "imeBrodaDataGridViewTextBoxColumn";
            this.imeBrodaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // WindowUnosRadnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgRadnici);
            this.Controls.Add(this.ComboBoxBrod);
            this.Controls.Add(this.TextBoxOib);
            this.Controls.Add(this.TextBoxPrezime);
            this.Controls.Add(this.TextBoxIme);
            this.Controls.Add(this.labelBrod);
            this.Controls.Add(this.labelOib);
            this.Controls.Add(this.labelPrezime);
            this.Controls.Add(this.labelIme);
            this.Controls.Add(this.buttonNatrag);
            this.Controls.Add(this.ButtonDodajradnika);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WindowUnosRadnika";
            this.Text = "Unos radnika";
            this.Load += new System.EventHandler(this.WindowUnosRadnika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRadnici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radnikPresenterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton ButtonDodajradnika;
        private MetroFramework.Controls.MetroButton buttonNatrag;
        private MetroFramework.Controls.MetroLabel labelIme;
        private MetroFramework.Controls.MetroLabel labelPrezime;
        private MetroFramework.Controls.MetroLabel labelOib;
        private MetroFramework.Controls.MetroLabel labelBrod;
        private MetroFramework.Controls.MetroTextBox TextBoxIme;
        private MetroFramework.Controls.MetroTextBox TextBoxPrezime;
        private MetroFramework.Controls.MetroTextBox TextBoxOib;
        private MetroFramework.Controls.MetroComboBox ComboBoxBrod;
        private System.Windows.Forms.DataGridView dgRadnici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeBrodaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource radnikPresenterBindingSource;
    }
}