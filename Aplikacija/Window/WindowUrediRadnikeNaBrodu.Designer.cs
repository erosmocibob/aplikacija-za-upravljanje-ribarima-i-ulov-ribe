namespace Aplikacija
{
    partial class WindowUrediRadnikeNaBrodu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowUrediRadnikeNaBrodu));
            this.dbBrod = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regOznakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brodPresenterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgRandnik = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeBrodaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ukloniRadnika = new System.Windows.Forms.DataGridViewButtonColumn();
            this.radnikPresenterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxRadnik = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dbBrod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brodPresenterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRandnik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radnikPresenterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dbBrod
            // 
            this.dbBrod.AllowUserToAddRows = false;
            this.dbBrod.AllowUserToDeleteRows = false;
            this.dbBrod.AutoGenerateColumns = false;
            this.dbBrod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbBrod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.regOznakaDataGridViewTextBoxColumn,
            this.vrstaDataGridViewTextBoxColumn});
            this.dbBrod.DataSource = this.brodPresenterBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dbBrod.DefaultCellStyle = dataGridViewCellStyle1;
            this.dbBrod.Location = new System.Drawing.Point(36, 63);
            this.dbBrod.Name = "dbBrod";
            this.dbBrod.ReadOnly = true;
            this.dbBrod.Size = new System.Drawing.Size(373, 72);
            this.dbBrod.TabIndex = 0;
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
            // 
            // regOznakaDataGridViewTextBoxColumn
            // 
            this.regOznakaDataGridViewTextBoxColumn.DataPropertyName = "Reg_Oznaka";
            this.regOznakaDataGridViewTextBoxColumn.HeaderText = "Reg. oznaka";
            this.regOznakaDataGridViewTextBoxColumn.Name = "regOznakaDataGridViewTextBoxColumn";
            this.regOznakaDataGridViewTextBoxColumn.ReadOnly = true;
            this.regOznakaDataGridViewTextBoxColumn.Width = 130;
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
            // dgRandnik
            // 
            this.dgRandnik.AllowUserToAddRows = false;
            this.dgRandnik.AllowUserToDeleteRows = false;
            this.dgRandnik.AutoGenerateColumns = false;
            this.dgRandnik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRandnik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.imeDataGridViewTextBoxColumn1,
            this.prezimeDataGridViewTextBoxColumn,
            this.imeBrodaDataGridViewTextBoxColumn,
            this.ukloniRadnika});
            this.dgRandnik.DataSource = this.radnikPresenterBindingSource;
            this.dgRandnik.Location = new System.Drawing.Point(45, 171);
            this.dgRandnik.Name = "dgRandnik";
            this.dgRandnik.ReadOnly = true;
            this.dgRandnik.Size = new System.Drawing.Size(344, 150);
            this.dgRandnik.TabIndex = 1;
            this.dgRandnik.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRandnik_CellClick);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // imeDataGridViewTextBoxColumn1
            // 
            this.imeDataGridViewTextBoxColumn1.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn1.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn1.Name = "imeDataGridViewTextBoxColumn1";
            this.imeDataGridViewTextBoxColumn1.ReadOnly = true;
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
            this.imeBrodaDataGridViewTextBoxColumn.HeaderText = "Ime_Broda";
            this.imeBrodaDataGridViewTextBoxColumn.Name = "imeBrodaDataGridViewTextBoxColumn";
            this.imeBrodaDataGridViewTextBoxColumn.ReadOnly = true;
            this.imeBrodaDataGridViewTextBoxColumn.Visible = false;
            // 
            // ukloniRadnika
            // 
            this.ukloniRadnika.DataPropertyName = "ukloniradnik";
            this.ukloniRadnika.HeaderText = "Ukloni";
            this.ukloniRadnika.Name = "ukloniRadnika";
            this.ukloniRadnika.ReadOnly = true;
            this.ukloniRadnika.Text = "Ukloni";
            this.ukloniRadnika.UseColumnTextForButtonValue = true;
            // 
            // radnikPresenterBindingSource
            // 
            this.radnikPresenterBindingSource.DataSource = typeof(Aplikacija.RadnikPresenter);
            // 
            // comboBoxRadnik
            // 
            this.comboBoxRadnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxRadnik.FormattingEnabled = true;
            this.comboBoxRadnik.Location = new System.Drawing.Point(567, 171);
            this.comboBoxRadnik.Name = "comboBoxRadnik";
            this.comboBoxRadnik.Size = new System.Drawing.Size(121, 26);
            this.comboBoxRadnik.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(425, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dodaj radnika:";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(63, 389);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(87, 33);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Natrag";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(578, 111);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(91, 37);
            this.metroButton2.TabIndex = 5;
            this.metroButton2.Text = "Dodaj";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // WindowUrediRadnikeNaBrodu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxRadnik);
            this.Controls.Add(this.dgRandnik);
            this.Controls.Add(this.dbBrod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WindowUrediRadnikeNaBrodu";
            this.Text = "Uredi radnike na brodu";
            this.Load += new System.EventHandler(this.WindowUrediRadnikeNaBrodu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbBrod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brodPresenterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRandnik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radnikPresenterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dbBrod;
        private System.Windows.Forms.DataGridView dgRandnik;
        private System.Windows.Forms.ComboBox comboBoxRadnik;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.BindingSource brodPresenterBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regOznakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource radnikPresenterBindingSource;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeBrodaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ukloniRadnika;
    }
}