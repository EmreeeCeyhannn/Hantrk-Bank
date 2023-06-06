using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kayıttut.Yönetici
{
    public partial class ayarlar : Form
    {
        public ayarlar()
        {
            InitializeComponent();
        }
        void goster()//Eski haline geri döndürmek için için metod tanımladım 
        {
            textBox1.Text = "Yönetici Numaranızı Giriniz";
            textBox2.Text = "Yeni Parola";
            textBox3.Text = "Yeni Mail Adresi";
        }
        public bool regexp(string re, System.Windows.Forms.TextBox tb)//gmail'in geçerliğini kontrol etmek için kullanılır
        {
            Regex reger = new Regex(re);
            if (reger.IsMatch(tb.Text))
            {

                return true;
            }
            else
            {

                return false;
            }
        }
        //Sql işlemleri için kullanılacak
        SqlConnection con;
        SqlCommand com;
        SqlDataReader dr;
        private void button1_Click(object sender, EventArgs e)
        {
            regexp(@"^[^\s@]{6,}@gmail\.com$", textBox3);//6hane@gmail.com olacak şekilde kontol yapacak

            //Yöneticiden bu bilgileri alarak güncelleme yapacak
            if (regexp(@"^[^\s@]{6,}@gmail\.com$", textBox3) == true)//mail doğru ise işlemlere başlayacak
            { //Yöneticiden alacağımız bilgiler
                string ıd = textBox1.Text;
                string sifre = textBox2.Text;
                string mail = textBox3.Text;
                con = new SqlConnection(@"Data Source=EMRECEYHAN\SQLEXPRESS01;Initial Catalog=HanTürkDB;Integrated Security=True");//Sql'e bağlandı
                com = new SqlCommand();
                con.Open();
                com.Connection = con;
                com.CommandText = "select * from yonetici where Yönetici_Numara='" + textBox1.Text + "'";//ıd numarası doğru olması halinde değişiklik ypacak
                dr = com.ExecuteReader();

                if (dr.Read())//ıd doğru ise
                {
                    dr.Close();

                    SqlCommand güncelle = new SqlCommand("update yonetici set Yönetici_Sifre='" + sifre + "',Yönetici_E_posta='" + mail + "' where Yönetici_Numara='" + ıd + "'", con);//şifre ve mail adresini güncelledi
                    güncelle.ExecuteNonQuery();
                    MessageBox.Show("Yöneticinin Şifresi ve Mail Adresi değiştirildi");//Yöneticiye bilgi verdik
                    goster();//Görünüşü eski haline getirdik
                }
                else // ıd yanlış ise
                {

                    MessageBox.Show("Böyle Bir Yönetici Bulunamadı!!!");

                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Geçersiz E-mail");
                goster();
            }
        
    }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "Yönetici Numaranızı Giriniz")
            {
                textBox1.Clear();// Textboxu Temizler
            }
        }

        private void ayarlar_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "Yeni Parola")
            {
                textBox2.Clear();// Textboxu Temizler
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "Yeni Mail Adresi")
            {
                textBox3.Clear();// Textboxu Temizler
            }
        }
    }
}
