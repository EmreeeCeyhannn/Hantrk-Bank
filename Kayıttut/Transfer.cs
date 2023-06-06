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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kayıttut
{
    public partial class Transfer : Form
    {
        public Transfer()
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
                SqlCommand command = new SqlCommand("SELECT Alici_Hesap_adi FROM GelirGider WHERE KisiId = @id", connection);
                command.Parameters.AddWithValue("@id", variable);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    hesapadCbox.Items.Add(reader["Alici_Hesap_adi"].ToString());
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

        private void Transfer_Load(object sender, EventArgs e)
        {
            sqliddeğerint = Convert.ToInt32(sqliddeğeri);
            int A = sqliddeğerint;
            FillComboBox(A);
        }
        static int gönderenibnal;
        static string aliciHesapadial = null;
        private void hesapadCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            
            string bakiyeal = null;
            SqlCommand isimal = new SqlCommand("SELECT IBAN_no_gonderen, Bakiye FROM GelirGider WHERE Gelirgider.Alici_Hesap_adi = @ad", connection);
            isimal.Parameters.AddWithValue("@ad", hesapadCbox.Text);
            SqlDataReader oku = isimal.ExecuteReader();
            if (oku.Read())
            {
                gönderenibnal = oku.GetInt32(0);
                bakiyeal = oku.GetString(1);                
            }
            bakiyetxt.Text = bakiyeal;
            connection.Close();
        }

        private void gndrbtn_Click(object sender, EventArgs e)
        {
            try
            {
               
                connection.Open();
                SqlCommand komuttransfer = new SqlCommand("transferdüzeni", connection);
                komuttransfer.CommandType = CommandType.StoredProcedure;
                komuttransfer.Parameters.AddWithValue("@miktar", Convert.ToInt32(GonderilenPara.Text));
                komuttransfer.Parameters.AddWithValue("@gonderenhesap", hesapadCbox.Text);
                komuttransfer.Parameters.AddWithValue("@alicihesap", aliciHesapadial); //aliciHesapadial);
                komuttransfer.Parameters.AddWithValue("@gonderenibn", gönderenibnal);
                komuttransfer.Parameters.AddWithValue("@alicibn", Convert.ToInt32(alicibnaltxt.Text));
                komuttransfer.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Transfer işlemibaşarili");
            }
            catch (Exception ex) { MessageBox.Show("para gönderilemedi"+ex);}
            finally
            {
                if(connection != null)
                    connection.Close();
            }
            
        }
        
        private void alicibnaltxt_OnValueChanged(object sender, EventArgs e)
        {
            connection.Open();            
            SqlCommand isimal = new SqlCommand("SELECT Alici_hesap_adi FROM GelirGider WHERE Gelirgider.IBAN_no_alici ='"+alicibnaltxt.Text+"'", connection);
            isimal.Parameters.AddWithValue("@ad", hesapadCbox.Text);
            SqlDataReader oku = isimal.ExecuteReader();
            if (oku.Read())
            {
                aliciHesapadial = oku.GetString(0);
            }
            connection.Close();
        }
    }
}
