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
    public partial class ParaYatırÇek : Form
    {
        public ParaYatırÇek()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=EMRECEYHAN\SQLEXPRESS01;Initial Catalog=HanTürkDB;Integrated Security=True");
        private static string sqliddeğeri;
        private int sqliddeğerint;
        public void sqliddeğerim(string value)
        {
            sqliddeğeri = value;
        }
        private void FillComboBox(int variable)
        {
            try
            {
                connection.Open();
                // Veritabanından hesapları getiren komut
                SqlCommand command = new SqlCommand("SELECT Alici_Hesap_adi FROM GelirGider WHERE KisiId = @id", connection);
                command.Parameters.AddWithValue("@id", variable);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    hesapseçcb.Items.Add(reader["Alici_Hesap_adi"].ToString());
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verileri alma hatası: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void ParaYatırÇek_Load(object sender, EventArgs e)
        {
            sqliddeğerint = Convert.ToInt32(sqliddeğeri);
            int A = sqliddeğerint;
            FillComboBox(A);
        }

        private void hesapseçcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            string bakiyeal = null;
            // Seçilen hesaptan bakiye bilgisini getiren komut
            SqlCommand isimal = new SqlCommand("SELECT Bakiye FROM GelirGider WHERE Gelirgider.Alici_Hesap_adi = @ad", connection);
            isimal.Parameters.AddWithValue("@ad", hesapseçcb.Text);
            SqlDataReader oku = isimal.ExecuteReader();
            if (oku.Read())
            {                
                bakiyeal = oku.GetString(0);
            }
            bakiyetxt.Text = bakiyeal;
            connection.Close();
        }

        private void paraçek_Click(object sender, EventArgs e)
        {
            // Belirtilen hesaptan para çekmeişlemini gerçekleştiren kod
            int a = Convert.ToInt32(tutartxt.Text);
            connection.Open();
            SqlCommand çek = new SqlCommand("UPDATE GelirGider SET Gelir = Gelir - @a WHERE GelirGider.Alici_Hesap_adi = @hesap", connection);
            çek.Parameters.AddWithValue("@a", Convert.ToInt32(tutartxt.Text));
            çek.Parameters.AddWithValue("@hesap", hesapseçcb.Text);
            çek.ExecuteNonQuery();
            çek.Dispose();
            connection.Close();
            MessageBox.Show("Para çekme işlemi başarılı");
        }

        private void parayatır_Click(object sender, EventArgs e)
        {
            // Belirtilen hesaba para yatırma işlemini gerçekleştiren kod
            int a = Convert.ToInt32(tutartxt.Text);
            connection.Open();
            SqlCommand yatır = new SqlCommand("UPDATE GelirGider SET Gelir = Gelir + @a WHERE GelirGider.Alici_Hesap_adi = @hesap", connection);
            yatır.Parameters.AddWithValue("@a", Convert.ToInt32(tutartxt.Text));
            yatır.Parameters.AddWithValue("@hesap", hesapseçcb.Text);
            yatır.ExecuteNonQuery();
            yatır.Dispose();
            connection.Close();
            MessageBox.Show("Para yatırma işlemi başarılı");
        }
    }
}
