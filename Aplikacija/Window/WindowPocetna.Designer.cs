namespace Aplikacija
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.buttonRadnici = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.labelGore = new System.Windows.Forms.Label();
            this.labelLijevo = new System.Windows.Forms.Label();
            this.labelDesno = new System.Windows.Forms.Label();
            this.labeldDole = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(23, 100);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(104, 43);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Unos lova";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.Unosulova_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(23, 165);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(104, 43);
            this.metroButton2.TabIndex = 1;
            this.metroButton2.Text = "Brod";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // buttonRadnici
            // 
            this.buttonRadnici.Location = new System.Drawing.Point(23, 229);
            this.buttonRadnici.Name = "buttonRadnici";
            this.buttonRadnici.Size = new System.Drawing.Size(104, 43);
            this.buttonRadnici.TabIndex = 2;
            this.buttonRadnici.Text = "Radnici";
            this.buttonRadnici.UseSelectable = true;
            this.buttonRadnici.Click += new System.EventHandler(this.buttonRadnici_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(23, 292);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(140, 46);
            this.metroButton4.TabIndex = 3;
            this.metroButton4.Text = "Povijest ulova i radnika";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(23, 357);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(104, 43);
            this.metroButton5.TabIndex = 4;
            this.metroButton5.Text = "Izlaz";
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(443, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // labelGore
            // 
            this.labelGore.BackColor = System.Drawing.Color.Transparent;
            this.labelGore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGore.ForeColor = System.Drawing.Color.Transparent;
            this.labelGore.Location = new System.Drawing.Point(435, 115);
            this.labelGore.Name = "labelGore";
            this.labelGore.Size = new System.Drawing.Size(308, 2);
            this.labelGore.TabIndex = 44;
            // 
            // labelLijevo
            // 
            this.labelLijevo.BackColor = System.Drawing.Color.Transparent;
            this.labelLijevo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLijevo.ForeColor = System.Drawing.Color.Transparent;
            this.labelLijevo.Location = new System.Drawing.Point(435, 117);
            this.labelLijevo.Name = "labelLijevo";
            this.labelLijevo.Size = new System.Drawing.Size(2, 216);
            this.labelLijevo.TabIndex = 43;
            // 
            // labelDesno
            // 
            this.labelDesno.BackColor = System.Drawing.Color.Transparent;
            this.labelDesno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDesno.ForeColor = System.Drawing.Color.Transparent;
            this.labelDesno.Location = new System.Drawing.Point(741, 115);
            this.labelDesno.Name = "labelDesno";
            this.labelDesno.Size = new System.Drawing.Size(2, 216);
            this.labelDesno.TabIndex = 42;
            // 
            // labeldDole
            // 
            this.labeldDole.BackColor = System.Drawing.Color.Transparent;
            this.labeldDole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labeldDole.ForeColor = System.Drawing.Color.Transparent;
            this.labeldDole.Location = new System.Drawing.Point(435, 331);
            this.labeldDole.Name = "labeldDole";
            this.labeldDole.Size = new System.Drawing.Size(308, 2);
            this.labeldDole.TabIndex = 41;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelGore);
            this.Controls.Add(this.labelLijevo);
            this.Controls.Add(this.labelDesno);
            this.Controls.Add(this.labeldDole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.buttonRadnici);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "Dobro došli";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton buttonRadnici;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelGore;
        private System.Windows.Forms.Label labelLijevo;
        private System.Windows.Forms.Label labelDesno;
        private System.Windows.Forms.Label labeldDole;
    }
}

