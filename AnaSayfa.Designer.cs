
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;
using SizeF = System.Drawing.SizeF;
namespace login
{
    partial class AnaSayfa
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
            LabelKullaniciAdi = new Label();
            LabelRol = new Label();
            SuspendLayout();
            // 
            // LabelKullaniciAdi
            // 
            LabelKullaniciAdi.AutoSize = true;
            LabelKullaniciAdi.Location = new Point(12, 9);
            LabelKullaniciAdi.Name = "LabelKullaniciAdi";
            LabelKullaniciAdi.Size = new Size(69, 15);
            LabelKullaniciAdi.TabIndex = 0;
            LabelKullaniciAdi.Text = "kullaniciAdi";
            // 
            // LabelRol
            // 
            LabelRol.AutoSize = true;
            LabelRol.Location = new Point(12, 41);
            LabelRol.Name = "LabelRol";
            LabelRol.Size = new Size(21, 15);
            LabelRol.TabIndex = 1;
            LabelRol.Text = "rol";
            // 
            // AnaSayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LabelRol);
            Controls.Add(LabelKullaniciAdi);
            Name = "AnaSayfa";
            Text = "AnaSayfa";
            Load += AnaSayfa_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelKullaniciAdi;
        private Label LabelRol;
    }
}