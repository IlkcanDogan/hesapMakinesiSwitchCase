namespace hesapMakinesiSwitchCase
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbTopla = new System.Windows.Forms.RadioButton();
            this.rbCikar = new System.Windows.Forms.RadioButton();
            this.rbCarp = new System.Windows.Forms.RadioButton();
            this.rbBol = new System.Windows.Forms.RadioButton();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(13, 67);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(172, 31);
            this.btnHesapla.TabIndex = 0;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(49, 12);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(136, 20);
            this.txt1.TabIndex = 1;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(49, 38);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(136, 20);
            this.txt2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sayı1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sayı2";
            // 
            // rbTopla
            // 
            this.rbTopla.AutoSize = true;
            this.rbTopla.Location = new System.Drawing.Point(191, 12);
            this.rbTopla.Name = "rbTopla";
            this.rbTopla.Size = new System.Drawing.Size(52, 17);
            this.rbTopla.TabIndex = 4;
            this.rbTopla.TabStop = true;
            this.rbTopla.Text = "Topla";
            this.rbTopla.UseVisualStyleBackColor = true;
            // 
            // rbCikar
            // 
            this.rbCikar.AutoSize = true;
            this.rbCikar.Location = new System.Drawing.Point(191, 38);
            this.rbCikar.Name = "rbCikar";
            this.rbCikar.Size = new System.Drawing.Size(49, 17);
            this.rbCikar.TabIndex = 5;
            this.rbCikar.TabStop = true;
            this.rbCikar.Text = "Çıkar";
            this.rbCikar.UseVisualStyleBackColor = true;
            // 
            // rbCarp
            // 
            this.rbCarp.AutoSize = true;
            this.rbCarp.Location = new System.Drawing.Point(249, 12);
            this.rbCarp.Name = "rbCarp";
            this.rbCarp.Size = new System.Drawing.Size(47, 17);
            this.rbCarp.TabIndex = 6;
            this.rbCarp.TabStop = true;
            this.rbCarp.Text = "Çarp";
            this.rbCarp.UseVisualStyleBackColor = true;
            // 
            // rbBol
            // 
            this.rbBol.AutoSize = true;
            this.rbBol.Location = new System.Drawing.Point(249, 38);
            this.rbBol.Name = "rbBol";
            this.rbBol.Size = new System.Drawing.Size(40, 17);
            this.rbBol.TabIndex = 7;
            this.rbBol.TabStop = true;
            this.rbBol.Text = "Böl";
            this.rbBol.UseVisualStyleBackColor = true;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl1.Location = new System.Drawing.Point(195, 71);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(48, 15);
            this.lbl1.TabIndex = 8;
            this.lbl1.Text = "Sonuç: ";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(242, 71);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(16, 15);
            this.lblSonuc.TabIndex = 9;
            this.lblSonuc.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 107);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.rbBol);
            this.Controls.Add(this.rbCarp);
            this.Controls.Add(this.rbCikar);
            this.Controls.Add(this.rbTopla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btnHesapla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbTopla;
        private System.Windows.Forms.RadioButton rbCikar;
        private System.Windows.Forms.RadioButton rbCarp;
        private System.Windows.Forms.RadioButton rbBol;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblSonuc;
    }
}

