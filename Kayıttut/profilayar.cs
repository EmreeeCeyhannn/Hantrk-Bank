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
    public partial class profilayar : Form
    {
        private const string connectionString = @"Data Source=EMRECEYHAN\SQLEXPRESS01;Initial Catalog=HanTürkDB;Integrated Security=True";
        private static string sqliddeğeri;
        int giris_id = Convert.ToInt32(sqliddeğeri);
        public void sqliddeğerim(string value)
        {
            sqliddeğeri = value;
        }

        public profilayar()
        {
            InitializeComponent();
        }
        private void profilayar_Load(object sender, EventArgs e)
        {
            // Profil ayarları formu yüklendiğinde, kullanıcının güvenlik sorusu, cevabı ve şifresini görüntüleyen kodlar

            string query = "SELECT Parola, guvenlik_sorusu, guvenlik_sorusu_cevap FROM Giris WHERE Id = @giris_id";

            SqlConnection baglanti = new SqlConnection(connectionString);            
            SqlCommand command = new SqlCommand(query, baglanti);
            command.Parameters.AddWithValue("@giris_id", giris_id);

            try
            {
                baglanti.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string giris_sifre = reader["Parola"].ToString();
                        string giris_soru = reader["guvenlik_sorusu"].ToString();
                        string giris_cevap = reader["guvenlik_sorusu_cevap"].ToString();
                        // Güvenlik sorusu, cevabı ve şifresini ilgili alanlara yerleştirme
                        soruu.Text = giris_soru;
                        guvenlikcvptxt.Text = giris_cevap;
                        sifretxt.Text = giris_sifre;
                    }
                }
                else
                {
                    MessageBox.Show("Kayıt bulunamadı");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally { baglanti.Close(); }

        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
            // Değişiklikleri kaydetmek için kullanılan kodlar
            string soru = soruu.Text;
            string cevap = guvenlikcvptxt.Text;            
            string yeniSifre = sifretxt.Text;

            string query = "UPDATE Giris SET Parola = @yeniSifre, guvenlik_sorusu = @soru, guvenlik_sorusu_cevap = @yenicvp WHERE Id = @giris_id";

            using (SqlConnection baglanti2 = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, baglanti2);
                command.Parameters.AddWithValue("@yeniSifre", yeniSifre);
                command.Parameters.AddWithValue("@soru", soru);
                command.Parameters.AddWithValue("@yenicvp", cevap);                          
                command.Parameters.AddWithValue("@giris_id", giris_id);

                try
                {
                    baglanti2.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Veriler güncellendi");
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme yapılamadı");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
    }
}



