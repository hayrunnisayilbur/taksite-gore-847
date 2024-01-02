namespace taksite_gore_847
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
            this.taksit = new System.Windows.Forms.ListBox();
            this.saat = new System.Windows.Forms.ListBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.numTaksit = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numTaksit)).BeginInit();
            this.SuspendLayout();
            // 
            // taksit
            // 
            this.taksit.FormattingEnabled = true;
            this.taksit.Location = new System.Drawing.Point(432, 106);
            this.taksit.Name = "taksit";
            this.taksit.Size = new System.Drawing.Size(126, 225);
            this.taksit.TabIndex = 0;
            // 
            // saat
            // 
            this.saat.FormattingEnabled = true;
            this.saat.Location = new System.Drawing.Point(600, 106);
            this.saat.Name = "saat";
            this.saat.Size = new System.Drawing.Size(124, 225);
            this.saat.TabIndex = 1;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(32, 83);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(32, 138);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(100, 20);
            this.txtSayi.TabIndex = 3;
            // 
            // numTaksit
            // 
            this.numTaksit.Location = new System.Drawing.Point(32, 178);
            this.numTaksit.Name = "numTaksit";
            this.numTaksit.Size = new System.Drawing.Size(120, 20);
            this.numTaksit.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numTaksit);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.saat);
            this.Controls.Add(this.taksit);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numTaksit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox taksit;
        private System.Windows.Forms.ListBox saat;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.NumericUpDown numTaksit;
    }
}

