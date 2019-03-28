using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapMakinesiSwitchCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sonuc;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi1 = Convert.ToInt32(txt1.Text);
                int sayi2 = Convert.ToInt32(txt2.Text);

                if(rbBol.Checked == false && rbCarp.Checked == false && rbCikar.Checked == false && rbTopla.Checked == false)
                {
                    MessageBox.Show("Lütfen İşlem Tipi Seçin!");
                }
                else
                {
                    if (rbTopla.Checked)
                        Hesapla(sayi1, sayi2, "Topla");

                    if (rbCikar.Checked)
                        Hesapla(sayi1, sayi2, "Çıkar");

                    if (rbCarp.Checked)
                        Hesapla(sayi1, sayi2, "Çarp");

                    if (rbBol.Checked)
                        Hesapla(sayi1, sayi2, "Böl");

                    lblSonuc.Text = sonuc.ToString();
                }                

            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Sayısal Değerler Giriniz!");
            }
        }
        private void Hesapla(int sayi1, int sayi2, string islemTipi)
        {
           
            switch (islemTipi)
            {
                case "Topla":
                    sonuc = sayi1 + sayi2;
                    break;
                case "Çıkar":
                    sonuc = sayi1 - sayi2;
                    break;
                case "Çarp":
                    sonuc = sayi1 * sayi2;
                    break;
                case "Böl":
                    sonuc = sayi1 / sayi2;
                    break;
            }          
        }
    }
}
