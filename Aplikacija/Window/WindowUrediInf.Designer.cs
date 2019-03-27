namespace Aplikacija
{
    partial class WindowUrediInf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowUrediInf));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonZatvori = new MetroFramework.Controls.MetroButton();
            this.ButtonSpremi = new MetroFramework.Controls.MetroButton();
            this.labelGore = new System.Windows.Forms.Label();
            this.labelLijevo = new System.Windows.Forms.Label();
            this.labelDesno = new System.Windows.Forms.Label();
            this.labeldDole = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.Location = new System.Drawing.Point(463, 123);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(243, 195);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(66, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // ButtonZatvori
            // 
            this.ButtonZatvori.Location = new System.Drawing.Point(270, 346);
            this.ButtonZatvori.Name = "ButtonZatvori";
            this.ButtonZatvori.Size = new System.Drawing.Size(96, 41);
            this.ButtonZatvori.TabIndex = 2;
            this.ButtonZatvori.Text = "Zatvori";
            this.ButtonZatvori.UseSelectable = true;
            this.ButtonZatvori.Click += new System.EventHandler(this.ButtonZatvori_Click);
            // 
            // ButtonSpremi
            // 
            this.ButtonSpremi.Location = new System.Drawing.Point(534, 346);
            this.ButtonSpremi.Name = "ButtonSpremi";
            this.ButtonSpremi.Size = new System.Drawing.Size(87, 41);
            this.ButtonSpremi.TabIndex = 3;
            this.ButtonSpremi.Text = "Spremi";
            this.ButtonSpremi.UseSelectable = true;
            this.ButtonSpremi.Click += new System.EventHandler(this.ButtonSpremi_Click);
            // 
            // labelGore
            // 
            this.labelGore.BackColor = System.Drawing.Color.Transparent;
            this.labelGore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGore.ForeColor = System.Drawing.Color.Transparent;
            this.labelGore.Location = new System.Drawing.Point(58, 106);
            this.labelGore.Name = "labelGore";
            this.labelGore.Size = new System.Drawing.Size(308, 2);
            this.labelGore.TabIndex = 44;
            // 
            // labelLijevo
            // 
            this.labelLijevo.BackColor = System.Drawing.Color.Transparent;
            this.labelLijevo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLijevo.ForeColor = System.Drawing.Color.Transparent;
            this.labelLijevo.Location = new System.Drawing.Point(58, 108);
            this.labelLijevo.Name = "labelLijevo";
            this.labelLijevo.Size = new System.Drawing.Size(2, 216);
            this.labelLijevo.TabIndex = 43;
            // 
            // labelDesno
            // 
            this.labelDesno.BackColor = System.Drawing.Color.Transparent;
            this.labelDesno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDesno.ForeColor = System.Drawing.Color.Transparent;
            this.labelDesno.Location = new System.Drawing.Point(364, 106);
            this.labelDesno.Name = "labelDesno";
            this.labelDesno.Size = new System.Drawing.Size(2, 216);
            this.labelDesno.TabIndex = 42;
            // 
            // labeldDole
            // 
            this.labeldDole.BackColor = System.Drawing.Color.Transparent;
            this.labeldDole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labeldDole.ForeColor = System.Drawing.Color.Transparent;
            this.labeldDole.Location = new System.Drawing.Point(58, 322);
            this.labeldDole.Name = "labeldDole";
            this.labeldDole.Size = new System.Drawing.Size(308, 2);
            this.labeldDole.TabIndex = 41;
            // 
            // WindowUrediInf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelGore);
            this.Controls.Add(this.labelLijevo);
            this.Controls.Add(this.labelDesno);
            this.Controls.Add(this.labeldDole);
            this.Controls.Add(this.ButtonSpremi);
            this.Controls.Add(this.ButtonZatvori);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WindowUrediInf";
            this.Text = "Uredi oglasnu ploču";
            this.Load += new System.EventHandler(this.WindowUrediInf_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton ButtonZatvori;
        private MetroFramework.Controls.MetroButton ButtonSpremi;
        private System.Windows.Forms.Label labelGore;
        private System.Windows.Forms.Label labelLijevo;
        private System.Windows.Forms.Label labelDesno;
        private System.Windows.Forms.Label labeldDole;
    }
}