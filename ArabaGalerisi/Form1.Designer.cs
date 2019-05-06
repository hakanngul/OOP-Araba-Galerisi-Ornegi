namespace ArabaGalerisi
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
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnArabaEkle = new System.Windows.Forms.Button();
            this.btnArabaListele = new System.Windows.Forms.Button();
            this.btnArabaSat = new System.Windows.Forms.Button();
            this.txtListele = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(85, 28);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(279, 20);
            this.txtMarka.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Marka";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(85, 54);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(279, 20);
            this.txtModel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Model";
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(85, 80);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(279, 20);
            this.txtRenk.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Renk";
            // 
            // btnArabaEkle
            // 
            this.btnArabaEkle.Location = new System.Drawing.Point(85, 107);
            this.btnArabaEkle.Name = "btnArabaEkle";
            this.btnArabaEkle.Size = new System.Drawing.Size(279, 23);
            this.btnArabaEkle.TabIndex = 8;
            this.btnArabaEkle.Text = "EKLE";
            this.btnArabaEkle.UseVisualStyleBackColor = true;
            this.btnArabaEkle.Click += new System.EventHandler(this.btnArabaEkle_Click);
            // 
            // btnArabaListele
            // 
            this.btnArabaListele.Location = new System.Drawing.Point(45, 211);
            this.btnArabaListele.Name = "btnArabaListele";
            this.btnArabaListele.Size = new System.Drawing.Size(319, 23);
            this.btnArabaListele.TabIndex = 9;
            this.btnArabaListele.Text = "LİSTELE";
            this.btnArabaListele.UseVisualStyleBackColor = true;
            this.btnArabaListele.Click += new System.EventHandler(this.btnArabaListele_Click);
            // 
            // btnArabaSat
            // 
            this.btnArabaSat.Location = new System.Drawing.Point(45, 381);
            this.btnArabaSat.Name = "btnArabaSat";
            this.btnArabaSat.Size = new System.Drawing.Size(319, 23);
            this.btnArabaSat.TabIndex = 11;
            this.btnArabaSat.Text = "SEÇİLİ ARACI SAT";
            this.btnArabaSat.UseVisualStyleBackColor = true;
            this.btnArabaSat.Click += new System.EventHandler(this.btnArabaSat_Click);
            // 
            // txtListele
            // 
            this.txtListele.Location = new System.Drawing.Point(45, 241);
            this.txtListele.Multiline = true;
            this.txtListele.Name = "txtListele";
            this.txtListele.Size = new System.Drawing.Size(319, 134);
            this.txtListele.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 428);
            this.Controls.Add(this.txtListele);
            this.Controls.Add(this.btnArabaSat);
            this.Controls.Add(this.btnArabaListele);
            this.Controls.Add(this.btnArabaEkle);
            this.Controls.Add(this.txtRenk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnArabaEkle;
        private System.Windows.Forms.Button btnArabaListele;
        private System.Windows.Forms.Button btnArabaSat;
        private System.Windows.Forms.TextBox txtListele;
    }
}

