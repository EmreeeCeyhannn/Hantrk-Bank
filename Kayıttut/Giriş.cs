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
    public partial class Giriş : Form
    {

        public Giriş()
        {
            InitializeComponent();
        }
        // SqlConnection, SqlDataReader ve SqlCommand sınıfından nesneleri tanımlıyorum
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        private void Giriş_Load(object sender, EventArgs e)
        {

        }

        private void gir_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=EMRECEYHAN\SQLEXPRESS01;Initial Catalog=HanTürkDB;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;

            if (checkBox2.Checked)//eğer Yönetici girişi butonuna basarsa bu bloğun içine girecek
            {
                com.CommandText = "select * from Giris where Id='" + müsterinotxt.Text + "' and Parola='" + sifretxt.Text + "'";
                dr = com.ExecuteReader();
                if (dr.Read())
                {
                    // MessageBox.Show("yes");
                    Form1 form1 = new Form1();
                    profilayar profilayar = new profilayar();
                    yenihspaç yenihspaç = new yenihspaç();
                    HspBilgGör hspBilgGör = new HspBilgGör();
                    Transfer transfer = new Transfer();
                    ParaYatırÇek ytrcek = new ParaYatırÇek();
                    form1.sqliddeğerim(müsterinotxt.Text);
                    profilayar.sqliddeğerim(müsterinotxt.Text);
                    yenihspaç.sqliddeğerim(müsterinotxt.Text);
                    hspBilgGör.sqliddeğerim(müsterinotxt.Text);
                    transfer.sqliddeğerim(müsterinotxt.Text);
                    ytrcek.sqliddeğerim(müsterinotxt.Text);
                    form1.Show();
                    this.Hide();
                }
                else
                {

                    MessageBox.Show("Böyle Bir Kullanıcı Bulunamadı!!!");

                }
                müsterinotxt.Text = "Hesap Numarası";
                sifretxt.Text = "Parola";
            }

            if (checkBox3.Checked)//eğer Yönetici girişi butonuna basarsa bu bloğun içine girecek
            {
                com.CommandText = "select * from yonetici where Yönetici_Numara='" + müsterinotxt.Text + "'And Yönetici_Sifre='" + sifretxt.Text + "'";//Yönetici No ve şifresini kontrol ediyor
                dr = com.ExecuteReader();

                if (dr.Read())
                {

                    if (müsterinotxt.Text == "1")//Kutlu Türkücü adlı yöneticinin hesap no'su
                    {
                        Yöneticii y = new Yöneticii();//y adında nesne ürettik
                        y.Show();//Yönetici formunu açtı
                        y.MyLabelText = "Kutlu Türkücü";//Yönetici adlı formda bilgi vermek için 
                    }
                    else
                    {
                        Yöneticii y = new Yöneticii();
                        y.Show();//Yönetici formunu açtı
                        y.MyLabelText = "Emre Ceyhan";///Yönetici adlı formda bilgi vermek için 

                    }

                }
                else
                {

                    MessageBox.Show("Böyle Bir Yönetici Bulunamadı!!!");

                }
                con.Close();
            }
            

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //Checkboxlaradan sadece birinin seçili olması için
            if (checkBox2.Checked == false)
            {
                checkBox3.Checked = true;
            }
            else
            {
                checkBox3.Checked = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            //Checkboxlaradan sadece birinin seçili olması için
            if (checkBox3.Checked == false)
            {
                checkBox2.Checked = true;
            }
            else
            {
                checkBox2.Checked = false;
            }
        }

        

        private void sifretxt_MouseClick(object sender, MouseEventArgs e)
        {
            if (sifretxt.Text == "Parola")
            {
                sifretxt.Clear();// Textboxu Temizler
            }
        }

        private void müsterinotxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //Sadece resimlerden birinin gözükmesi için
            pictureBox4.Visible = true;
            pictureBox5.Visible = false;
            sifretxt.PasswordChar = '\0'; // Parolayı gizler
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //Sadece resimlerden birinin gözükmesi için
            pictureBox4.Visible = false;
            pictureBox5.Visible = true;
            sifretxt.PasswordChar = '*'; // Parolayı görünür hale getir
        }

        private void müsterinotxt_MouseClick(object sender, MouseEventArgs e)
        {
            if (müsterinotxt.Text == "Hesap Numarası")
            {
                müsterinotxt.Clear();// Textboxu Temizler
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //şifresini unutanlar için yeni bir form açacak
            şifre_değiştirme su = new şifre_değiştirme();
            su.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Yönetici.Hesapekle üye = new Yönetici.Hesapekle();
            this.Hide();
            üye.Show();
        }
    }
}
