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

namespace Kayıttut
{
    public partial class şifre_değiştirme : Form
    {
        public şifre_değiştirme()
        {
            InitializeComponent();
        }
        void goster()//Tekrar ilk görüneme sahip olması için paremetresiz metod
        {
            textBox1.Text = "Müşteri No";
            textBox2.Text = "Yeni Parola";
            textBox3.Text = "Güvenlik Sorusu Cevabı";
            textBox3.Visible = false;
            panel3.Visible = false;
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=EMRECEYHAN\SQLEXPRESS01;Initial Catalog=HanTürkDB;Integrated Security=True");
        private void şifre_değiştirme_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            baglanti.Open();//bağlamtıyı açacak
            //Kullanıcadan alınacak bilgiler
            string kullanıcı, guvenlik_soru, guvenlik_cevap, sifre;
            kullanıcı = textBox1.Text;
            guvenlik_soru = comboBox1.Text;
            guvenlik_cevap = textBox3.Text;
            sifre = textBox2.Text;
            SqlCommand sorgu = new SqlCommand("select * from Giris where Id='" + kullanıcı + "'And guvenlik_sorusu='" + guvenlik_soru + "'And guvenlik_sorusu_cevap='" + guvenlik_cevap + "'", baglanti);//Bazı bilgilerin doğru olması halinde if'li bloğa girecek
            SqlDataReader oku = sorgu.ExecuteReader();

            if (oku.Read())
            {
                oku.Close();
                SqlCommand güncelle = new SqlCommand("update Giris set parola='" + sifre + "' where Id='" + kullanıcı + "'And guvenlik_sorusu='" + guvenlik_soru + "'And guvenlik_sorusu_cevap='" + guvenlik_cevap + "'", baglanti);
                güncelle.ExecuteNonQuery();//şifre Kısmını burada güncelliyor
                if (sifre == "")
                {
                    MessageBox.Show("Geçerli Bir Şifre Giriniz");//Eğer şifre boşluksa kabul etmeyecek
                }
                else
                {
                    MessageBox.Show("Şifreniz Başarılı Bir Şekilde Değiştirildi");
                    goster();//metodu çağırdık böylece eski halini geri alacak
                }


            }

            else
            {
                MessageBox.Show("Böyle Bir Kullanıcı Bulunamadı");

            }
            baglanti.Close();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "Hesap No")
            {
                textBox1.Text = "\0";//fare üstüne bastığı ve yukardakı şart sağlandığı zaman zaman textbox temizlenir
            }
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox2.Text == "Yeni Parola")
            {
                textBox2.Text = "\0";
            }
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox5.Visible = true;
            textBox2.PasswordChar = '*'; // Parolayı görünür hale getir
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            pictureBox5.Visible = false;
            textBox2.PasswordChar = '\0'; // Parolayı görünür hale getir
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel3.Visible = true;
            textBox3.Visible = true;
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox3.Text == "Güvenlik Sorusu Cevabı")
            {
                textBox3.Text = "\0";
            }
        }
    }
}
