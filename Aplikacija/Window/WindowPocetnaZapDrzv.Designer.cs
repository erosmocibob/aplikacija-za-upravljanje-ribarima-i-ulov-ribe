namespace Aplikacija
{
    partial class WindowPocetnaZapDrzv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowPocetnaZapDrzv));
            this.ButtonPodUlov = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.ButtonIzlaz = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.labelGore = new System.Windows.Forms.Label();
            this.labelLijevo = new System.Windows.Forms.Label();
            this.labelDesno = new System.Windows.Forms.Label();
            this.labeldDole = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonPodUlov
            // 
            this.ButtonPodUlov.Location = new System.Drawing.Point(45, 150);
            this.ButtonPodUlov.Name = "ButtonPodUlov";
            this.ButtonPodUlov.Size = new System.Drawing.Size(103, 45);
            this.ButtonPodUlov.TabIndex = 0;
            this.ButtonPodUlov.Text = "Podaci o ulovu";
            this.ButtonPodUlov.UseSelectable = true;
            this.ButtonPodUlov.Click += new System.EventHandler(this.ButtonPodUlov_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(529, 368);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(100, 48);
            this.metroButton2.TabIndex = 1;
            this.metroButton2.Text = "Uredi";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // ButtonIzlaz
            // 
            this.ButtonIzlaz.Location = new System.Drawing.Point(45, 368);
            this.ButtonIzlaz.Name = "ButtonIzlaz";
            this.ButtonIzlaz.Size = new System.Drawing.Size(103, 45);
            this.ButtonIzlaz.TabIndex = 2;
            this.ButtonIzlaz.Text = "Izlaz";
            this.ButtonIzlaz.UseSelectable = true;
            this.ButtonIzlaz.Click += new System.EventHandler(this.ButtonIzlaz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(447, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // labelGore
            // 
            this.labelGore.BackColor = System.Drawing.Color.Transparent;
            this.labelGore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGore.ForeColor = System.Drawing.Color.Transparent;
            this.labelGore.Location = new System.Drawing.Point(439, 107);
            this.labelGore.Name = "labelGore";
            this.labelGore.Size = new System.Drawing.Size(308, 2);
            this.labelGore.TabIndex = 40;
            // 
            // labelLijevo
            // 
            this.labelLijevo.BackColor = System.Drawing.Color.Transparent;
            this.labelLijevo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLijevo.ForeColor = System.Drawing.Color.Transparent;
            this.labelLijevo.Location = new System.Drawing.Point(439, 109);
            this.labelLijevo.Name = "labelLijevo";
            this.labelLijevo.Size = new System.Drawing.Size(2, 216);
            this.labelLijevo.TabIndex = 39;
            // 
            // labelDesno
            // 
            this.labelDesno.BackColor = System.Drawing.Color.Transparent;
            this.labelDesno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDesno.ForeColor = System.Drawing.Color.Transparent;
            this.labelDesno.Location = new System.Drawing.Point(745, 107);
            this.labelDesno.Name = "labelDesno";
            this.labelDesno.Size = new System.Drawing.Size(2, 216);
            this.labelDesno.TabIndex = 38;
            // 
            // labeldDole
            // 
            this.labeldDole.BackColor = System.Drawing.Color.Transparent;
            this.labeldDole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labeldDole.ForeColor = System.Drawing.Color.Transparent;
            this.labeldDole.Location = new System.Drawing.Point(439, 323);
            this.labeldDole.Name = "labeldDole";
            this.labeldDole.Size = new System.Drawing.Size(308, 2);
            this.labeldDole.TabIndex = 37;
            // 
            // WindowPocetnaZapDrzv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelGore);
            this.Controls.Add(this.labelLijevo);
            this.Controls.Add(this.labelDesno);
            this.Controls.Add(this.labeldDole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonIzlaz);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.ButtonPodUlov);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WindowPocetnaZapDrzv";
            this.Text = "Dobro došli";
            this.Activated += new System.EventHandler(this.WindowPocetnaZapDrzv_Activated);
            this.Load += new System.EventHandler(this.WindowPocetnaZapDrzv_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton ButtonPodUlov;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton ButtonIzlaz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelGore;
        private System.Windows.Forms.Label labelLijevo;
        private System.Windows.Forms.Label labelDesno;
        private System.Windows.Forms.Label labeldDole;
    }
}