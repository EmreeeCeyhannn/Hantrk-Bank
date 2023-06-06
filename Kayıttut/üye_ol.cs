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
    public partial class üye_ol : Form
    {
        public üye_ol()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=EMRECEYHAN\SQLEXPRESS01;Initial Catalog=HanTürkDB;Integrated Security=True");//Sql bağlanmak için değişken atadık
        Random uzunluk = new Random();//capTcha ve Hesap No için random sınıfından uzunluk için adlı nesne ürettik

        void goster()//Eski haline geri döndürmek için için metod tanımladım 
        {
            textBox1.Text = "İsim-Soyisim";
            textBox2.Text = "Parola";
            textBox4.Text = "Cevap";
            textBox5.Text = "Metni Giriniz";
            textBox4.Visible = false;
            panel4.Visible = false;
        }
        void güvenlik()//CapTcha üretecek
        {
            string[] buyukharf = { "A", "E", "B", "T", "X" };
            string[] kucukharf = { "z", "b", "w", "d", "n" };
            int s1, s2;
            s1 = uzunluk.Next(0, buyukharf.Length);
            s2 = uzunluk.Next(0, kucukharf.Length);
            label1.Text = buyukharf[s1] + kucukharf[s2] + s1.ToString() + s2.ToString() + buyukharf[s2];//5 karekterli güvenlik sorusu
        }
        string hesapno()//Hesap Numarası üretecek
        {
            int s1 = uzunluk.Next(100, 200);
            int s2 = uzunluk.Next(600, 800);
            int s3 = uzunluk.Next(1000, 1100);
            string hesapno = s1.ToString() + s2.ToString() + s3.ToString();//10 haneli Hesap Numarası ürettik
            return hesapno;//hesap numarası aşağıya getirecek
        }
       
        bool kontrol(string x, string y)//güvenlik sorusunu kontrol eder
        {

            if (x == y)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        bool kontrol2()//boş alanları kontrol eder
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox4.Text == "" || comboBox1.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void üye_ol_Load(object sender, EventArgs e)
        {
            güvenlik();//otomatik yüklenecek text
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            güvenlik();//resme bastığı zaman text'i değiştirir
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kontrol(label1.Text, textBox5.Text) == false || kontrol2() == true)//kontol yapılıyor...
            {
                if (kontrol2() == true)
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurunuz");
                }

                else
                {
                    MessageBox.Show("Text'i Yanlış Girdiniz");
                }
            }


            else
            {

                baglanti.Open();//sql serveri açaçak
                string isim,soyisim, Hesap_No, guvenlik_soru, guvenlik_cevap, sifre;//Eklenecek bilgiler
                isim = textBox1.Text;
                soyisim = textBox3.Text;
                tekrar: Hesap_No = hesapno();
                
                guvenlik_soru = comboBox1.Text;
                guvenlik_cevap = textBox4.Text;
                sifre = textBox2.Text;
                SqlCommand sorgu = new SqlCommand("select * from Giris where Id='" + Hesap_No + "'", baglanti);
                SqlDataReader oku = sorgu.ExecuteReader();
                if (oku.Read())
                {
                    goto tekrar;//bir ihtimal de olsa aynı hesap no veüretirse tekrar hesap no üretecek
                }

                else
                {
                    oku.Close();
                    SqlCommand ekle = new SqlCommand("insert into Giris(Id,Ad,Soyad,parola,guvenlik_sorusu,guvenlik_sorusu_cevap) values('" + Hesap_No + "','" + isim + "','" + soyisim + "','" + sifre + "','" + guvenlik_soru + "','" + guvenlik_cevap + "')", baglanti);
                    ekle.ExecuteNonQuery();                   
                    MessageBox.Show("Kullanıcı eklendi Musteri Numaranız: " + Hesap_No);//Kullanıcıyı Bilgilendirdik
                    goster();//Eski haline döndürdük
                }
                baglanti.Close();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = false;
            pictureBox4.Visible = true;
            textBox2.PasswordChar = '\0'; // Parolayı görünür hale getir
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox5.Visible = true;
            textBox2.PasswordChar = '*'; // Parolayı gizler
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //textbox'u gözükür yapar
            textBox4.Visible = true;
            panel4.Visible = true;
        }

        

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "İsim")
            {
                textBox1.Text = "\0";// Textboxu Temizler
            }
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "Soyisim")
            {
                textBox1.Text = "\0";// Textboxu Temizler
            }
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox2.Text == "Parola")
            {
                textBox2.Text = "\0";// Textboxu Temizler
            }
        }

        private void textBox4_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox4.Text == "Cevap")
            {
                textBox4.Text = "\0";// Textboxu Temizler
            }
        }

        private void textBox5_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox5.Text == "Metni Giriniz")
            {
                textBox5.Text = "\0";// Textboxu Temizler
            }
        }
    }
}
