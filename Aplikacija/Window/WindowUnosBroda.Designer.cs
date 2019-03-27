namespace Aplikacija
{
    partial class WindowUnosBroda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowUnosBroda));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.TextBoxImeBroda = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxRegOznaka = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.ButtonDodajBrod = new MetroFramework.Controls.MetroButton();
            this.ComboBoxVrstaBroda = new System.Windows.Forms.ComboBox();
            this.dgBrodovi = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.regOznakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brodPresenterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgBrodovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brodPresenterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(23, 71);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(94, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Ime broda:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(233, 71);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(104, 25);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Vrsta broda:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(23, 130);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(180, 25);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Registracijska oznaka: ";
            // 
            // TextBoxImeBroda
            // 
            // 
            // 
            // 
            this.TextBoxImeBroda.CustomButton.Image = null;
            this.TextBoxImeBroda.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.TextBoxImeBroda.CustomButton.Name = "";
            this.TextBoxImeBroda.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBoxImeBroda.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxImeBroda.CustomButton.TabIndex = 1;
            this.TextBoxImeBroda.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxImeBroda.CustomButton.UseSelectable = true;
            this.TextBoxImeBroda.CustomButton.Visible = false;
            this.TextBoxImeBroda.Lines = new string[0];
            this.TextBoxImeBroda.Location = new System.Drawing.Point(132, 71);
            this.TextBoxImeBroda.MaxLength = 32767;
            this.TextBoxImeBroda.Name = "TextBoxImeBroda";
            this.TextBoxImeBroda.PasswordChar = '\0';
            this.TextBoxImeBroda.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxImeBroda.SelectedText = "";
            this.TextBoxImeBroda.SelectionLength = 0;
            this.TextBoxImeBroda.SelectionStart = 0;
            this.TextBoxImeBroda.ShortcutsEnabled = true;
            this.TextBoxImeBroda.Size = new System.Drawing.Size(75, 23);
            this.TextBoxImeBroda.TabIndex = 5;
            this.TextBoxImeBroda.UseSelectable = true;
            this.TextBoxImeBroda.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxImeBroda.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxImeBroda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxImeBroda_KeyPress);
            // 
            // TextBoxRegOznaka
            // 
            // 
            // 
            // 
            this.TextBoxRegOznaka.CustomButton.Image = null;
            this.TextBoxRegOznaka.CustomButton.Location = new System.Drawing.Point(57, 1);
            this.TextBoxRegOznaka.CustomButton.Name = "";
            this.TextBoxRegOznaka.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBoxRegOznaka.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxRegOznaka.CustomButton.TabIndex = 1;
            this.TextBoxRegOznaka.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxRegOznaka.CustomButton.UseSelectable = true;
            this.TextBoxRegOznaka.CustomButton.Visible = false;
            this.TextBoxRegOznaka.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBoxRegOznaka.Lines = new string[0];
            this.TextBoxRegOznaka.Location = new System.Drawing.Point(209, 132);
            this.TextBoxRegOznaka.MaxLength = 32767;
            this.TextBoxRegOznaka.Name = "TextBoxRegOznaka";
            this.TextBoxRegOznaka.PasswordChar = '\0';
            this.TextBoxRegOznaka.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxRegOznaka.SelectedText = "";
            this.TextBoxRegOznaka.SelectionLength = 0;
            this.TextBoxRegOznaka.SelectionStart = 0;
            this.TextBoxRegOznaka.ShortcutsEnabled = true;
            this.TextBoxRegOznaka.Size = new System.Drawing.Size(79, 23);
            this.TextBoxRegOznaka.TabIndex = 7;
            this.TextBoxRegOznaka.UseCustomForeColor = true;
            this.TextBoxRegOznaka.UseSelectable = true;
            this.TextBoxRegOznaka.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxRegOznaka.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxRegOznaka.Click += new System.EventHandler(this.TextBoxRegOznaka_Click);
            this.TextBoxRegOznaka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxRegOznaka_KeyPress);
            this.TextBoxRegOznaka.Leave += new System.EventHandler(this.TextBoxRegOznaka_Leave);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(23, 365);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(95, 36);
            this.metroButton1.TabIndex = 9;
            this.metroButton1.Text = "Natrag";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // ButtonDodajBrod
            // 
            this.ButtonDodajBrod.Location = new System.Drawing.Point(116, 193);
            this.ButtonDodajBrod.Name = "ButtonDodajBrod";
            this.ButtonDodajBrod.Size = new System.Drawing.Size(91, 38);
            this.ButtonDodajBrod.TabIndex = 10;
            this.ButtonDodajBrod.Text = "Dodaj";
            this.ButtonDodajBrod.UseSelectable = true;
            this.ButtonDodajBrod.Click += new System.EventHandler(this.ButtonDodajBrod_Click);
            // 
            // ComboBoxVrstaBroda
            // 
            this.ComboBoxVrstaBroda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxVrstaBroda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ComboBoxVrstaBroda.FormattingEnabled = true;
            this.ComboBoxVrstaBroda.Items.AddRange(new object[] {
            "--odaberi vrstu--",
            "Kočar",
            "Stajačičar",
            "Potezačar",
            "Plivaričar",
            "Kitolovac"});
            this.ComboBoxVrstaBroda.Location = new System.Drawing.Point(343, 71);
            this.ComboBoxVrstaBroda.Name = "ComboBoxVrstaBroda";
            this.ComboBoxVrstaBroda.Size = new System.Drawing.Size(127, 26);
            this.ComboBoxVrstaBroda.TabIndex = 12;
            this.ComboBoxVrstaBroda.SelectedIndexChanged += new System.EventHandler(this.ComboBoxVrstaBroda_SelectedIndexChanged);
            // 
            // dgBrodovi
            // 
            this.dgBrodovi.AllowUserToAddRows = false;
            this.dgBrodovi.AllowUserToDeleteRows = false;
            this.dgBrodovi.AutoGenerateColumns = false;
            this.dgBrodovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBrodovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.regOznakaDataGridViewTextBoxColumn,
            this.vrstaDataGridViewTextBoxColumn});
            this.dgBrodovi.DataSource = this.brodPresenterBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgBrodovi.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgBrodovi.Location = new System.Drawing.Point(343, 165);
            this.dgBrodovi.Name = "dgBrodovi";
            this.dgBrodovi.ReadOnly = true;
            this.dgBrodovi.Size = new System.Drawing.Size(416, 236);
            this.dgBrodovi.TabIndex = 13;
            this.dgBrodovi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBrodovi_CellClick);
            this.dgBrodovi.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgBrodovi_RowsAdded);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            this.imeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.imeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // regOznakaDataGridViewTextBoxColumn
            // 
            this.regOznakaDataGridViewTextBoxColumn.DataPropertyName = "Reg_Oznaka";
            this.regOznakaDataGridViewTextBoxColumn.HeaderText = "Reg. oznaka";
            this.regOznakaDataGridViewTextBoxColumn.Name = "regOznakaDataGridViewTextBoxColumn";
            this.regOznakaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vrstaDataGridViewTextBoxColumn
            // 
            this.vrstaDataGridViewTextBoxColumn.DataPropertyName = "Vrsta";
            this.vrstaDataGridViewTextBoxColumn.HeaderText = "Vrsta";
            this.vrstaDataGridViewTextBoxColumn.Name = "vrstaDataGridViewTextBoxColumn";
            this.vrstaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brodPresenterBindingSource
            // 
            this.brodPresenterBindingSource.DataSource = typeof(Aplikacija.BrodPresenter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(490, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Lista brodova:";
            // 
            // WindowUnosBroda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgBrodovi);
            this.Controls.Add(this.ComboBoxVrstaBroda);
            this.Controls.Add(this.ButtonDodajBrod);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.TextBoxRegOznaka);
            this.Controls.Add(this.TextBoxImeBroda);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WindowUnosBroda";
            this.Text = "Unos broda";
            this.Load += new System.EventHandler(this.WindowUnosBroda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBrodovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brodPresenterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox TextBoxImeBroda;
        private MetroFramework.Controls.MetroTextBox TextBoxRegOznaka;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton ButtonDodajBrod;
        private System.Windows.Forms.ComboBox ComboBoxVrstaBroda;
        private System.Windows.Forms.DataGridView dgBrodovi;
        private System.Windows.Forms.BindingSource brodPresenterBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regOznakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstaDataGridViewTextBoxColumn;
    }
}