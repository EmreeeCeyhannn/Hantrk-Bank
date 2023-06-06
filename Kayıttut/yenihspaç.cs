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

namespace Kayıttut
{


    public partial class yenihspaç : Form
    {
        private static string sqliddeğeri;
        private int sqliddeğerint = Convert.ToInt32(sqliddeğeri);
        public void sqliddeğerim(string value)
        {
            sqliddeğeri = value;

        }

        public yenihspaç()
        {
            InitializeComponent();
        }

        private int rast()
        {
            Random rastgele_ibn = new Random();
            int ibnn = rastgele_ibn.Next(1000000, 6000000);
            return ibnn;
        }

        private void hspekl_Click(object sender, EventArgs e)
        {
            
            SqlConnection bağlantı = null;
            try
            {
                int a = Convert.ToInt32(müştnoal.Text);
                if (a == sqliddeğerint)
                {
                    string ibn = rast().ToString();
                    bağlantı = new SqlConnection(@"Data Source=EMRECEYHAN\SQLEXPRESS01;Initial Catalog=HanTürkDB;Integrated Security=True");
                    string query1 = "INSERT INTO GelirGider (IBAN_no_alici, IBAN_no_gonderen,KisiID,Gonderen_Hesap_adi,Alici_Hesap_adi) VALUES ('" + ibn + "','" + ibn + "','" + a + "','" + adialtxt.Text + "','" + adialtxt.Text + "')";
                    bağlantı.Open();
                    SqlCommand komut1 = new SqlCommand(query1, bağlantı);
                    komut1.ExecuteNonQuery();
                    MessageBox.Show("Hesap açma işlemi başarılı iban numaranız = " +ibn , "hesap açıldı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hesapaçpnl.Visible = false;
                }
                else
                {
                    MessageBox.Show("Lütfen müsteri numaranızı dogru bir biçimde girdiginizden emin olunuz", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (bağlantı != null)
                    bağlantı.Close();
            }

        }

        private void yenihspaç_Load(object sender, EventArgs e)
        {

        }

    }
}

