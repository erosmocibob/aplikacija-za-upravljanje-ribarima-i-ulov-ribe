﻿namespace Aplikacija
{
    partial class WindowPrijavaZapDrzave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowPrijavaZapDrzave));
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxIme = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxSifra = new MetroFramework.Controls.MetroTextBox();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(255, 322);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(92, 42);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Natrag";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(417, 322);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(92, 45);
            this.metroButton4.TabIndex = 3;
            this.metroButton4.Text = "Prijava";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(209, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Korisničko ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(265, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Šifra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(208, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prijavite se kao zaposlenik državne uprave";
            // 
            // TextBoxIme
            // 
            // 
            // 
            // 
            this.TextBoxIme.CustomButton.Image = null;
            this.TextBoxIme.CustomButton.Location = new System.Drawing.Point(90, 1);
            this.TextBoxIme.CustomButton.Name = "";
            this.TextBoxIme.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBoxIme.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxIme.CustomButton.TabIndex = 1;
            this.TextBoxIme.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxIme.CustomButton.UseSelectable = true;
            this.TextBoxIme.CustomButton.Visible = false;
            this.TextBoxIme.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TextBoxIme.Lines = new string[0];
            this.TextBoxIme.Location = new System.Drawing.Point(345, 184);
            this.TextBoxIme.MaxLength = 32767;
            this.TextBoxIme.Name = "TextBoxIme";
            this.TextBoxIme.PasswordChar = '\0';
            this.TextBoxIme.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxIme.SelectedText = "";
            this.TextBoxIme.SelectionLength = 0;
            this.TextBoxIme.SelectionStart = 0;
            this.TextBoxIme.ShortcutsEnabled = true;
            this.TextBoxIme.Size = new System.Drawing.Size(112, 23);
            this.TextBoxIme.TabIndex = 7;
            this.TextBoxIme.UseSelectable = true;
            this.TextBoxIme.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxIme.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TextBoxSifra
            // 
            // 
            // 
            // 
            this.TextBoxSifra.CustomButton.Image = null;
            this.TextBoxSifra.CustomButton.Location = new System.Drawing.Point(85, 1);
            this.TextBoxSifra.CustomButton.Name = "";
            this.TextBoxSifra.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBoxSifra.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxSifra.CustomButton.TabIndex = 1;
            this.TextBoxSifra.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxSifra.CustomButton.UseSelectable = true;
            this.TextBoxSifra.CustomButton.Visible = false;
            this.TextBoxSifra.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TextBoxSifra.Lines = new string[0];
            this.TextBoxSifra.Location = new System.Drawing.Point(350, 246);
            this.TextBoxSifra.MaxLength = 32767;
            this.TextBoxSifra.Name = "TextBoxSifra";
            this.TextBoxSifra.PasswordChar = '\0';
            this.TextBoxSifra.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxSifra.SelectedText = "";
            this.TextBoxSifra.SelectionLength = 0;
            this.TextBoxSifra.SelectionStart = 0;
            this.TextBoxSifra.ShortcutsEnabled = true;
            this.TextBoxSifra.Size = new System.Drawing.Size(107, 23);
            this.TextBoxSifra.TabIndex = 8;
            this.TextBoxSifra.UseSelectable = true;
            this.TextBoxSifra.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxSifra.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.metroCheckBox1.Location = new System.Drawing.Point(484, 250);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(58, 19);
            this.metroCheckBox1.TabIndex = 9;
            this.metroCheckBox1.Text = "Show";
            this.metroCheckBox1.UseSelectable = true;
            this.metroCheckBox1.CheckedChanged += new System.EventHandler(this.metroCheckBox1_CheckedChanged);
            // 
            // WindowPrijavaZapDrzave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.TextBoxSifra);
            this.Controls.Add(this.TextBoxIme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WindowPrijavaZapDrzave";
            this.Text = "Prijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox TextBoxIme;
        private MetroFramework.Controls.MetroTextBox TextBoxSifra;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
    }
}