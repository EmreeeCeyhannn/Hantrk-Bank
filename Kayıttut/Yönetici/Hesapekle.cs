using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kayıttut.Yönetici
{
    public partial class Hesapekle : Form
    {
        public Hesapekle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=EMRECEYHAN\SQLEXPRESS01;Initial Catalog=HanTürkDB;Integrated Security=True");

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Güvenlik sorusu: En sevdiğiniz Hayvan?\nCevap ise:Kedi otomatik olorak eklenecektir ");//Yönetici bilgilendirme
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "İsim-Soyisim")
            {
                textBox1.Clear();// Textboxu Temizler
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "Parola")
            {
                textBox2.Clear();// Textboxu Temizler
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string isim, soyisim,sifre;
            isim = textBox1.Text;
            soyisim = textBox5.Text;
            sifre= textBox3.Text;
            SqlCommand ekle = new SqlCommand("insert into Giris(Ad,Soyad,parola) values('" + isim + "','" + soyisim + "','" + sifre + "')", baglanti);
            ekle.ExecuteNonQuery();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "Soyisim")
            {
                textBox2.Clear();// Textboxu Temizler
            }
        }
    }
}
